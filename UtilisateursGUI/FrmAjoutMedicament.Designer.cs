
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
            this.btnAnnulerMedicament = new System.Windows.Forms.Button();
            this.btnAjoutMedicament = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNomEleve = new System.Windows.Forms.Label();
            this.txtNomMedicament = new System.Windows.Forms.TextBox();
            this.erreurChampsVides = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UtilisateursGUI.Properties.Resources.logoinfirmiere;
            this.pictureBox1.Location = new System.Drawing.Point(19, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(366, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "AJOUT D\'UN MEDICAMENT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnAnnulerMedicament);
            this.panel1.Controls.Add(this.btnAjoutMedicament);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(39, 157);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 176);
            this.panel1.TabIndex = 25;
            // 
            // btnAnnulerMedicament
            // 
            this.btnAnnulerMedicament.Location = new System.Drawing.Point(126, 137);
            this.btnAnnulerMedicament.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnulerMedicament.Name = "btnAnnulerMedicament";
            this.btnAnnulerMedicament.Size = new System.Drawing.Size(80, 25);
            this.btnAnnulerMedicament.TabIndex = 25;
            this.btnAnnulerMedicament.Text = "ANNULER";
            this.btnAnnulerMedicament.UseVisualStyleBackColor = true;
            // 
            // btnAjoutMedicament
            // 
            this.btnAjoutMedicament.Location = new System.Drawing.Point(211, 137);
            this.btnAjoutMedicament.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjoutMedicament.Name = "btnAjoutMedicament";
            this.btnAjoutMedicament.Size = new System.Drawing.Size(179, 25);
            this.btnAjoutMedicament.TabIndex = 24;
            this.btnAjoutMedicament.Text = "ENREGISTRER MEDICAMENT";
            this.btnAjoutMedicament.UseVisualStyleBackColor = true;
            this.btnAjoutMedicament.Click += new System.EventHandler(this.btnAjoutMedicament_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.lblNomEleve);
            this.panel3.Controls.Add(this.txtNomMedicament);
            this.panel3.Location = new System.Drawing.Point(25, 17);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 106);
            this.panel3.TabIndex = 23;
            // 
            // lblNomEleve
            // 
            this.lblNomEleve.AutoSize = true;
            this.lblNomEleve.Location = new System.Drawing.Point(23, 32);
            this.lblNomEleve.Name = "lblNomEleve";
            this.lblNomEleve.Size = new System.Drawing.Size(29, 13);
            this.lblNomEleve.TabIndex = 4;
            this.lblNomEleve.Text = "Nom";
            // 
            // txtNomMedicament
            // 
            this.txtNomMedicament.Location = new System.Drawing.Point(25, 49);
            this.txtNomMedicament.Name = "txtNomMedicament";
            this.txtNomMedicament.Size = new System.Drawing.Size(315, 20);
            this.txtNomMedicament.TabIndex = 11;
            // 
            // erreurChampsVides
            // 
            this.erreurChampsVides.AutoSize = true;
            this.erreurChampsVides.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreurChampsVides.ForeColor = System.Drawing.Color.Red;
            this.erreurChampsVides.Location = new System.Drawing.Point(256, 92);
            this.erreurChampsVides.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurChampsVides.Name = "erreurChampsVides";
            this.erreurChampsVides.Size = new System.Drawing.Size(219, 19);
            this.erreurChampsVides.TabIndex = 26;
            this.erreurChampsVides.Text = "Veuillez remplir tous les champs";
            this.erreurChampsVides.Visible = false;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.Location = new System.Drawing.Point(251, 71);
            this.lblSuccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(224, 19);
            this.lblSuccess.TabIndex = 36;
            this.lblSuccess.Text = "Le médicament a bien été ajouté";
            this.lblSuccess.Visible = false;
            // 
            // FrmAjoutMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 351);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.erreurChampsVides);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnAnnulerMedicament;
        private System.Windows.Forms.Button btnAjoutMedicament;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNomEleve;
        private System.Windows.Forms.TextBox txtNomMedicament;
        private System.Windows.Forms.Label erreurChampsVides;
        private System.Windows.Forms.Label lblSuccess;
    }
}