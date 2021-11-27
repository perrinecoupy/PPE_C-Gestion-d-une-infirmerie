
namespace UtilisateursGUI
{
    partial class FrmConfirmationModificationMedicament
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
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.cmbConfirmation = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmation.Location = new System.Drawing.Point(156, 75);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(463, 25);
            this.lblConfirmation.TabIndex = 2;
            this.lblConfirmation.Text = "Veuillez sélectionner un médicament à modifier";
            // 
            // cmbConfirmation
            // 
            this.cmbConfirmation.FormattingEnabled = true;
            this.cmbConfirmation.Location = new System.Drawing.Point(324, 154);
            this.cmbConfirmation.Name = "cmbConfirmation";
            this.cmbConfirmation.Size = new System.Drawing.Size(121, 21);
            this.cmbConfirmation.TabIndex = 3;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(343, 221);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(343, 271);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FrmConfirmationModificationMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.cmbConfirmation);
            this.Controls.Add(this.lblConfirmation);
            this.Name = "FrmConfirmationModificationMedicament";
            this.Text = "FrmConfirmationModificationMedicament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.ComboBox cmbConfirmation;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnRetour;
    }
}