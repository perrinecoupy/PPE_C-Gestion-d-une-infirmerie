using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilisateursBLL;
using UtilisateursBO;

namespace UtilisateursGUI
{
    public partial class FrmDetailEleve : Form
    {
        public FrmDetailEleve()
        {
            InitializeComponent();

            // Blocage de la génération automatique des colonnes
            dataGridViewEleve.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn colonneNom = new DataGridViewTextBoxColumn();
            colonneNom.DataPropertyName = "nom";
            colonneNom.HeaderText = "nom";
            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn colonnePrenom = new DataGridViewTextBoxColumn();
            colonnePrenom.DataPropertyName = "prenom";
            colonnePrenom.HeaderText = "prenom";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn colonneDateNaissace = new DataGridViewTextBoxColumn();
            colonneDateNaissace.DataPropertyName = "dateNaissance";
            colonneDateNaissace.HeaderText = "dateNaissance";

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn colonneSante = new DataGridViewTextBoxColumn();
            colonneSante.DataPropertyName = "sante";
            colonneSante.HeaderText = "sante";

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn colonneNumTelEleve = new DataGridViewTextBoxColumn();
            colonneNumTelEleve.DataPropertyName = "numTelEleve";
            colonneNumTelEleve.HeaderText = "numTelEleve";

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn colonneNumTelParentEleve = new DataGridViewTextBoxColumn();
            colonneNumTelParentEleve.DataPropertyName = "numTelParent";
            colonneNumTelParentEleve.HeaderText = "numTelParent";

            // Création d'une en-tête de colonne pour la colonne 7
            DataGridViewTextBoxColumn colonneTiersTemps = new DataGridViewTextBoxColumn();
            colonneTiersTemps.DataPropertyName = "tiersTemps";
            colonneTiersTemps.HeaderText = "tiersTemps";

            // Création d'une en-tête de colonne pour la colonne 8
            DataGridViewTextBoxColumn colonneCommentaire = new DataGridViewTextBoxColumn();
            colonneCommentaire.DataPropertyName = "commentaire";
            colonneCommentaire.HeaderText = "commentaire";

            // Création d'une en-tête de colonne pour la colonne 9
            DataGridViewTextBoxColumn colonneClasse = new DataGridViewTextBoxColumn();
            colonneClasse.DataPropertyName = "classe";
            colonneClasse.HeaderText = "classe";

            // Création d'une en-tête de colonne pour la colonne 10
            DataGridViewTextBoxColumn colonneModifier = new DataGridViewTextBoxColumn();
            colonneModifier.DataPropertyName = "MODIFIER";
            colonneModifier.HeaderText = "MODIFIER";

            // Création d'une en-tête de colonne pour la colonne 11
            DataGridViewTextBoxColumn colonneSupprimer = new DataGridViewTextBoxColumn();
            colonneSupprimer.DataPropertyName = "SUPPRIMER";
            colonneSupprimer.HeaderText = "SUPPRIMER";

            // Ajout des 9 en-têtes de colonne au datagridview
            dataGridViewEleve.Columns.Add(colonneNom);
            dataGridViewEleve.Columns.Add(colonnePrenom);
            dataGridViewEleve.Columns.Add(colonneDateNaissace);
            dataGridViewEleve.Columns.Add(colonneNumTelEleve);
            dataGridViewEleve.Columns.Add(colonneNumTelParentEleve);
            dataGridViewEleve.Columns.Add(colonneTiersTemps);
            dataGridViewEleve.Columns.Add(colonneCommentaire);
            dataGridViewEleve.Columns.Add(colonneClasse);
            dataGridViewEleve.Columns.Add(colonneModifier);
            dataGridViewEleve.Columns.Add(colonneSupprimer);

            // Définition du style apporté au datagridview
            dataGridViewEleve.ColumnHeadersVisible = false;
            colonneNom.Width = 140;
            colonnePrenom.Width = 140;
            colonneDateNaissace.Width = 140;
            colonneNumTelEleve.Width = 140;
            colonneNumTelParentEleve.Width = 140;
            colonneTiersTemps.Width = 140;
            colonneCommentaire.Width = 140;
            colonneClasse.Width = 140;
            colonneModifier.Width = 140;
            colonneSupprimer.Width = 140;

            var lesEleves = new List<Eleve>();

            lesEleves = Gestion.GetEleves();

            dataGridViewEleve.DataSource = lesEleves;
        }

        private void FrmDetailEleve_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_InfirmerieDataSet1.ELEVE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.eLEVETableAdapter.Fill(this.gestion_InfirmerieDataSet1.ELEVE);

        }

        private void btnAjoutEleve_Click(object sender, EventArgs e)
        {
            lblAjoutEleve frmAjoutEleve = new lblAjoutEleve();
            frmAjoutEleve.ShowDialog();

            this.Hide();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmGestion choixAdmin = new FrmGestion();
            choixAdmin.Show();

            this.Hide();
        }
    }
}
