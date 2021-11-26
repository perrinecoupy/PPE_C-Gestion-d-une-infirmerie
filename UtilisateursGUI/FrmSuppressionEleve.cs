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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            FrmDetailEleve frmDetailELeve = new FrmDetailEleve();
            frmDetailELeve.ShowDialog();

            this.Hide();
        }

        private void bnbOuiSuppressionEleve_Click(object sender, EventArgs e)
        {
            Eleve unEleve = new Eleve((int)combotBoxSupprimer.SelectedValue);

            DialogResult dialogResult = MessageBox.Show("L'élève a bien été supprimer de la base de données.", "Enregistrement", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.Yes)
            {
                Gestion.SupprimeEleve(unEleve);
            }
        }
    }
}
