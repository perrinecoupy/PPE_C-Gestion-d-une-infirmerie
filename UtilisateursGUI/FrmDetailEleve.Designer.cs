
namespace UtilisateursGUI
{
    partial class FrmDetailEleve
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
            this.components = new System.ComponentModel.Container();
            this.btnAjoutEleve = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDetailsEleve = new System.Windows.Forms.Label();
            this.dataGridViewEleve = new System.Windows.Forms.DataGridView();
            this.eLEVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_InfirmerieDataSet1 = new UtilisateursGUI.Gestion_InfirmerieDataSet1();
            this.gestion_InfirmerieDataSet = new UtilisateursGUI.Gestion_InfirmerieDataSet();
            this.gestionInfirmerieDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLEVETableAdapter = new UtilisateursGUI.Gestion_InfirmerieDataSet1TableAdapters.ELEVETableAdapter();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_InfirmerieDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_InfirmerieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionInfirmerieDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjoutEleve
            // 
            this.btnAjoutEleve.Location = new System.Drawing.Point(51, 137);
            this.btnAjoutEleve.Name = "btnAjoutEleve";
            this.btnAjoutEleve.Size = new System.Drawing.Size(138, 23);
            this.btnAjoutEleve.TabIndex = 25;
            this.btnAjoutEleve.Text = "Ajouter un nouveau élève";
            this.btnAjoutEleve.UseVisualStyleBackColor = true;
            this.btnAjoutEleve.Click += new System.EventHandler(this.btnAjoutEleve_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UtilisateursGUI.Properties.Resources.logoinfirmiere;
            this.pictureBox1.Location = new System.Drawing.Point(51, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblDetailsEleve
            // 
            this.lblDetailsEleve.AutoSize = true;
            this.lblDetailsEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsEleve.Location = new System.Drawing.Point(413, 73);
            this.lblDetailsEleve.Name = "lblDetailsEleve";
            this.lblDetailsEleve.Size = new System.Drawing.Size(235, 31);
            this.lblDetailsEleve.TabIndex = 28;
            this.lblDetailsEleve.Text = "Détails des élèves";
            // 
            // dataGridViewEleve
            // 
            this.dataGridViewEleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEleve.Location = new System.Drawing.Point(12, 166);
            this.dataGridViewEleve.Name = "dataGridViewEleve";
            this.dataGridViewEleve.Size = new System.Drawing.Size(1158, 150);
            this.dataGridViewEleve.TabIndex = 27;
            // 
            // eLEVEBindingSource
            // 
            this.eLEVEBindingSource.DataMember = "ELEVE";
            this.eLEVEBindingSource.DataSource = this.gestion_InfirmerieDataSet1;
            // 
            // gestion_InfirmerieDataSet1
            // 
            this.gestion_InfirmerieDataSet1.DataSetName = "Gestion_InfirmerieDataSet1";
            this.gestion_InfirmerieDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestion_InfirmerieDataSet
            // 
            this.gestion_InfirmerieDataSet.DataSetName = "Gestion_InfirmerieDataSet";
            this.gestion_InfirmerieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionInfirmerieDataSetBindingSource
            // 
            this.gestionInfirmerieDataSetBindingSource.DataSource = this.gestion_InfirmerieDataSet;
            this.gestionInfirmerieDataSetBindingSource.Position = 0;
            // 
            // eLEVETableAdapter
            // 
            this.eLEVETableAdapter.ClearBeforeFill = true;
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(483, 137);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(138, 23);
            this.btnRetour.TabIndex = 29;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(195, 137);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(138, 23);
            this.btnModifier.TabIndex = 30;
            this.btnModifier.Text = "Modifier un élève";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(339, 137);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(138, 23);
            this.btnSupprimer.TabIndex = 31;
            this.btnSupprimer.Text = "Supprimer un élève";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // FrmDetailEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 450);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblDetailsEleve);
            this.Controls.Add(this.dataGridViewEleve);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAjoutEleve);
            this.Name = "FrmDetailEleve";
            this.Text = "DetailEleve";
            this.Load += new System.EventHandler(this.FrmDetailEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_InfirmerieDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_InfirmerieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionInfirmerieDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAjoutEleve;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDetailsEleve;
        private System.Windows.Forms.DataGridView dataGridViewEleve;
        private Gestion_InfirmerieDataSet gestion_InfirmerieDataSet;
        private System.Windows.Forms.BindingSource gestionInfirmerieDataSetBindingSource;
        private Gestion_InfirmerieDataSet1 gestion_InfirmerieDataSet1;
        private System.Windows.Forms.BindingSource eLEVEBindingSource;
        private Gestion_InfirmerieDataSet1TableAdapters.ELEVETableAdapter eLEVETableAdapter;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
    }
}