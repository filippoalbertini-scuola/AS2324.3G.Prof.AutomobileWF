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
            btnAccellera.Location = new Point(653, 95);
            btnAccellera.Name = "btnAccellera";
            btnAccellera.Size = new Size(94, 29);
            btnAccellera.TabIndex = 2;
            btnAccellera.Text = "Accellera";
            btnAccellera.UseVisualStyleBackColor = true;
            // 
            // btnFrena
            // 
            btnFrena.Location = new Point(553, 95);
            btnFrena.Name = "btnFrena";
            btnFrena.Size = new Size(94, 29);
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
            btnClacson.Location = new Point(606, 157);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstMonitor);
            Controls.Add(btnClacson);
            Controls.Add(chkCinture);
            Controls.Add(label1);
            Controls.Add(chkAccensione);
            Controls.Add(btnFrena);
            Controls.Add(btnAccellera);
            Controls.Add(lblVelocita);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Prof;AS 23/24 3G Lab 2.2;04/04/24; simulatore di un automobile";
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
    }
}
