using System.Formats.Tar;
using System.Media;

namespace AS2324._3G.Prof.AutomobileWF
{
    public partial class Form1 : Form
    {

        const int stepAccelerazione = 10;
        const int stepFrenata = -5;
        const int maxVelocitaAuto = 160;

        double velocita = 0;

        public Form1()
        {
            InitializeComponent();

            // parameters setting on progress bar
            prbVelocita.Minimum = 0;
            prbVelocita.Maximum = maxVelocitaAuto;

            grbComandi.Enabled = false;
        }

        private void btnAccelera_Click(object sender, EventArgs e)
        {
            double incremento = stepAccelerazione + azioneVento(eMovimento.accelera);

            velocita += incremento;

            if (velocita > maxVelocitaAuto)
                velocita = maxVelocitaAuto;

            monitor(incremento);
        }

        private void btnFrena_Click(object sender, EventArgs e)
        {
            double incremento = stepFrenata + azioneVento(eMovimento.frena);

            velocita += incremento;

            if (velocita < 0)
                velocita = 0;

            monitor(incremento);
        }


        /// <summary>
        /// Nota sull'incidenza del vento in accelerazione o frenata :
        /// ==============================================
        /// Il vento abbiamo definito che può andare da un 20% dell'accelerazione 
        /// (+10) ad un 20% della frenata (-5) quindi è un numero casuale da -1 a +2 
        /// e se positivo vuol dire che soffia verso il senso di marcia (a favore) 
        /// se negativo soffia al contrario del senso di marcia e quindi se la 
        /// variabile casuale generata in accelerazione si aggiunge alla accelerazione 
        /// o se in frenata si sottrae.
        /// </summary>
        enum eMovimento
        {
            accelera,
            frena
        }
        private double azioneVento(eMovimento movimento)
        {
            double res = 0;

            // https://stackoverflow.com/questions/1064901/random-number-between-2-double-numbers

            const double maximum = stepAccelerazione * 20.0 / 100.0;
            const double minimum = stepFrenata * 20.0 / 100.0;

            Random r = new Random();
            double vento = r.NextDouble() * (maximum - minimum) + minimum;

            if (movimento == eMovimento.accelera)
                res = vento;
            else
                res = -vento;

            lblVento.Text = $"Vento {Math.Round(vento, 2)} km/h";

            return res;
        }

        private void monitor(double incrementoVelocita)
        {
            prbVelocita.Value = (int)velocita;
            lblVelocita.Text = $"{Math.Round(velocita, 1)} km/h";
            lblIncremento.Text = $"Incremento {Math.Round(incrementoVelocita, 2)} km/h";
        }

        private void chkAccensione_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccensione.Checked == true)
                grbComandi.Enabled = true;
            else
                grbComandi.Enabled = false;

        }

        private void btnClacson_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("assets\\car-honk-1.wav");

            try
            {
                player.Play();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while playing media.");
            }
            finally
            {
                player.Dispose();
            }
        }
    }
}
