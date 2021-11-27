
namespace UtilisateursGUI
{
    partial class FrmSuppressionMedicament
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
            this.bnbNonSuppressionMedicament = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bnbOuiSuppressionMedicament = new System.Windows.Forms.Button();
            this.lblSuppressionEleve = new System.Windows.Forms.Label();
            this.combotBoxSupprimer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "SUPPRESSION D\'UN MEDICAMENT";
            // 
            // bnbNonSuppressionMedicament
            // 
            this.bnbNonSuppressionMedicament.Location = new System.Drawing.Point(164, 230);
            this.bnbNonSuppressionMedicament.Name = "bnbNonSuppressionMedicament";
            this.bnbNonSuppressionMedicament.Size = new System.Drawing.Size(89, 22);
            this.bnbNonSuppressionMedicament.TabIndex = 34;
            this.bnbNonSuppressionMedicament.Text = "Non";
            this.bnbNonSuppressionMedicament.UseVisualStyleBackColor = true;
            this.bnbNonSuppressionMedicament.Click += new System.EventHandler(this.bnbNonSuppressionMedicament_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UtilisateursGUI.Properties.Resources.logoinfirmiere;
            this.pictureBox1.Location = new System.Drawing.Point(45, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // bnbOuiSuppressionMedicament
            // 
            this.bnbOuiSuppressionMedicament.Location = new System.Drawing.Point(45, 230);
            this.bnbOuiSuppressionMedicament.Name = "bnbOuiSuppressionMedicament";
            this.bnbOuiSuppressionMedicament.Size = new System.Drawing.Size(89, 22);
            this.bnbOuiSuppressionMedicament.TabIndex = 32;
            this.bnbOuiSuppressionMedicament.Text = "Oui";
            this.bnbOuiSuppressionMedicament.UseVisualStyleBackColor = true;
            this.bnbOuiSuppressionMedicament.Click += new System.EventHandler(this.bnbOuiSuppressionMedicament_Click);
            // 
            // lblSuppressionEleve
            // 
            this.lblSuppressionEleve.AutoSize = true;
            this.lblSuppressionEleve.Location = new System.Drawing.Point(43, 181);
            this.lblSuppressionEleve.Name = "lblSuppressionEleve";
            this.lblSuppressionEleve.Size = new System.Drawing.Size(197, 13);
            this.lblSuppressionEleve.TabIndex = 31;
            this.lblSuppressionEleve.Text = "Voulez-vous supprimer ce médicament ?";
            // 
            // combotBoxSupprimer
            // 
            this.combotBoxSupprimer.FormattingEnabled = true;
            this.combotBoxSupprimer.Location = new System.Drawing.Point(45, 203);
            this.combotBoxSupprimer.Name = "combotBoxSupprimer";
            this.combotBoxSupprimer.Size = new System.Drawing.Size(121, 21);
            this.combotBoxSupprimer.TabIndex = 36;
            // 
            // FrmSuppressionMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.combotBoxSupprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnbNonSuppressionMedicament);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bnbOuiSuppressionMedicament);
            this.Controls.Add(this.lblSuppressionEleve);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmSuppressionMedicament";
            this.Text = "FrmSuppressionMedicament";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnbNonSuppressionMedicament;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bnbOuiSuppressionMedicament;
        private System.Windows.Forms.Label lblSuppressionEleve;
        private System.Windows.Forms.ComboBox combotBoxSupprimer;
    }
}