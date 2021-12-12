using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilisateursGUI
{
    public partial class FrmGestion : Form
    {
        public FrmGestion()
        {
            InitializeComponent();
        }

        // Ouverture du formulaire AJOUTER UN ELEVE
        private void btnGestionEleve_Click(object sender, EventArgs e)
        {
            FrmDetailEleve frmDetailELeve = new FrmDetailEleve();
            this.Hide();
            frmDetailELeve.ShowDialog();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            FrmConnexion frmConnexion = new FrmConnexion();
            this.Close();
            frmConnexion.ShowDialog();
        }

        private void btnGestionMedicament_Click(object sender, EventArgs e)
        {
            FrmDetailsMedicament frmDetailMedicament = new FrmDetailsMedicament();
            this.Hide();
            frmDetailMedicament.ShowDialog();
        }

        private void btnGestionVisite_Click(object sender, EventArgs e)
        {
            FrmAjoutVisite frmDetailVisite = new FrmAjoutVisite();
            this.Hide();
            frmDetailVisite.ShowDialog();
        }
    }
}
