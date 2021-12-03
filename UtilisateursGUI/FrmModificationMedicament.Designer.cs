
namespace UtilisateursGUI
{
    partial class FrmModificationMedicament
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifierMedicament = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNomEleve = new System.Windows.Forms.Label();
            this.txtNomMedicament = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.erreurChampsVides = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnAnnuler);
            this.panel1.Controls.Add(this.btnModifierMedicament);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(59, 127);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 176);
            this.panel1.TabIndex = 28;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(153, 137);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(80, 25);
            this.btnAnnuler.TabIndex = 25;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifierMedicament
            // 
            this.btnModifierMedicament.Location = new System.Drawing.Point(237, 137);
            this.btnModifierMedicament.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifierMedicament.Name = "btnModifierMedicament";
            this.btnModifierMedicament.Size = new System.Drawing.Size(153, 25);
            this.btnModifierMedicament.TabIndex = 24;
            this.btnModifierMedicament.Text = "MODIFIER MEDICAMENT";
            this.btnModifierMedicament.UseVisualStyleBackColor = true;
            this.btnModifierMedicament.Click += new System.EventHandler(this.btnModifierMedicament_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.lblNomEleve);
            this.panel3.Controls.Add(this.txtNomMedicament);
            this.panel3.Location = new System.Drawing.Point(25, 17);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(381, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "MODIFICATION D\'UN MEDICAMENT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UtilisateursGUI.Properties.Resources.logoinfirmiere;
            this.pictureBox1.Location = new System.Drawing.Point(33, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.Location = new System.Drawing.Point(319, 305);
            this.lblSuccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(232, 19);
            this.lblSuccess.TabIndex = 37;
            this.lblSuccess.Text = "Le médicament a bien été modifié";
            this.lblSuccess.Visible = false;
            // 
            // erreurChampsVides
            // 
            this.erreurChampsVides.AutoSize = true;
            this.erreurChampsVides.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreurChampsVides.ForeColor = System.Drawing.Color.Red;
            this.erreurChampsVides.Location = new System.Drawing.Point(55, 305);
            this.erreurChampsVides.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurChampsVides.Name = "erreurChampsVides";
            this.erreurChampsVides.Size = new System.Drawing.Size(219, 19);
            this.erreurChampsVides.TabIndex = 38;
            this.erreurChampsVides.Text = "Veuillez remplir tous les champs";
            this.erreurChampsVides.Visible = false;
            // 
            // FrmModificationMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 348);
            this.Controls.Add(this.erreurChampsVides);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmModificationMedicament";
            this.Text = "FrmModificationMedicament";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifierMedicament;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNomEleve;
        private System.Windows.Forms.TextBox txtNomMedicament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label erreurChampsVides;
    }
}