
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
            this.nomeleveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomeleveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedenaissanceeleveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.santeeleveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerotelephoneeleveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerotelephoneparenteleveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tierstempseleveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentairessantelibreeleveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclasseeleveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eLEVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestion_InfirmerieDataSet1 = new UtilisateursGUI.Gestion_InfirmerieDataSet1();
            this.gestion_InfirmerieDataSet = new UtilisateursGUI.Gestion_InfirmerieDataSet();
            this.gestionInfirmerieDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eLEVETableAdapter = new UtilisateursGUI.Gestion_InfirmerieDataSet1TableAdapters.ELEVETableAdapter();
            this.btnRetour = new System.Windows.Forms.Button();
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
            this.dataGridViewEleve.AutoGenerateColumns = false;
            this.dataGridViewEleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEleve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeleveDataGridViewTextBoxColumn,
            this.prenomeleveDataGridViewTextBoxColumn,
            this.datedenaissanceeleveDataGridViewTextBoxColumn,
            this.santeeleveDataGridViewTextBoxColumn,
            this.numerotelephoneeleveDataGridViewTextBoxColumn,
            this.numerotelephoneparenteleveDataGridViewTextBoxColumn,
            this.tierstempseleveDataGridViewTextBoxColumn,
            this.commentairessantelibreeleveDataGridViewTextBoxColumn,
            this.idclasseeleveDataGridViewTextBoxColumn,
            this.btnModifier,
            this.btnSupprimer});
            this.dataGridViewEleve.DataSource = this.eLEVEBindingSource;
            this.dataGridViewEleve.Location = new System.Drawing.Point(12, 166);
            this.dataGridViewEleve.Name = "dataGridViewEleve";
            this.dataGridViewEleve.Size = new System.Drawing.Size(1158, 150);
            this.dataGridViewEleve.TabIndex = 27;
            this.dataGridViewEleve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEleve_CellContentClick);
            // 
            // nomeleveDataGridViewTextBoxColumn
            // 
            this.nomeleveDataGridViewTextBoxColumn.DataPropertyName = "nom_eleve";
            this.nomeleveDataGridViewTextBoxColumn.HeaderText = "NOM";
            this.nomeleveDataGridViewTextBoxColumn.Name = "nomeleveDataGridViewTextBoxColumn";
            // 
            // prenomeleveDataGridViewTextBoxColumn
            // 
            this.prenomeleveDataGridViewTextBoxColumn.DataPropertyName = "prenom_eleve";
            this.prenomeleveDataGridViewTextBoxColumn.HeaderText = "PRENOM";
            this.prenomeleveDataGridViewTextBoxColumn.Name = "prenomeleveDataGridViewTextBoxColumn";
            // 
            // datedenaissanceeleveDataGridViewTextBoxColumn
            // 
            this.datedenaissanceeleveDataGridViewTextBoxColumn.DataPropertyName = "date_de_naissance_eleve";
            this.datedenaissanceeleveDataGridViewTextBoxColumn.HeaderText = "DATE DE NAISSANCE";
            this.datedenaissanceeleveDataGridViewTextBoxColumn.Name = "datedenaissanceeleveDataGridViewTextBoxColumn";
            // 
            // santeeleveDataGridViewTextBoxColumn
            // 
            this.santeeleveDataGridViewTextBoxColumn.DataPropertyName = "sante_eleve";
            this.santeeleveDataGridViewTextBoxColumn.HeaderText = "SANTE";
            this.santeeleveDataGridViewTextBoxColumn.Name = "santeeleveDataGridViewTextBoxColumn";
            // 
            // numerotelephoneeleveDataGridViewTextBoxColumn
            // 
            this.numerotelephoneeleveDataGridViewTextBoxColumn.DataPropertyName = "numero_telephone_eleve";
            this.numerotelephoneeleveDataGridViewTextBoxColumn.HeaderText = "N° TEL ELEVE";
            this.numerotelephoneeleveDataGridViewTextBoxColumn.Name = "numerotelephoneeleveDataGridViewTextBoxColumn";
            // 
            // numerotelephoneparenteleveDataGridViewTextBoxColumn
            // 
            this.numerotelephoneparenteleveDataGridViewTextBoxColumn.DataPropertyName = "numero_telephone_parent_eleve";
            this.numerotelephoneparenteleveDataGridViewTextBoxColumn.HeaderText = "N° TEL PARENT ELEVE";
            this.numerotelephoneparenteleveDataGridViewTextBoxColumn.Name = "numerotelephoneparenteleveDataGridViewTextBoxColumn";
            // 
            // tierstempseleveDataGridViewTextBoxColumn
            // 
            this.tierstempseleveDataGridViewTextBoxColumn.DataPropertyName = "tiers_temps_eleve";
            this.tierstempseleveDataGridViewTextBoxColumn.HeaderText = "TIERS TEMPS";
            this.tierstempseleveDataGridViewTextBoxColumn.Name = "tierstempseleveDataGridViewTextBoxColumn";
            // 
            // commentairessantelibreeleveDataGridViewTextBoxColumn
            // 
            this.commentairessantelibreeleveDataGridViewTextBoxColumn.DataPropertyName = "commentaires_sante_libre_eleve";
            this.commentairessantelibreeleveDataGridViewTextBoxColumn.HeaderText = "COMMENTAIRE SANTE";
            this.commentairessantelibreeleveDataGridViewTextBoxColumn.Name = "commentairessantelibreeleveDataGridViewTextBoxColumn";
            // 
            // idclasseeleveDataGridViewTextBoxColumn
            // 
            this.idclasseeleveDataGridViewTextBoxColumn.DataPropertyName = "id_classe_eleve";
            this.idclasseeleveDataGridViewTextBoxColumn.HeaderText = "CLASSE ELEVE";
            this.idclasseeleveDataGridViewTextBoxColumn.Name = "idclasseeleveDataGridViewTextBoxColumn";
            // 
            // btnModifier
            // 
            this.btnModifier.HeaderText = "MODIFIER";
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Text = "MODIFIER";
            this.btnModifier.UseColumnTextForButtonValue = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.HeaderText = "SUPPRIMER";
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Text = "SUPPRIMER";
            this.btnSupprimer.UseColumnTextForButtonValue = true;
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
            this.btnRetour.Location = new System.Drawing.Point(195, 137);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(138, 23);
            this.btnRetour.TabIndex = 29;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FrmDetailEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 450);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeleveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomeleveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedenaissanceeleveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn santeeleveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerotelephoneeleveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerotelephoneparenteleveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tierstempseleveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentairessantelibreeleveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclasseeleveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnModifier;
        private System.Windows.Forms.DataGridViewButtonColumn btnSupprimer;
    }
}