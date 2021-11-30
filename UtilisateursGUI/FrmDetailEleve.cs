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
            colonneNom.HeaderText = "NOM";
            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn colonnePrenom = new DataGridViewTextBoxColumn();
            colonnePrenom.DataPropertyName = "prenom";
            colonnePrenom.HeaderText = "PRENOM";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn colonneDateNaissace = new DataGridViewTextBoxColumn();
            colonneDateNaissace.DataPropertyName = "dateNaissance";
            colonneDateNaissace.HeaderText = "DATE DE NAISSANCE";

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn colonneSante = new DataGridViewTextBoxColumn();
            colonneSante.DataPropertyName = "sante";
            colonneSante.HeaderText = "SANTE";

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn colonneNumTelEleve = new DataGridViewTextBoxColumn();
            colonneNumTelEleve.DataPropertyName = "numTelEleve";
            colonneNumTelEleve.HeaderText = "N° TEL ELEVE";

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn colonneNumTelParentEleve = new DataGridViewTextBoxColumn();
            colonneNumTelParentEleve.DataPropertyName = "numTelParent";
            colonneNumTelParentEleve.HeaderText = "N° TEL PARENT";

            // Création d'une en-tête de colonne pour la colonne 7
            DataGridViewTextBoxColumn colonneTiersTemps = new DataGridViewTextBoxColumn();
            colonneTiersTemps.DataPropertyName = "tiersTemps";
            colonneTiersTemps.HeaderText = "TIERS TEMPS";

            // Création d'une en-tête de colonne pour la colonne 8
            DataGridViewTextBoxColumn colonneCommentaire = new DataGridViewTextBoxColumn();
            colonneCommentaire.DataPropertyName = "commentaire";
            colonneCommentaire.HeaderText = "COMMENTAIRES SANTE";

            // Création d'une en-tête de colonne pour la colonne 9
            DataGridViewTextBoxColumn colonneClasse = new DataGridViewTextBoxColumn();
            colonneClasse.DataPropertyName = "classe";
            colonneClasse.HeaderText = "CLASSE";

            // Ajout des 9 en-têtes de colonne au datagridview
            dataGridViewEleve.Columns.Add(colonneNom);
            dataGridViewEleve.Columns.Add(colonnePrenom);
            dataGridViewEleve.Columns.Add(colonneDateNaissace);
            dataGridViewEleve.Columns.Add(colonneNumTelEleve);
            dataGridViewEleve.Columns.Add(colonneNumTelParentEleve);
            dataGridViewEleve.Columns.Add(colonneTiersTemps);
            dataGridViewEleve.Columns.Add(colonneCommentaire);
            dataGridViewEleve.Columns.Add(colonneClasse);

            // Définition du style apporté au datagridview
            dataGridViewEleve.ColumnHeadersVisible = true;
            colonneNom.Width = 140;
            colonnePrenom.Width = 140;
            colonneDateNaissace.Width = 140;
            colonneNumTelEleve.Width = 140;
            colonneNumTelParentEleve.Width = 140;
            colonneTiersTemps.Width = 140;
            colonneCommentaire.Width = 140;
            colonneClasse.Width = 140;

            var lesEleves = new List<Eleve>();

            lesEleves = Gestion.GetEleves();

            dataGridViewEleve.DataSource = lesEleves;
        }

        private void btnAjoutEleve_Click(object sender, EventArgs e)
        {
            lblAjoutEleve frmAjoutEleve = new lblAjoutEleve();
            this.Hide();
            frmAjoutEleve.ShowDialog();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmGestion choixAdmin = new FrmGestion();
            this.Hide();
            choixAdmin.ShowDialog();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            FrmConfirmationModificationEleve FrmConfirmation;
            FrmConfirmation = new FrmConfirmationModificationEleve();
            FrmConfirmation.Hide();
            FrmConfirmation.ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            FrmSuppressionEleve FrmSupprimerEleve;
            FrmSupprimerEleve = new FrmSuppressionEleve();
            FrmSupprimerEleve.Hide();
            FrmSupprimerEleve.ShowDialog();
        }
    }
}
