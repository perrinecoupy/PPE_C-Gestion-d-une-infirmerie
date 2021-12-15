
namespace UtilisateursGUI
{
    partial class FrmModificationVisite
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.erreurChampsVides = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifierVisite = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxNomPrenomEleveVisite = new System.Windows.Forms.ListBox();
            this.lblNomPrenomEleveVisite = new System.Windows.Forms.Label();
            this.dateTimeDateVisite = new System.Windows.Forms.DateTimePicker();
            this.txtHeureDepartVisite = new System.Windows.Forms.TextBox();
            this.txtCommentairesVisite = new System.Windows.Forms.TextBox();
            this.lblNomEleve = new System.Windows.Forms.Label();
            this.txtMotifVisite = new System.Windows.Forms.TextBox();
            this.lblPrenomEleve = new System.Windows.Forms.Label();
            this.txtHeureArriveVisite = new System.Windows.Forms.TextBox();
            this.lblSanteEleve = new System.Windows.Forms.Label();
            this.lblClasseEleve = new System.Windows.Forms.Label();
            this.lblDateDeNaissance = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxMedicamentVisite = new System.Windows.Forms.ListBox();
            this.listBoxStatutVisite = new System.Windows.Forms.ListBox();
            this.listBoxPreventionParentsVisite = new System.Windows.Forms.ListBox();
            this.lblCommentairesSanteEleve = new System.Windows.Forms.Label();
            this.tiersTempsEleve = new System.Windows.Forms.Label();
            this.lblTelephoneEleve = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "MODIFICATION D\'UNE VISITE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UtilisateursGUI.Properties.Resources.logoinfirmiere;
            this.pictureBox1.Location = new System.Drawing.Point(8, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.erreurChampsVides);
            this.panel1.Controls.Add(this.btnAnnuler);
            this.panel1.Controls.Add(this.btnModifierVisite);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(11, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 345);
            this.panel1.TabIndex = 32;
            // 
            // erreurChampsVides
            // 
            this.erreurChampsVides.AutoSize = true;
            this.erreurChampsVides.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreurChampsVides.ForeColor = System.Drawing.Color.Red;
            this.erreurChampsVides.Location = new System.Drawing.Point(486, 290);
            this.erreurChampsVides.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurChampsVides.Name = "erreurChampsVides";
            this.erreurChampsVides.Size = new System.Drawing.Size(219, 19);
            this.erreurChampsVides.TabIndex = 26;
            this.erreurChampsVides.Text = "Veuillez remplir tous les champs";
            this.erreurChampsVides.Visible = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(457, 252);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(80, 25);
            this.btnAnnuler.TabIndex = 25;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifierVisite
            // 
            this.btnModifierVisite.Location = new System.Drawing.Point(541, 252);
            this.btnModifierVisite.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifierVisite.Name = "btnModifierVisite";
            this.btnModifierVisite.Size = new System.Drawing.Size(139, 25);
            this.btnModifierVisite.TabIndex = 24;
            this.btnModifierVisite.Text = "ENREGISTRER VISITE";
            this.btnModifierVisite.UseVisualStyleBackColor = true;
            this.btnModifierVisite.Click += new System.EventHandler(this.btnModifierVisite_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.listBoxNomPrenomEleveVisite);
            this.panel3.Controls.Add(this.lblNomPrenomEleveVisite);
            this.panel3.Controls.Add(this.dateTimeDateVisite);
            this.panel3.Controls.Add(this.txtHeureDepartVisite);
            this.panel3.Controls.Add(this.txtCommentairesVisite);
            this.panel3.Controls.Add(this.lblNomEleve);
            this.panel3.Controls.Add(this.txtMotifVisite);
            this.panel3.Controls.Add(this.lblPrenomEleve);
            this.panel3.Controls.Add(this.txtHeureArriveVisite);
            this.panel3.Controls.Add(this.lblSanteEleve);
            this.panel3.Controls.Add(this.lblClasseEleve);
            this.panel3.Controls.Add(this.lblDateDeNaissance);
            this.panel3.Location = new System.Drawing.Point(25, 17);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 292);
            this.panel3.TabIndex = 23;
            // 
            // listBoxNomPrenomEleveVisite
            // 
            this.listBoxNomPrenomEleveVisite.FormattingEnabled = true;
            this.listBoxNomPrenomEleveVisite.Location = new System.Drawing.Point(26, 33);
            this.listBoxNomPrenomEleveVisite.Name = "listBoxNomPrenomEleveVisite";
            this.listBoxNomPrenomEleveVisite.Size = new System.Drawing.Size(264, 17);
            this.listBoxNomPrenomEleveVisite.TabIndex = 35;
            // 
            // lblNomPrenomEleveVisite
            // 
            this.lblNomPrenomEleveVisite.AutoSize = true;
            this.lblNomPrenomEleveVisite.Location = new System.Drawing.Point(23, 17);
            this.lblNomPrenomEleveVisite.Name = "lblNomPrenomEleveVisite";
            this.lblNomPrenomEleveVisite.Size = new System.Drawing.Size(77, 13);
            this.lblNomPrenomEleveVisite.TabIndex = 34;
            this.lblNomPrenomEleveVisite.Text = "Nom de l\'élève";
            // 
            // dateTimeDateVisite
            // 
            this.dateTimeDateVisite.Location = new System.Drawing.Point(25, 69);
            this.dateTimeDateVisite.Name = "dateTimeDateVisite";
            this.dateTimeDateVisite.Size = new System.Drawing.Size(265, 20);
            this.dateTimeDateVisite.TabIndex = 33;
            // 
            // txtHeureDepartVisite
            // 
            this.txtHeureDepartVisite.Location = new System.Drawing.Point(25, 159);
            this.txtHeureDepartVisite.Name = "txtHeureDepartVisite";
            this.txtHeureDepartVisite.Size = new System.Drawing.Size(265, 20);
            this.txtHeureDepartVisite.TabIndex = 21;
            // 
            // txtCommentairesVisite
            // 
            this.txtCommentairesVisite.Location = new System.Drawing.Point(25, 256);
            this.txtCommentairesVisite.Name = "txtCommentairesVisite";
            this.txtCommentairesVisite.Size = new System.Drawing.Size(265, 20);
            this.txtCommentairesVisite.TabIndex = 20;
            // 
            // lblNomEleve
            // 
            this.lblNomEleve.AutoSize = true;
            this.lblNomEleve.Location = new System.Drawing.Point(23, 53);
            this.lblNomEleve.Name = "lblNomEleve";
            this.lblNomEleve.Size = new System.Drawing.Size(30, 13);
            this.lblNomEleve.TabIndex = 4;
            this.lblNomEleve.Text = "Date";
            // 
            // txtMotifVisite
            // 
            this.txtMotifVisite.Location = new System.Drawing.Point(25, 207);
            this.txtMotifVisite.Name = "txtMotifVisite";
            this.txtMotifVisite.Size = new System.Drawing.Size(265, 20);
            this.txtMotifVisite.TabIndex = 19;
            // 
            // lblPrenomEleve
            // 
            this.lblPrenomEleve.AutoSize = true;
            this.lblPrenomEleve.Location = new System.Drawing.Point(23, 97);
            this.lblPrenomEleve.Name = "lblPrenomEleve";
            this.lblPrenomEleve.Size = new System.Drawing.Size(73, 13);
            this.lblPrenomEleve.TabIndex = 6;
            this.lblPrenomEleve.Text = "Heure d\'arrivé";
            // 
            // txtHeureArriveVisite
            // 
            this.txtHeureArriveVisite.Location = new System.Drawing.Point(25, 113);
            this.txtHeureArriveVisite.Name = "txtHeureArriveVisite";
            this.txtHeureArriveVisite.Size = new System.Drawing.Size(265, 20);
            this.txtHeureArriveVisite.TabIndex = 8;
            // 
            // lblSanteEleve
            // 
            this.lblSanteEleve.AutoSize = true;
            this.lblSanteEleve.Location = new System.Drawing.Point(23, 239);
            this.lblSanteEleve.Name = "lblSanteEleve";
            this.lblSanteEleve.Size = new System.Drawing.Size(73, 13);
            this.lblSanteEleve.TabIndex = 12;
            this.lblSanteEleve.Text = "Commentaires";
            // 
            // lblClasseEleve
            // 
            this.lblClasseEleve.AutoSize = true;
            this.lblClasseEleve.Location = new System.Drawing.Point(23, 143);
            this.lblClasseEleve.Name = "lblClasseEleve";
            this.lblClasseEleve.Size = new System.Drawing.Size(84, 13);
            this.lblClasseEleve.TabIndex = 7;
            this.lblClasseEleve.Text = "Heure de départ";
            // 
            // lblDateDeNaissance
            // 
            this.lblDateDeNaissance.AutoSize = true;
            this.lblDateDeNaissance.Location = new System.Drawing.Point(23, 191);
            this.lblDateDeNaissance.Name = "lblDateDeNaissance";
            this.lblDateDeNaissance.Size = new System.Drawing.Size(30, 13);
            this.lblDateDeNaissance.TabIndex = 10;
            this.lblDateDeNaissance.Text = "Motif";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.listBoxMedicamentVisite);
            this.panel2.Controls.Add(this.listBoxStatutVisite);
            this.panel2.Controls.Add(this.listBoxPreventionParentsVisite);
            this.panel2.Controls.Add(this.lblCommentairesSanteEleve);
            this.panel2.Controls.Add(this.tiersTempsEleve);
            this.panel2.Controls.Add(this.lblTelephoneEleve);
            this.panel2.Location = new System.Drawing.Point(378, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 217);
            this.panel2.TabIndex = 22;
            // 
            // listBoxMedicamentVisite
            // 
            this.listBoxMedicamentVisite.FormattingEnabled = true;
            this.listBoxMedicamentVisite.Location = new System.Drawing.Point(19, 33);
            this.listBoxMedicamentVisite.Name = "listBoxMedicamentVisite";
            this.listBoxMedicamentVisite.Size = new System.Drawing.Size(256, 17);
            this.listBoxMedicamentVisite.TabIndex = 27;
            // 
            // listBoxStatutVisite
            // 
            this.listBoxStatutVisite.FormattingEnabled = true;
            this.listBoxStatutVisite.Items.AddRange(new object[] {
            "Maison",
            "Hôpital",
            "Classe"});
            this.listBoxStatutVisite.Location = new System.Drawing.Point(19, 85);
            this.listBoxStatutVisite.Name = "listBoxStatutVisite";
            this.listBoxStatutVisite.Size = new System.Drawing.Size(256, 43);
            this.listBoxStatutVisite.TabIndex = 26;
            // 
            // listBoxPreventionParentsVisite
            // 
            this.listBoxPreventionParentsVisite.FormattingEnabled = true;
            this.listBoxPreventionParentsVisite.Items.AddRange(new object[] {
            "Oui",
            "Non"});
            this.listBoxPreventionParentsVisite.Location = new System.Drawing.Point(19, 159);
            this.listBoxPreventionParentsVisite.Name = "listBoxPreventionParentsVisite";
            this.listBoxPreventionParentsVisite.Size = new System.Drawing.Size(257, 30);
            this.listBoxPreventionParentsVisite.TabIndex = 23;
            // 
            // lblCommentairesSanteEleve
            // 
            this.lblCommentairesSanteEleve.AutoSize = true;
            this.lblCommentairesSanteEleve.Location = new System.Drawing.Point(16, 143);
            this.lblCommentairesSanteEleve.Name = "lblCommentairesSanteEleve";
            this.lblCommentairesSanteEleve.Size = new System.Drawing.Size(116, 13);
            this.lblCommentairesSanteEleve.TabIndex = 17;
            this.lblCommentairesSanteEleve.Text = "Prévention des parents";
            // 
            // tiersTempsEleve
            // 
            this.tiersTempsEleve.AutoSize = true;
            this.tiersTempsEleve.Location = new System.Drawing.Point(16, 69);
            this.tiersTempsEleve.Name = "tiersTempsEleve";
            this.tiersTempsEleve.Size = new System.Drawing.Size(62, 13);
            this.tiersTempsEleve.TabIndex = 16;
            this.tiersTempsEleve.Text = "Statut visite";
            // 
            // lblTelephoneEleve
            // 
            this.lblTelephoneEleve.AutoSize = true;
            this.lblTelephoneEleve.Location = new System.Drawing.Point(17, 17);
            this.lblTelephoneEleve.Name = "lblTelephoneEleve";
            this.lblTelephoneEleve.Size = new System.Drawing.Size(102, 13);
            this.lblTelephoneEleve.TabIndex = 14;
            this.lblTelephoneEleve.Text = "Médicament prescrit";
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.Location = new System.Drawing.Point(538, 51);
            this.lblSuccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(192, 19);
            this.lblSuccess.TabIndex = 37;
            this.lblSuccess.Text = "La visite a bien été modifiée";
            this.lblSuccess.Visible = false;
            // 
            // FrmModificationVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 459);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmModificationVisite";
            this.Text = "ModificationVisite";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label erreurChampsVides;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifierVisite;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBoxNomPrenomEleveVisite;
        private System.Windows.Forms.Label lblNomPrenomEleveVisite;
        private System.Windows.Forms.DateTimePicker dateTimeDateVisite;
        private System.Windows.Forms.TextBox txtHeureDepartVisite;
        private System.Windows.Forms.TextBox txtCommentairesVisite;
        private System.Windows.Forms.Label lblNomEleve;
        private System.Windows.Forms.TextBox txtMotifVisite;
        private System.Windows.Forms.Label lblPrenomEleve;
        private System.Windows.Forms.TextBox txtHeureArriveVisite;
        private System.Windows.Forms.Label lblSanteEleve;
        private System.Windows.Forms.Label lblClasseEleve;
        private System.Windows.Forms.Label lblDateDeNaissance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxMedicamentVisite;
        private System.Windows.Forms.ListBox listBoxStatutVisite;
        private System.Windows.Forms.ListBox listBoxPreventionParentsVisite;
        private System.Windows.Forms.Label lblCommentairesSanteEleve;
        private System.Windows.Forms.Label tiersTempsEleve;
        private System.Windows.Forms.Label lblTelephoneEleve;
        private System.Windows.Forms.Label lblSuccess;
    }
}