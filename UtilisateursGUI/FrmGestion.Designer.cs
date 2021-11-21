
namespace UtilisateursGUI
{
    partial class FrmGestion
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
            this.btnGestionEleve = new System.Windows.Forms.Button();
            this.btnGestionVisite = new System.Windows.Forms.Button();
            this.btnGestionMedicament = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionEleve
            // 
            this.btnGestionEleve.Location = new System.Drawing.Point(155, 178);
            this.btnGestionEleve.Name = "btnGestionEleve";
            this.btnGestionEleve.Size = new System.Drawing.Size(129, 50);
            this.btnGestionEleve.TabIndex = 0;
            this.btnGestionEleve.Text = "Gestion des élèves";
            this.btnGestionEleve.UseVisualStyleBackColor = true;
            this.btnGestionEleve.Click += new System.EventHandler(this.btnGestionEleve_Click);
            // 
            // btnGestionVisite
            // 
            this.btnGestionVisite.Location = new System.Drawing.Point(321, 178);
            this.btnGestionVisite.Name = "btnGestionVisite";
            this.btnGestionVisite.Size = new System.Drawing.Size(129, 50);
            this.btnGestionVisite.TabIndex = 1;
            this.btnGestionVisite.Text = "Gestion des visites";
            this.btnGestionVisite.UseVisualStyleBackColor = true;
            // 
            // btnGestionMedicament
            // 
            this.btnGestionMedicament.Location = new System.Drawing.Point(486, 178);
            this.btnGestionMedicament.Name = "btnGestionMedicament";
            this.btnGestionMedicament.Size = new System.Drawing.Size(139, 50);
            this.btnGestionMedicament.TabIndex = 2;
            this.btnGestionMedicament.Text = "Gestion des médicaments";
            this.btnGestionMedicament.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(321, 285);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(129, 50);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnGestionMedicament);
            this.Controls.Add(this.btnGestionVisite);
            this.Controls.Add(this.btnGestionEleve);
            this.Name = "FrmGestion";
            this.Text = "FrmGestion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionEleve;
        private System.Windows.Forms.Button btnGestionVisite;
        private System.Windows.Forms.Button btnGestionMedicament;
        private System.Windows.Forms.Button btnQuitter;
    }
}