
namespace UtilisateursGUI
{
    partial class FrmDetailsMedicament
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
            this.dataGridViewMedicament = new System.Windows.Forms.DataGridView();
            this.lblDetailsMedicaments = new System.Windows.Forms.Label();
            this.btnAjoutMedicament = new System.Windows.Forms.Button();
            this.btnModifierMedicament = new System.Windows.Forms.Button();
            this.btnSupprimerMedicament = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMedicament
            // 
            this.dataGridViewMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicament.Location = new System.Drawing.Point(12, 167);
            this.dataGridViewMedicament.Name = "dataGridViewMedicament";
            this.dataGridViewMedicament.Size = new System.Drawing.Size(527, 252);
            this.dataGridViewMedicament.TabIndex = 0;
            // 
            // lblDetailsMedicaments
            // 
            this.lblDetailsMedicaments.AutoSize = true;
            this.lblDetailsMedicaments.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsMedicaments.Location = new System.Drawing.Point(72, 96);
            this.lblDetailsMedicaments.Name = "lblDetailsMedicaments";
            this.lblDetailsMedicaments.Size = new System.Drawing.Size(399, 31);
            this.lblDetailsMedicaments.TabIndex = 1;
            this.lblDetailsMedicaments.Text = "DETAILS DES MEDICAMENTS";
            // 
            // btnAjoutMedicament
            // 
            this.btnAjoutMedicament.Location = new System.Drawing.Point(13, 138);
            this.btnAjoutMedicament.Name = "btnAjoutMedicament";
            this.btnAjoutMedicament.Size = new System.Drawing.Size(169, 23);
            this.btnAjoutMedicament.TabIndex = 28;
            this.btnAjoutMedicament.Text = "Ajouter un nouveau médicament";
            this.btnAjoutMedicament.UseVisualStyleBackColor = true;
            this.btnAjoutMedicament.Click += new System.EventHandler(this.btnAjoutMedicament_Click);
            // 
            // btnModifierMedicament
            // 
            this.btnModifierMedicament.Location = new System.Drawing.Point(188, 138);
            this.btnModifierMedicament.Name = "btnModifierMedicament";
            this.btnModifierMedicament.Size = new System.Drawing.Size(128, 23);
            this.btnModifierMedicament.TabIndex = 29;
            this.btnModifierMedicament.Text = "Modifier un médicament";
            this.btnModifierMedicament.UseVisualStyleBackColor = true;
            this.btnModifierMedicament.Click += new System.EventHandler(this.btnModifierMedicament_Click);
            // 
            // btnSupprimerMedicament
            // 
            this.btnSupprimerMedicament.Location = new System.Drawing.Point(322, 138);
            this.btnSupprimerMedicament.Name = "btnSupprimerMedicament";
            this.btnSupprimerMedicament.Size = new System.Drawing.Size(143, 23);
            this.btnSupprimerMedicament.TabIndex = 30;
            this.btnSupprimerMedicament.Text = "Supprimer un médicament";
            this.btnSupprimerMedicament.UseVisualStyleBackColor = true;
            this.btnSupprimerMedicament.Click += new System.EventHandler(this.btnSupprimerMedicament_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UtilisateursGUI.Properties.Resources.logoinfirmiere;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(471, 138);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(68, 23);
            this.btnRetour.TabIndex = 31;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FrmDetailsMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnSupprimerMedicament);
            this.Controls.Add(this.btnModifierMedicament);
            this.Controls.Add(this.btnAjoutMedicament);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDetailsMedicaments);
            this.Controls.Add(this.dataGridViewMedicament);
            this.Name = "FrmDetailsMedicament";
            this.Text = "FrmDetailsMedicament";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMedicament;
        private System.Windows.Forms.Label lblDetailsMedicaments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAjoutMedicament;
        private System.Windows.Forms.Button btnModifierMedicament;
        private System.Windows.Forms.Button btnSupprimerMedicament;
        private System.Windows.Forms.Button btnRetour;
    }
}