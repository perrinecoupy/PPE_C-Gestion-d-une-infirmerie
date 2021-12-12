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
            colonneNom.DataPropertyName = "date";
            colonneNom.HeaderText = "DATE";
            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn colonnePrenom = new DataGridViewTextBoxColumn();
            colonnePrenom.DataPropertyName = "heureArrive";
            colonnePrenom.HeaderText = "HEURE D'ARRIVE";

            // Création d'une en-tête de colonne pour la colonne 3
            DataGridViewTextBoxColumn colonneDateNaissace = new DataGridViewTextBoxColumn();
            colonneDateNaissace.DataPropertyName = "heureDepart";
            colonneDateNaissace.HeaderText = "HEURE DE DEPART";

            // Création d'une en-tête de colonne pour la colonne 4
            DataGridViewTextBoxColumn colonneSante = new DataGridViewTextBoxColumn();
            colonneSante.DataPropertyName = "motif";
            colonneSante.HeaderText = "MOTIF";

            // Création d'une en-tête de colonne pour la colonne 5
            DataGridViewTextBoxColumn colonneNumTelEleve = new DataGridViewTextBoxColumn();
            colonneNumTelEleve.DataPropertyName = "commentaires";
            colonneNumTelEleve.HeaderText = "COMMENTAIRES";

            // Création d'une en-tête de colonne pour la colonne 6
            DataGridViewTextBoxColumn colonneNumTelParentEleve = new DataGridViewTextBoxColumn();
            colonneNumTelParentEleve.DataPropertyName = "statut";
            colonneNumTelParentEleve.HeaderText = "STATUT";

            // Création d'une en-tête de colonne pour la colonne 7
            DataGridViewTextBoxColumn colonneTiersTemps = new DataGridViewTextBoxColumn();
            colonneTiersTemps.DataPropertyName = "prevention";
            colonneTiersTemps.HeaderText = "PREVENTION";

            // Création d'une en-tête de colonne pour la colonne 8
            DataGridViewTextBoxColumn colonneCommentaire = new DataGridViewTextBoxColumn();
            colonneCommentaire.DataPropertyName = "id_eleve";
            colonneCommentaire.HeaderText = "ID ELEVE";

            // Création d'une en-tête de colonne pour la colonne 9
            DataGridViewTextBoxColumn colonneClasse = new DataGridViewTextBoxColumn();
            colonneClasse.DataPropertyName = "classe";
            colonneClasse.HeaderText = "CLASSE";

            // Ajout des 9 en-têtes de colonne au datagridview
            dataGridViewVisite.Columns.Add(colonneNom);
            dataGridViewVisite.Columns.Add(colonnePrenom);
            dataGridViewVisite.Columns.Add(colonneDateNaissace);
            dataGridViewVisite.Columns.Add(colonneNumTelEleve);
            dataGridViewVisite.Columns.Add(colonneNumTelParentEleve);
            dataGridViewVisite.Columns.Add(colonneTiersTemps);
            dataGridViewVisite.Columns.Add(colonneCommentaire);
            dataGridViewVisite.Columns.Add(colonneClasse);

            // Définition du style apporté au datagridview
            dataGridViewVisite.ColumnHeadersVisible = true;
            colonneNom.Width = 140;
            colonnePrenom.Width = 140;
            colonneDateNaissace.Width = 140;
            colonneNumTelEleve.Width = 140;
            colonneNumTelParentEleve.Width = 140;
            colonneTiersTemps.Width = 140;
            colonneCommentaire.Width = 140;
            colonneClasse.Width = 140;

            var lesEleves = new List<Visite>();

            lesEleves = Gestion.GetVisites();
        }
    }
}
