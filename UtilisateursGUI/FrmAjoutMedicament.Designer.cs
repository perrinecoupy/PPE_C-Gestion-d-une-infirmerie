﻿
namespace UtilisateursGUI
{
    partial class FrmAjoutMedicament
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNomEleve = new System.Windows.Forms.Label();
            this.txtDateDeNaissanceEleve = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UtilisateursGUI.Properties.Resources.logoinfirmiere;
            this.pictureBox1.Location = new System.Drawing.Point(28, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 185);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "AJOUT D\'UN MEDICAMENT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(59, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 271);
            this.panel1.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 38);
            this.button2.TabIndex = 25;
            this.button2.Text = "ANNULER";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 38);
            this.button1.TabIndex = 24;
            this.button1.Text = "ENREGISTRER MEDICAMENT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.lblNomEleve);
            this.panel3.Controls.Add(this.txtDateDeNaissanceEleve);
            this.panel3.Location = new System.Drawing.Point(38, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 163);
            this.panel3.TabIndex = 23;
            // 
            // lblNomEleve
            // 
            this.lblNomEleve.AutoSize = true;
            this.lblNomEleve.Location = new System.Drawing.Point(34, 50);
            this.lblNomEleve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomEleve.Name = "lblNomEleve";
            this.lblNomEleve.Size = new System.Drawing.Size(42, 20);
            this.lblNomEleve.TabIndex = 4;
            this.lblNomEleve.Text = "Nom";
            // 
            // txtDateDeNaissanceEleve
            // 
            this.txtDateDeNaissanceEleve.Location = new System.Drawing.Point(38, 75);
            this.txtDateDeNaissanceEleve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDateDeNaissanceEleve.Name = "txtDateDeNaissanceEleve";
            this.txtDateDeNaissanceEleve.Size = new System.Drawing.Size(470, 26);
            this.txtDateDeNaissanceEleve.TabIndex = 11;
            // 
            // FrmAjoutMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmAjoutMedicament";
            this.Text = "FrmAjoutMedicament";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNomEleve;
        private System.Windows.Forms.TextBox txtDateDeNaissanceEleve;
    }
}