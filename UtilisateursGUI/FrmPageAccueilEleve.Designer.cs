
namespace UtilisateursGUI
{
    partial class FrmPageAccueilEleve
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
            this.lblNomEleveRecherche = new System.Windows.Forms.Label();
            this.txtNomEleveRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UtilisateursGUI.Properties.Resources.logoinfirmiere;
            this.pictureBox1.Location = new System.Drawing.Point(48, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblNomEleveRecherche
            // 
            this.lblNomEleveRecherche.AutoSize = true;
            this.lblNomEleveRecherche.Location = new System.Drawing.Point(48, 167);
            this.lblNomEleveRecherche.Name = "lblNomEleveRecherche";
            this.lblNomEleveRecherche.Size = new System.Drawing.Size(77, 13);
            this.lblNomEleveRecherche.TabIndex = 3;
            this.lblNomEleveRecherche.Text = "Nom de l\'élève";
            // 
            // txtNomEleveRecherche
            // 
            this.txtNomEleveRecherche.Location = new System.Drawing.Point(48, 199);
            this.txtNomEleveRecherche.Name = "txtNomEleveRecherche";
            this.txtNomEleveRecherche.Size = new System.Drawing.Size(447, 20);
            this.txtNomEleveRecherche.TabIndex = 4;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(214, 260);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(119, 44);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "Valider";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // FrmPageAccueilEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtNomEleveRecherche);
            this.Controls.Add(this.lblNomEleveRecherche);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmPageAccueilEleve";
            this.Text = "FrmPageAccueilEleve";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNomEleveRecherche;
        private System.Windows.Forms.TextBox txtNomEleveRecherche;
        private System.Windows.Forms.Button btnRechercher;
    }
}