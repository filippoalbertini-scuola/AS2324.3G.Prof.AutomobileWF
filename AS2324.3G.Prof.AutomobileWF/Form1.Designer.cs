﻿namespace AS2324._3G.Prof.AutomobileWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar1 = new ProgressBar();
            lblVelocita = new Label();
            btnAccellera = new Button();
            btnFrena = new Button();
            chkAccensione = new CheckBox();
            label1 = new Label();
            chkCinture = new CheckBox();
            btnClacson = new Button();
            lstMonitor = new ListBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            cmbStrada = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(32, 401);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(683, 29);
            progressBar1.TabIndex = 0;
            // 
            // lblVelocita
            // 
            lblVelocita.AutoSize = true;
            lblVelocita.Location = new Point(721, 401);
            lblVelocita.Name = "lblVelocita";
            lblVelocita.Size = new Size(55, 20);
            lblVelocita.TabIndex = 1;
            lblVelocita.Text = "0 km/h";
            // 
            // btnAccellera
            // 
            btnAccellera.Location = new Point(116, 26);
            btnAccellera.Name = "btnAccellera";
            btnAccellera.Size = new Size(94, 29);
            btnAccellera.TabIndex = 2;
            btnAccellera.Text = "Accellera";
            btnAccellera.UseVisualStyleBackColor = true;
            // 
            // btnFrena
            // 
            btnFrena.Location = new Point(9, 26);
            btnFrena.Name = "btnFrena";
            btnFrena.Size = new Size(101, 29);
            btnFrena.TabIndex = 3;
            btnFrena.Text = "Frena";
            btnFrena.UseVisualStyleBackColor = true;
            // 
            // chkAccensione
            // 
            chkAccensione.AutoSize = true;
            chkAccensione.Location = new Point(58, 127);
            chkAccensione.Name = "chkAccensione";
            chkAccensione.Size = new Size(149, 24);
            chkAccensione.TabIndex = 4;
            chkAccensione.Text = "Accendi il motore";
            chkAccensione.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(494, 13);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 5;
            label1.Text = "Vento 10 km/h";
            // 
            // chkCinture
            // 
            chkCinture.AutoSize = true;
            chkCinture.Location = new Point(58, 98);
            chkCinture.Name = "chkCinture";
            chkCinture.Size = new Size(78, 24);
            chkCinture.TabIndex = 6;
            chkCinture.Text = "Cinture";
            chkCinture.UseVisualStyleBackColor = true;
            // 
            // btnClacson
            // 
            btnClacson.Location = new Point(593, 157);
            btnClacson.Name = "btnClacson";
            btnClacson.Size = new Size(122, 47);
            btnClacson.TabIndex = 7;
            btnClacson.Text = "Clacson";
            btnClacson.UseVisualStyleBackColor = true;
            // 
            // lstMonitor
            // 
            lstMonitor.FormattingEnabled = true;
            lstMonitor.ItemHeight = 20;
            lstMonitor.Location = new Point(30, 276);
            lstMonitor.Name = "lstMonitor";
            lstMonitor.Size = new Size(758, 104);
            lstMonitor.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAccellera);
            groupBox1.Controls.Add(btnFrena);
            groupBox1.Location = new Point(526, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 68);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 163);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 10;
            label2.Text = "Strada";
            // 
            // cmbStrada
            // 
            cmbStrada.FormattingEnabled = true;
            cmbStrada.Items.AddRange(new object[] { "Autostrada (130 km/h)", "Extraurbana (90 km/h)", "Urbana (50 km/h)" });
            cmbStrada.Location = new Point(113, 157);
            cmbStrada.Name = "cmbStrada";
            cmbStrada.Size = new Size(167, 28);
            cmbStrada.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbStrada);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(lstMonitor);
            Controls.Add(btnClacson);
            Controls.Add(chkCinture);
            Controls.Add(label1);
            Controls.Add(chkAccensione);
            Controls.Add(lblVelocita);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Prof;AS 23/24 3G Lab 2.2;04/04/24; simulatore di un automobile";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label lblVelocita;
        private Button btnAccellera;
        private Button btnFrena;
        private CheckBox chkAccensione;
        private Label label1;
        private CheckBox chkCinture;
        private Button btnClacson;
        private ListBox lstMonitor;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox cmbStrada;
    }
}
