
namespace UtilisateursGUI
{
    partial class FrmModificationEleve
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
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.erreurChampsVides = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtmDateDeNaissanceEleve = new System.Windows.Forms.DateTimePicker();
            this.dpdClasse = new System.Windows.Forms.ComboBox();
            this.txtSanteEleve = new System.Windows.Forms.TextBox();
            this.lblNomEleve = new System.Windows.Forms.Label();
            this.txtNomEleve = new System.Windows.Forms.TextBox();
            this.lblPrenomEleve = new System.Windows.Forms.Label();
            this.txtPrenomEleve = new System.Windows.Forms.TextBox();
            this.lblSanteEleve = new System.Windows.Forms.Label();
            this.lblClasseEleve = new System.Windows.Forms.Label();
            this.lblDateDeNaissance = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTiersTempsEleve = new System.Windows.Forms.TextBox();
            this.lblCommentairesSanteEleve = new System.Windows.Forms.Label();
            this.txtCommentairesSanteEleve = new System.Windows.Forms.TextBox();
            this.txtTelephoneEleve = new System.Windows.Forms.TextBox();
            this.tiersTempsEleve = new System.Windows.Forms.Label();
            this.lblTelephoneEleve = new System.Windows.Forms.Label();
            this.lblTelephoneParentEleve = new System.Windows.Forms.Label();
            this.txtTelephoneParentEleve = new System.Windows.Forms.TextBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblDiplomeEleve = new System.Windows.Forms.Label();
            this.dpdDiplome = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UtilisateursGUI.Properties.Resources.logoinfirmiere;
            this.pictureBox1.Location = new System.Drawing.Point(46, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(457, 271);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(80, 25);
            this.btnAnnuler.TabIndex = 25;
            this.btnAnnuler.Text = "RETOUR";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(541, 271);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(139, 25);
            this.btnModifier.TabIndex = 24;
            this.btnModifier.Text = "MODIFIER ELEVE";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "MODIFICATION D\'UN ELEVE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAnnuler);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Location = new System.Drawing.Point(46, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 299);
            this.panel1.TabIndex = 25;
            // 
            // erreurChampsVides
            // 
            this.erreurChampsVides.AutoSize = true;
            this.erreurChampsVides.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erreurChampsVides.ForeColor = System.Drawing.Color.Red;
            this.erreurChampsVides.Location = new System.Drawing.Point(536, 422);
            this.erreurChampsVides.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erreurChampsVides.Name = "erreurChampsVides";
            this.erreurChampsVides.Size = new System.Drawing.Size(219, 19);
            this.erreurChampsVides.TabIndex = 37;
            this.erreurChampsVides.Text = "Veuillez remplir tous les champs";
            this.erreurChampsVides.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.dtmDateDeNaissanceEleve);
            this.panel3.Controls.Add(this.dpdClasse);
            this.panel3.Controls.Add(this.txtSanteEleve);
            this.panel3.Controls.Add(this.lblNomEleve);
            this.panel3.Controls.Add(this.txtNomEleve);
            this.panel3.Controls.Add(this.lblPrenomEleve);
            this.panel3.Controls.Add(this.txtPrenomEleve);
            this.panel3.Controls.Add(this.lblSanteEleve);
            this.panel3.Controls.Add(this.lblClasseEleve);
            this.panel3.Controls.Add(this.lblDateDeNaissance);
            this.panel3.Location = new System.Drawing.Point(27, 16);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 267);
            this.panel3.TabIndex = 27;
            // 
            // dtmDateDeNaissanceEleve
            // 
            this.dtmDateDeNaissanceEleve.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDateDeNaissanceEleve.Location = new System.Drawing.Point(26, 186);
            this.dtmDateDeNaissanceEleve.Margin = new System.Windows.Forms.Padding(2);
            this.dtmDateDeNaissanceEleve.Name = "dtmDateDeNaissanceEleve";
            this.dtmDateDeNaissanceEleve.Size = new System.Drawing.Size(264, 24);
            this.dtmDateDeNaissanceEleve.TabIndex = 37;
            this.dtmDateDeNaissanceEleve.Value = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            // 
            // dpdClasse
            // 
            this.dpdClasse.DisplayMember = "libelle_classe";
            this.dpdClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dpdClasse.FormattingEnabled = true;
            this.dpdClasse.Location = new System.Drawing.Point(25, 141);
            this.dpdClasse.Name = "dpdClasse";
            this.dpdClasse.Size = new System.Drawing.Size(265, 21);
            this.dpdClasse.TabIndex = 34;
            this.dpdClasse.ValueMember = "id_classe";
            // 
            // txtSanteEleve
            // 
            this.txtSanteEleve.Location = new System.Drawing.Point(25, 235);
            this.txtSanteEleve.Name = "txtSanteEleve";
            this.txtSanteEleve.Size = new System.Drawing.Size(265, 20);
            this.txtSanteEleve.TabIndex = 20;
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
            // txtNomEleve
            // 
            this.txtNomEleve.Location = new System.Drawing.Point(25, 49);
            this.txtNomEleve.Name = "txtNomEleve";
            this.txtNomEleve.Size = new System.Drawing.Size(265, 20);
            this.txtNomEleve.TabIndex = 11;
            // 
            // lblPrenomEleve
            // 
            this.lblPrenomEleve.AutoSize = true;
            this.lblPrenomEleve.Location = new System.Drawing.Point(23, 76);
            this.lblPrenomEleve.Name = "lblPrenomEleve";
            this.lblPrenomEleve.Size = new System.Drawing.Size(43, 13);
            this.lblPrenomEleve.TabIndex = 6;
            this.lblPrenomEleve.Text = "Prénom";
            // 
            // txtPrenomEleve
            // 
            this.txtPrenomEleve.Location = new System.Drawing.Point(25, 92);
            this.txtPrenomEleve.Name = "txtPrenomEleve";
            this.txtPrenomEleve.Size = new System.Drawing.Size(265, 20);
            this.txtPrenomEleve.TabIndex = 8;
            // 
            // lblSanteEleve
            // 
            this.lblSanteEleve.AutoSize = true;
            this.lblSanteEleve.Location = new System.Drawing.Point(23, 218);
            this.lblSanteEleve.Name = "lblSanteEleve";
            this.lblSanteEleve.Size = new System.Drawing.Size(35, 13);
            this.lblSanteEleve.TabIndex = 12;
            this.lblSanteEleve.Text = "Santé";
            // 
            // lblClasseEleve
            // 
            this.lblClasseEleve.AutoSize = true;
            this.lblClasseEleve.Location = new System.Drawing.Point(23, 122);
            this.lblClasseEleve.Name = "lblClasseEleve";
            this.lblClasseEleve.Size = new System.Drawing.Size(38, 13);
            this.lblClasseEleve.TabIndex = 7;
            this.lblClasseEleve.Text = "Classe";
            // 
            // lblDateDeNaissance
            // 
            this.lblDateDeNaissance.AutoSize = true;
            this.lblDateDeNaissance.Location = new System.Drawing.Point(23, 170);
            this.lblDateDeNaissance.Name = "lblDateDeNaissance";
            this.lblDateDeNaissance.Size = new System.Drawing.Size(96, 13);
            this.lblDateDeNaissance.TabIndex = 10;
            this.lblDateDeNaissance.Text = "Date de naissance";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.dpdDiplome);
            this.panel2.Controls.Add(this.lblDiplomeEleve);
            this.panel2.Controls.Add(this.txtTiersTempsEleve);
            this.panel2.Controls.Add(this.lblCommentairesSanteEleve);
            this.panel2.Controls.Add(this.txtCommentairesSanteEleve);
            this.panel2.Controls.Add(this.txtTelephoneEleve);
            this.panel2.Controls.Add(this.tiersTempsEleve);
            this.panel2.Controls.Add(this.lblTelephoneEleve);
            this.panel2.Controls.Add(this.lblTelephoneParentEleve);
            this.panel2.Controls.Add(this.txtTelephoneParentEleve);
            this.panel2.Location = new System.Drawing.Point(380, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 255);
            this.panel2.TabIndex = 26;
            // 
            // txtTiersTempsEleve
            // 
            this.txtTiersTempsEleve.Location = new System.Drawing.Point(19, 138);
            this.txtTiersTempsEleve.Name = "txtTiersTempsEleve";
            this.txtTiersTempsEleve.Size = new System.Drawing.Size(259, 20);
            this.txtTiersTempsEleve.TabIndex = 22;
            // 
            // lblCommentairesSanteEleve
            // 
            this.lblCommentairesSanteEleve.AutoSize = true;
            this.lblCommentairesSanteEleve.Location = new System.Drawing.Point(17, 170);
            this.lblCommentairesSanteEleve.Name = "lblCommentairesSanteEleve";
            this.lblCommentairesSanteEleve.Size = new System.Drawing.Size(102, 13);
            this.lblCommentairesSanteEleve.TabIndex = 17;
            this.lblCommentairesSanteEleve.Text = "Commentaires santé";
            // 
            // txtCommentairesSanteEleve
            // 
            this.txtCommentairesSanteEleve.Location = new System.Drawing.Point(19, 186);
            this.txtCommentairesSanteEleve.Name = "txtCommentairesSanteEleve";
            this.txtCommentairesSanteEleve.Size = new System.Drawing.Size(259, 20);
            this.txtCommentairesSanteEleve.TabIndex = 21;
            // 
            // txtTelephoneEleve
            // 
            this.txtTelephoneEleve.Location = new System.Drawing.Point(19, 49);
            this.txtTelephoneEleve.Name = "txtTelephoneEleve";
            this.txtTelephoneEleve.Size = new System.Drawing.Size(259, 20);
            this.txtTelephoneEleve.TabIndex = 18;
            // 
            // tiersTempsEleve
            // 
            this.tiersTempsEleve.AutoSize = true;
            this.tiersTempsEleve.Location = new System.Drawing.Point(17, 122);
            this.tiersTempsEleve.Name = "tiersTempsEleve";
            this.tiersTempsEleve.Size = new System.Drawing.Size(61, 13);
            this.tiersTempsEleve.TabIndex = 16;
            this.tiersTempsEleve.Text = "Tiers temps";
            // 
            // lblTelephoneEleve
            // 
            this.lblTelephoneEleve.AutoSize = true;
            this.lblTelephoneEleve.Location = new System.Drawing.Point(17, 32);
            this.lblTelephoneEleve.Name = "lblTelephoneEleve";
            this.lblTelephoneEleve.Size = new System.Drawing.Size(87, 13);
            this.lblTelephoneEleve.TabIndex = 14;
            this.lblTelephoneEleve.Text = "Téléphone élève";
            // 
            // lblTelephoneParentEleve
            // 
            this.lblTelephoneParentEleve.AutoSize = true;
            this.lblTelephoneParentEleve.Location = new System.Drawing.Point(17, 76);
            this.lblTelephoneParentEleve.Name = "lblTelephoneParentEleve";
            this.lblTelephoneParentEleve.Size = new System.Drawing.Size(91, 13);
            this.lblTelephoneParentEleve.TabIndex = 15;
            this.lblTelephoneParentEleve.Text = "Téléphone parent";
            // 
            // txtTelephoneParentEleve
            // 
            this.txtTelephoneParentEleve.Location = new System.Drawing.Point(19, 92);
            this.txtTelephoneParentEleve.Name = "txtTelephoneParentEleve";
            this.txtTelephoneParentEleve.Size = new System.Drawing.Size(259, 20);
            this.txtTelephoneParentEleve.TabIndex = 5;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.Location = new System.Drawing.Point(596, 98);
            this.lblSuccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(176, 19);
            this.lblSuccess.TabIndex = 36;
            this.lblSuccess.Text = "L\'élève a bien été modifié";
            this.lblSuccess.Visible = false;
            // 
            // lblDiplomeEleve
            // 
            this.lblDiplomeEleve.AutoSize = true;
            this.lblDiplomeEleve.Location = new System.Drawing.Point(20, 213);
            this.lblDiplomeEleve.Name = "lblDiplomeEleve";
            this.lblDiplomeEleve.Size = new System.Drawing.Size(45, 13);
            this.lblDiplomeEleve.TabIndex = 23;
            this.lblDiplomeEleve.Text = "Diplôme";
            // 
            // dpdDiplome
            // 
            this.dpdDiplome.FormattingEnabled = true;
            this.dpdDiplome.Location = new System.Drawing.Point(19, 229);
            this.dpdDiplome.Name = "dpdDiplome";
            this.dpdDiplome.Size = new System.Drawing.Size(259, 21);
            this.dpdDiplome.TabIndex = 24;
            // 
            // FrmModificationEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.erreurChampsVides);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmModificationEleve";
            this.Text = "ModificationEleve";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtmDateDeNaissanceEleve;
        private System.Windows.Forms.ComboBox dpdClasse;
        private System.Windows.Forms.TextBox txtSanteEleve;
        private System.Windows.Forms.Label lblNomEleve;
        private System.Windows.Forms.TextBox txtNomEleve;
        private System.Windows.Forms.Label lblPrenomEleve;
        private System.Windows.Forms.TextBox txtPrenomEleve;
        private System.Windows.Forms.Label lblSanteEleve;
        private System.Windows.Forms.Label lblClasseEleve;
        private System.Windows.Forms.Label lblDateDeNaissance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTiersTempsEleve;
        private System.Windows.Forms.Label lblCommentairesSanteEleve;
        private System.Windows.Forms.TextBox txtCommentairesSanteEleve;
        private System.Windows.Forms.TextBox txtTelephoneEleve;
        private System.Windows.Forms.Label tiersTempsEleve;
        private System.Windows.Forms.Label lblTelephoneEleve;
        private System.Windows.Forms.Label lblTelephoneParentEleve;
        private System.Windows.Forms.TextBox txtTelephoneParentEleve;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label erreurChampsVides;
        private System.Windows.Forms.Label lblDiplomeEleve;
        private System.Windows.Forms.ComboBox dpdDiplome;
    }
}