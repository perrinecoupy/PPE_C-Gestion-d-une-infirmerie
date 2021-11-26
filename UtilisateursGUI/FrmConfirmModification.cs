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
    public partial class FrmConfirmModification : Form
    {
        public FrmConfirmModification()
        {
            InitializeComponent();

            List<Eleve> liste = new List<Eleve>();
            liste = Gestion.GetEleves();
            // Rattachement de la List à la source de données du comboBox

            cmbConfirmation.ValueMember = "Id";

            cmbConfirmation.DisplayMember = "Nom";

            cmbConfirmation.DataSource = liste;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            FrmModificationEleve FrmModificationEleve;
            FrmModificationEleve = new FrmModificationEleve((Eleve)cmbConfirmation.SelectedItem);
            FrmModificationEleve.ShowDialog();
            FrmModificationEleve.Close();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmDetailEleve frmDetailELeve = new FrmDetailEleve();
            frmDetailELeve.ShowDialog();

            this.Close();
        }
    }
}
