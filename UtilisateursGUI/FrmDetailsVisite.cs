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
    public partial class FrmDetailsVisite : Form
    {
        public FrmDetailsVisite()
        {
            InitializeComponent();

            // Blocage de la génération automatique des colonnes
            dataGridViewVisite.AutoGenerateColumns = false;

            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn colonneNom = new DataGridViewTextBoxColumn();
            colonneNom.DataPropertyName = "Eleve";
            colonneNom.HeaderText = "NOM";

            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn colonneDate = new DataGridViewTextBoxColumn();
            colonneDate.DataPropertyName = "date";
            colonneDate.HeaderText = "DATE";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn colonneHeureArrivee = new DataGridViewTextBoxColumn();
            colonneHeureArrivee.DataPropertyName = "heureArrive";
            colonneHeureArrivee.HeaderText = "HEURE D'ARRIVE";

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn colonneHeureDepart = new DataGridViewTextBoxColumn();
            colonneHeureDepart.DataPropertyName = "heureDepart";
            colonneHeureDepart.HeaderText = "HEURE DE DEPART";

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn colonneMotif = new DataGridViewTextBoxColumn();
            colonneMotif.DataPropertyName = "motif";
            colonneMotif.HeaderText = "MOTIF";

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn colonneCommentaires = new DataGridViewTextBoxColumn();
            colonneCommentaires.DataPropertyName = "commentaires";
            colonneCommentaires.HeaderText = "COMMENTAIRES";

            // Création d'une en-tête de colonne pour la colonne 7
            DataGridViewTextBoxColumn colonnePrescription = new DataGridViewTextBoxColumn();
            colonnePrescription.DataPropertyName = "prescription";
            colonnePrescription.HeaderText = "PRESCRIPTION";

            // Création d'une en-tête de colonne pour la colonne 8
            DataGridViewTextBoxColumn colonneQuantite = new DataGridViewTextBoxColumn();
            colonneQuantite.DataPropertyName = "quantite";
            colonneQuantite.HeaderText = "QUANTITE";

            // Création d'une en-tête de colonne pour la colonne 9
            DataGridViewTextBoxColumn colonneStatut = new DataGridViewTextBoxColumn();
            colonneStatut.DataPropertyName = "statut";
            colonneStatut.HeaderText = "STATUT";

            // Création d'une en-tête de colonne pour la colonne 10
            DataGridViewTextBoxColumn colonnePrevention = new DataGridViewTextBoxColumn();
            colonnePrevention.DataPropertyName = "prevention";
            colonnePrevention.HeaderText = "PREVENTION";

            // Création d'une en-tête de colonne pour la colonne 11
            DataGridViewTextBoxColumn colonneIdEleve = new DataGridViewTextBoxColumn();
            colonneIdEleve.DataPropertyName = "id_eleve";
            colonneIdEleve.HeaderText = "ID ELEVE";

            // Ajout des 9 en-têtes de colonne au datagridview
            dataGridViewVisite.Columns.Add(colonneNom);
            dataGridViewVisite.Columns.Add(colonneDate);
            dataGridViewVisite.Columns.Add(colonneHeureArrivee);
            dataGridViewVisite.Columns.Add(colonneHeureDepart);
            dataGridViewVisite.Columns.Add(colonneMotif);
            dataGridViewVisite.Columns.Add(colonneCommentaires);
            dataGridViewVisite.Columns.Add(colonnePrescription);
            dataGridViewVisite.Columns.Add(colonneQuantite);
            dataGridViewVisite.Columns.Add(colonneStatut);
            dataGridViewVisite.Columns.Add(colonnePrevention);
            dataGridViewVisite.Columns.Add(colonneIdEleve);

            // Définition du style apporté au datagridview
            dataGridViewVisite.ColumnHeadersVisible = true;
            colonneNom.Width = 140;
            colonneDate.Width = 140;
            colonneHeureArrivee.Width = 140;
            colonneHeureDepart.Width = 140;
            colonneMotif.Width = 140;
            colonneCommentaires.Width = 140;
            colonnePrescription.Width = 140;
            colonneQuantite.Width = 140;
            colonneStatut.Width = 140;
            colonnePrevention.Width = 140;
            colonneIdEleve.Width = 140;

            var lesVisites = new List<Visite>();

            lesVisites = Gestion.GetVisites();

            dataGridViewVisite.DataSource = lesVisites;
        }

        private void btnAjoutVisite_Click(object sender, EventArgs e)
        {
            FrmAjoutVisite frmAjoutVisite = new FrmAjoutVisite();
            this.Hide();
            frmAjoutVisite.ShowDialog();
        }

        private void btnModifierVisite_Click(object sender, EventArgs e)
        {
            FrmConfirmationModificationVisite FrmConfirmation;
            FrmConfirmation = new FrmConfirmationModificationVisite();
            FrmConfirmation.Hide();
            FrmConfirmation.ShowDialog();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmGestion frmGestion = new FrmGestion();
            this.Hide();
            frmGestion.ShowDialog();
        }
    }
}
