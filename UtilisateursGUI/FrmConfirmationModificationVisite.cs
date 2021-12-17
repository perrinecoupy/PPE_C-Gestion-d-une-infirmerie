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
    public partial class FrmConfirmationModificationVisite : Form
    {
        public FrmConfirmationModificationVisite()
        {
            InitializeComponent();

            List<Visite> liste = new List<Visite>();
            liste = Gestion.GetVisites();
            // Rattachement de la List à la source de données du comboBox

            cmbConfirmation.ValueMember = "Id";

            cmbConfirmation.DisplayMember = "Eleve";

            cmbConfirmation.DataSource = liste;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            FrmModificationVisite FrmModificationVisite;
            FrmModificationVisite = new FrmModificationVisite((Visite)cmbConfirmation.SelectedItem);
            FrmModificationVisite.ShowDialog();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmDetailsVisite frmDetailVisite = new FrmDetailsVisite();
            this.Close();
            frmDetailVisite.ShowDialog();
        }
    }
}
