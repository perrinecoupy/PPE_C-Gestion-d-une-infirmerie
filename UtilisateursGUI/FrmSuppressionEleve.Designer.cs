﻿
namespace UtilisateursGUI
{
    partial class FrmSuppressionEleve
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
            this.lblSuppressionEleve = new System.Windows.Forms.Label();
            this.bnbOuiSuppressionEleve = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSuppressionEleve
            // 
            this.lblSuppressionEleve.AutoSize = true;
            this.lblSuppressionEleve.Location = new System.Drawing.Point(50, 188);
            this.lblSuppressionEleve.Name = "lblSuppressionEleve";
            this.lblSuppressionEleve.Size = new System.Drawing.Size(267, 20);
            this.lblSuppressionEleve.TabIndex = 24;
            this.lblSuppressionEleve.Text = "Voulez-vous supprimer cet élève ?";
            // 
            // bnbOuiSuppressionEleve
            // 
            this.bnbOuiSuppressionEleve.Location = new System.Drawing.Point(99, 234);
            this.bnbOuiSuppressionEleve.Name = "bnbOuiSuppressionEleve";
            this.bnbOuiSuppressionEleve.Size = new System.Drawing.Size(87, 32);
            this.bnbOuiSuppressionEleve.TabIndex = 25;
            this.bnbOuiSuppressionEleve.Text = "Oui";
            this.bnbOuiSuppressionEleve.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UtilisateursGUI.Properties.Resources.logoinfirmiere;
            this.pictureBox1.Location = new System.Drawing.Point(49, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 32);
            this.button2.TabIndex = 29;
            this.button2.Text = "Non";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 47);
            this.label1.TabIndex = 30;
            this.label1.Text = "SUPPRESSION D\'UN ELEVE";
            // 
            // FrmSuppressionEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bnbOuiSuppressionEleve);
            this.Controls.Add(this.lblSuppressionEleve);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmSuppressionEleve";
            this.Text = "SuppressionEleve";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSuppressionEleve;
        private System.Windows.Forms.Button bnbOuiSuppressionEleve;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}