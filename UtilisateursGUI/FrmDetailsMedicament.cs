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
    public partial class FrmDetailsMedicament : Form
    {
        public FrmDetailsMedicament()
        {
            InitializeComponent();

            // Blocage de la génération automatique des colonnes
            dataGridViewMedicament.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn colonneNom = new DataGridViewTextBoxColumn();
            colonneNom.DataPropertyName = "nom";
            colonneNom.HeaderText = "NOM";

            // Ajout de l'en-tête de colonne au datagridview
            dataGridViewMedicament.Columns.Add(colonneNom);

            // Définition du style apporté au datagridview
            dataGridViewMedicament.ColumnHeadersVisible = true;
            colonneNom.Width = 140;

            var lesMedicaments = new List<Medicament>();

            lesMedicaments = Gestion.GetMedicaments();

            dataGridViewMedicament.DataSource = lesMedicaments;
        }

        private void btnAjoutMedicament_Click(object sender, EventArgs e)
        {
            FrmAjoutMedicament frmAjoutMedicament = new FrmAjoutMedicament();
            this.Hide();
            frmAjoutMedicament.ShowDialog();
        }

        private void btnModifierMedicament_Click(object sender, EventArgs e)
        {
            FrmConfirmationModificationMedicament FrmConfirmation;
            FrmConfirmation = new FrmConfirmationModificationMedicament();
            FrmConfirmation.ShowDialog();
            FrmConfirmation.Close();
        }

        private void btnSupprimerMedicament_Click(object sender, EventArgs e)
        {
            FrmSuppressionMedicament FrmSupprimerMedicament;
            FrmSupprimerMedicament = new FrmSuppressionMedicament();
            FrmSupprimerMedicament.ShowDialog();
            FrmSupprimerMedicament.Close();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmGestion choixAdmin = new FrmGestion();
            this.Hide();
            choixAdmin.Show();
        }
    }
}
