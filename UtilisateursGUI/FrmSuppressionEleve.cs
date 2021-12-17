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
using UtilisateursDAL;

namespace UtilisateursGUI
{
    public partial class FrmSuppressionEleve : Form
    {
        public FrmSuppressionEleve()
        {
            InitializeComponent();

            List<Eleve> liste = new List<Eleve>();
            liste = Gestion.GetEleves();
            // Rattachement de la List à la source de données du comboBox

            combotBoxSupprimer.ValueMember = "Id";

            combotBoxSupprimer.DisplayMember = "Nom";

            combotBoxSupprimer.DataSource = liste;
        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            FrmDetailEleve frmDetailELeve = new FrmDetailEleve();
            this.Hide();
            frmDetailELeve.ShowDialog();
        }

        private void bnbOuiSuppressionEleve_Click(object sender, EventArgs e)
        {
            Eleve unEleve = (Eleve)combotBoxSupprimer.SelectedItem;

            Gestion.SupprimeEleve(unEleve);
            DialogResult dialogResult = MessageBox.Show("L'élève a bien été supprimé de la base de données.", "Enregistrement", MessageBoxButtons.OK);
            FrmSuppressionEleve frmSuppressionEleve = new FrmSuppressionEleve();
            this.Hide();
            frmSuppressionEleve.ShowDialog();
            
        }
    }
}
