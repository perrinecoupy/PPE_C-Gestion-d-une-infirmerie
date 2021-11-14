
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
            this.bnbNonSuppressionEleve = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSuppressionEleve
            // 
            this.lblSuppressionEleve.AutoSize = true;
            this.lblSuppressionEleve.Location = new System.Drawing.Point(47, 144);
            this.lblSuppressionEleve.Name = "lblSuppressionEleve";
            this.lblSuppressionEleve.Size = new System.Drawing.Size(169, 13);
            this.lblSuppressionEleve.TabIndex = 24;
            this.lblSuppressionEleve.Text = "Voulez-vous supprimer cet élève ?";
            // 
            // bnbOuiSuppressionEleve
            // 
            this.bnbOuiSuppressionEleve.Location = new System.Drawing.Point(63, 193);
            this.bnbOuiSuppressionEleve.Name = "bnbOuiSuppressionEleve";
            this.bnbOuiSuppressionEleve.Size = new System.Drawing.Size(104, 41);
            this.bnbOuiSuppressionEleve.TabIndex = 25;
            this.bnbOuiSuppressionEleve.Text = "Oui";
            this.bnbOuiSuppressionEleve.UseVisualStyleBackColor = true;
            // 
            // bnbNonSuppressionEleve
            // 
            this.bnbNonSuppressionEleve.Location = new System.Drawing.Point(375, 193);
            this.bnbNonSuppressionEleve.Name = "bnbNonSuppressionEleve";
            this.bnbNonSuppressionEleve.Size = new System.Drawing.Size(104, 41);
            this.bnbNonSuppressionEleve.TabIndex = 26;
            this.bnbNonSuppressionEleve.Text = "Non";
            this.bnbNonSuppressionEleve.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UtilisateursGUI.Properties.Resources.logoinfirmiere;
            this.pictureBox1.Location = new System.Drawing.Point(50, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSuppressionEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.bnbNonSuppressionEleve);
            this.Controls.Add(this.bnbOuiSuppressionEleve);
            this.Controls.Add(this.lblSuppressionEleve);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmSuppressionEleve";
            this.Text = "SuppressionEleve";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSuppressionEleve;
        private System.Windows.Forms.Button bnbOuiSuppressionEleve;
        private System.Windows.Forms.Button bnbNonSuppressionEleve;
    }
}