
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
            this.pictureBox1.Location = new System.Drawing.Point(16, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(60, 235);
            this.lblIdentifiant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(80, 20);
            this.lblIdentifiant.TabIndex = 2;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(64, 282);
            this.txtIdentifiant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(660, 26);
            this.txtIdentifiant.TabIndex = 3;
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(60, 362);
            this.lblMotDePasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(105, 20);
            this.lblMotDePasse.TabIndex = 4;
            this.lblMotDePasse.Text = "Mot de passe";
            // 
            // txtMotdePasse
            // 
            this.txtMotdePasse.Location = new System.Drawing.Point(64, 406);
            this.txtMotdePasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMotdePasse.Name = "txtMotdePasse";
            this.txtMotdePasse.Size = new System.Drawing.Size(660, 26);
            this.txtMotdePasse.TabIndex = 5;
            this.txtMotdePasse.UseSystemPasswordChar = true;
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(135, 512);
            this.btnEnvoyer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(183, 68);
            this.btnEnvoyer.TabIndex = 6;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // checkBoxSourvenirMoi
            // 
            this.checkBoxSourvenirMoi.AutoSize = true;
            this.checkBoxSourvenirMoi.Location = new System.Drawing.Point(64, 477);
            this.checkBoxSourvenirMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSourvenirMoi.Name = "checkBoxSourvenirMoi";
            this.checkBoxSourvenirMoi.Size = new System.Drawing.Size(169, 24);
            this.checkBoxSourvenirMoi.TabIndex = 7;
            this.checkBoxSourvenirMoi.Text = "Se souvenir de moi";
            this.checkBoxSourvenirMoi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 46);
            this.label1.TabIndex = 24;
            this.label1.Text = "CONNEXION";
            // 
            // erreurIdentifiant
            // 
            this.erreurIdentifiant.AutoSize = true;
            this.erreurIdentifiant.BackColor = System.Drawing.Color.Transparent;
            this.erreurIdentifiant.ForeColor = System.Drawing.Color.Red;
            this.erreurIdentifiant.Location = new System.Drawing.Point(60, 317);
            this.erreurIdentifiant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.erreurIdentifiant.Name = "erreurIdentifiant";
            this.erreurIdentifiant.Size = new System.Drawing.Size(216, 20);
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
            this.erreurMotDePasse.Location = new System.Drawing.Point(60, 442);
            this.erreurMotDePasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.erreurMotDePasse.Name = "erreurMotDePasse";
            this.erreurMotDePasse.Size = new System.Drawing.Size(243, 20);
            this.erreurMotDePasse.TabIndex = 26;
            this.erreurMotDePasse.Text = "Veuillez saisir votre mot de passe";
            this.erreurMotDePasse.Visible = false;
            // 
            // erreurIdentification
            // 
            this.erreurIdentification.AutoSize = true;
            this.erreurIdentification.BackColor = System.Drawing.Color.Transparent;
            this.erreurIdentification.ForeColor = System.Drawing.Color.Red;
            this.erreurIdentification.Location = new System.Drawing.Point(412, 483);
            this.erreurIdentification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.erreurIdentification.Name = "erreurIdentification";
            this.erreurIdentification.Size = new System.Drawing.Size(313, 20);
            this.erreurIdentification.TabIndex = 27;
            this.erreurIdentification.Text = "Nom d\'utilisateur ou mot de passe incorrect\r\n";
            this.erreurIdentification.Visible = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(460, 512);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(183, 68);
            this.btnQuitter.TabIndex = 28;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(828, 692);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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