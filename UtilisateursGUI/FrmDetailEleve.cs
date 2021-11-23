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

            /*// Blocage de la génération automatique des colonnes
            dataGridViewEleve.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn colonneNom = new DataGridViewTextBoxColumn();
            colonneNom.DataPropertyName = "NOM";
            colonneNom.HeaderText = "NOM";

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn colonnePrenom = new DataGridViewTextBoxColumn();
            colonnePrenom.DataPropertyName = "PRENOM";
            colonnePrenom.HeaderText = "PRENOM";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn colonneClasse = new DataGridViewTextBoxColumn();
            colonneClasse.DataPropertyName = "CLASSE";
            colonneClasse.HeaderText = "CLASSE";

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn colonneDateDeNaissance = new DataGridViewTextBoxColumn();
            colonneDateDeNaissance.DataPropertyName = "DATE DE NAISSANCE";
            colonneDateDeNaissance.HeaderText = "DATE DE NAISSANCE";

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn colonneSante = new DataGridViewTextBoxColumn();
            colonneSante.DataPropertyName = "SANTE";
            colonneSante.HeaderText = "SANTE";

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn colonneNumTelEleve = new DataGridViewTextBoxColumn();
            colonneNumTelEleve.DataPropertyName = "N° TEL ELEVE";
            colonneNumTelEleve.HeaderText = "N° TEL ELEVE";

            // Création d'une en-tête de colonne pour la colonne 7
            DataGridViewTextBoxColumn colonneNumTelParentEleve = new DataGridViewTextBoxColumn();
            colonneNumTelParentEleve.DataPropertyName = "N° TEL PARENT ELEVE";
            colonneNumTelParentEleve.HeaderText = "N° TEL PARENT ELEVE";

            // Création d'une en-tête de colonne pour la colonne 8
            DataGridViewTextBoxColumn colonneModifier = new DataGridViewTextBoxColumn();
            colonneModifier.DataPropertyName = "MODIFIER";
            colonneModifier.HeaderText = "MODIFIER";

            // Création d'une en-tête de colonne pour la colonne 9
            DataGridViewTextBoxColumn colonneSupprimer = new DataGridViewTextBoxColumn();
            colonneSupprimer.DataPropertyName = "SUPPRIMER";
            colonneSupprimer.HeaderText = "SUPPRIMER";

            // Ajout des 9 en-têtes de colonne au datagridview
            dataGridViewEleve.Columns.Add(colonneNom);
            dataGridViewEleve.Columns.Add(colonnePrenom);
            dataGridViewEleve.Columns.Add(colonneClasse);
            dataGridViewEleve.Columns.Add(colonneDateDeNaissance);
            dataGridViewEleve.Columns.Add(colonneSante);
            dataGridViewEleve.Columns.Add(colonneNumTelEleve);
            dataGridViewEleve.Columns.Add(colonneNumTelParentEleve);
            dataGridViewEleve.Columns.Add(colonneModifier);
            dataGridViewEleve.Columns.Add(colonneSupprimer);

            // Définition du style apporté au datagridview
            dataGridViewEleve.ColumnHeadersVisible = false;
            colonneNom.Width = 140;
            colonnePrenom.Width = 140;
            colonneClasse.Width = 140;
            colonneDateDeNaissance.Width = 140;
            colonneSante.Width = 140;
            colonneNumTelEleve.Width = 140;
            colonneNumTelParentEleve.Width = 140;
            colonneModifier.Width = 140;
            colonneSupprimer.Width = 140;

            var lesEleves = new List<Eleve>();

            lesEleves = Gestion.GetEleves();

            dataGridViewEleve.DataSource = lesEleves;*/
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
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmGestion choixAdmin = new FrmGestion();
            choixAdmin.Show();

            this.Hide();
        }

        private void dataGridViewEleve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                FrmModificationEleve frmModificationEleve = new FrmModificationEleve();
                frmModificationEleve.ShowDialog();

                this.Close();
            }

            var senderGrid2 = (DataGridView)sender;

            if (senderGrid2.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                FrmSuppressionEleve frmSuppressionEleve = new FrmSuppressionEleve();
                frmSuppressionEleve.ShowDialog();

                this.Close();
            }
        }
    }
}
