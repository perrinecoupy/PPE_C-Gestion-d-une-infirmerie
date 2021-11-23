
namespace UtilisateursGUI
{
    partial class FrmConnexion
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
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txtMotdePasse = new System.Windows.Forms.TextBox();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.checkBoxSourvenirMoi = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.erreurIdentifiant = new System.Windows.Forms.Label();
            this.erreurMotDePasse = new System.Windows.Forms.Label();
            this.erreurIdentification = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UtilisateursGUI.Properties.Resources.logoinfirmiere;
            this.pictureBox1.Location = new System.Drawing.Point(11, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(40, 153);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.lblIdentifiant.TabIndex = 2;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(43, 183);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(441, 20);
            this.txtIdentifiant.TabIndex = 3;
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(40, 235);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(71, 13);
            this.lblMotDePasse.TabIndex = 4;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // txtMotdePasse
            // 
            this.txtMotdePasse.Location = new System.Drawing.Point(43, 264);
            this.txtMotdePasse.Name = "txtMotdePasse";
            this.txtMotdePasse.Size = new System.Drawing.Size(441, 20);
            this.txtMotdePasse.TabIndex = 5;
            this.txtMotdePasse.UseSystemPasswordChar = true;
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(200, 339);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(122, 44);
            this.btnEnvoyer.TabIndex = 6;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // checkBoxSourvenirMoi
            // 
            this.checkBoxSourvenirMoi.AutoSize = true;
            this.checkBoxSourvenirMoi.Location = new System.Drawing.Point(43, 310);
            this.checkBoxSourvenirMoi.Name = "checkBoxSourvenirMoi";
            this.checkBoxSourvenirMoi.Size = new System.Drawing.Size(116, 17);
            this.checkBoxSourvenirMoi.TabIndex = 7;
            this.checkBoxSourvenirMoi.Text = "Se souvenir de moi";
            this.checkBoxSourvenirMoi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "CONNEXION";
            // 
            // erreurIdentifiant
            // 
            this.erreurIdentifiant.AutoSize = true;
            this.erreurIdentifiant.BackColor = System.Drawing.Color.Transparent;
            this.erreurIdentifiant.ForeColor = System.Drawing.Color.Red;
            this.erreurIdentifiant.Location = new System.Drawing.Point(40, 206);
            this.erreurIdentifiant.Name = "erreurIdentifiant";
            this.erreurIdentifiant.Size = new System.Drawing.Size(144, 13);
            this.erreurIdentifiant.TabIndex = 25;
            this.erreurIdentifiant.Text = "Veuillez saisir votre identifiant";
            this.erreurIdentifiant.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.erreurIdentifiant.Visible = false;
            // 
            // erreurMotDePasse
            // 
            this.erreurMotDePasse.AutoSize = true;
            this.erreurMotDePasse.BackColor = System.Drawing.Color.Transparent;
            this.erreurMotDePasse.ForeColor = System.Drawing.Color.Red;
            this.erreurMotDePasse.Location = new System.Drawing.Point(40, 287);
            this.erreurMotDePasse.Name = "erreurMotDePasse";
            this.erreurMotDePasse.Size = new System.Drawing.Size(162, 13);
            this.erreurMotDePasse.TabIndex = 26;
            this.erreurMotDePasse.Text = "Veuillez saisir votre mot de passe";
            this.erreurMotDePasse.Visible = false;
            // 
            // erreurIdentification
            // 
            this.erreurIdentification.AutoSize = true;
            this.erreurIdentification.BackColor = System.Drawing.Color.Transparent;
            this.erreurIdentification.ForeColor = System.Drawing.Color.Red;
            this.erreurIdentification.Location = new System.Drawing.Point(275, 314);
            this.erreurIdentification.Name = "erreurIdentification";
            this.erreurIdentification.Size = new System.Drawing.Size(209, 13);
            this.erreurIdentification.TabIndex = 27;
            this.erreurIdentification.Text = "Nom d\'utilisateur ou mot de passe incorrect\r\n";
            this.erreurIdentification.Visible = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(200, 394);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(122, 44);
            this.btnQuitter.TabIndex = 28;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.erreurIdentification);
            this.Controls.Add(this.erreurMotDePasse);
            this.Controls.Add(this.erreurIdentifiant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxSourvenirMoi);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.txtMotdePasse);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmConnexion";
            this.Text = "FrmConnexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtMotdePasse;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.CheckBox checkBoxSourvenirMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label erreurIdentifiant;
        private System.Windows.Forms.Label erreurMotDePasse;
        private System.Windows.Forms.Label erreurIdentification;
        private System.Windows.Forms.Button btnQuitter;
    }
}