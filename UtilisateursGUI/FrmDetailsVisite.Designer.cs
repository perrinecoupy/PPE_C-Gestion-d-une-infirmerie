
namespace UtilisateursGUI
{
    partial class FrmDetailsVisite
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
            this.lblDetailsVisite = new System.Windows.Forms.Label();
            this.btnModifierVisite = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnAjoutVisite = new System.Windows.Forms.Button();
            this.dataGridViewVisite = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisite)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UtilisateursGUI.Properties.Resources.logoinfirmiere;
            this.pictureBox1.Location = new System.Drawing.Point(50, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblDetailsVisite
            // 
            this.lblDetailsVisite.AutoSize = true;
            this.lblDetailsVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsVisite.Location = new System.Drawing.Point(412, 65);
            this.lblDetailsVisite.Name = "lblDetailsVisite";
            this.lblDetailsVisite.Size = new System.Drawing.Size(233, 31);
            this.lblDetailsVisite.TabIndex = 29;
            this.lblDetailsVisite.Text = "Détails des visites";
            // 
            // btnModifierVisite
            // 
            this.btnModifierVisite.Location = new System.Drawing.Point(218, 134);
            this.btnModifierVisite.Name = "btnModifierVisite";
            this.btnModifierVisite.Size = new System.Drawing.Size(138, 23);
            this.btnModifierVisite.TabIndex = 34;
            this.btnModifierVisite.Text = "Modifier une visite";
            this.btnModifierVisite.UseVisualStyleBackColor = true;
            this.btnModifierVisite.Click += new System.EventHandler(this.btnModifierVisite_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(362, 134);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(138, 23);
            this.btnRetour.TabIndex = 33;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnAjoutVisite
            // 
            this.btnAjoutVisite.Location = new System.Drawing.Point(50, 134);
            this.btnAjoutVisite.Name = "btnAjoutVisite";
            this.btnAjoutVisite.Size = new System.Drawing.Size(162, 23);
            this.btnAjoutVisite.TabIndex = 32;
            this.btnAjoutVisite.Text = "Ajouter une nouvelle visite";
            this.btnAjoutVisite.UseVisualStyleBackColor = true;
            this.btnAjoutVisite.Click += new System.EventHandler(this.btnAjoutVisite_Click);
            // 
            // dataGridViewVisite
            // 
            this.dataGridViewVisite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisite.Location = new System.Drawing.Point(12, 163);
            this.dataGridViewVisite.Name = "dataGridViewVisite";
            this.dataGridViewVisite.Size = new System.Drawing.Size(1159, 150);
            this.dataGridViewVisite.TabIndex = 36;
            // 
            // FrmDetailsVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 450);
            this.Controls.Add(this.dataGridViewVisite);
            this.Controls.Add(this.btnModifierVisite);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnAjoutVisite);
            this.Controls.Add(this.lblDetailsVisite);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmDetailsVisite";
            this.Text = "DetailsVisite";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDetailsVisite;
        private System.Windows.Forms.Button btnModifierVisite;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnAjoutVisite;
        private System.Windows.Forms.DataGridView dataGridViewVisite;
    }
}