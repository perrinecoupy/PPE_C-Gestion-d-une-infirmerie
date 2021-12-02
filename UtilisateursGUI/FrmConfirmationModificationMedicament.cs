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
    public partial class FrmConfirmationModificationMedicament : Form
    {
        public FrmConfirmationModificationMedicament()
        {
            InitializeComponent();

            List<Medicament> liste = new List<Medicament>();
            liste = Gestion.GetMedicaments();
            // Rattachement de la List à la source de données du comboBox

            cmbConfirmation.ValueMember = "Id";

            cmbConfirmation.DisplayMember = "Nom";

            cmbConfirmation.DataSource = liste;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            FrmModificationMedicament FrmModificationMedicament;
            FrmModificationMedicament = new FrmModificationMedicament((Medicament)cmbConfirmation.SelectedItem);
            FrmModificationMedicament.ShowDialog();
            FrmModificationMedicament.Close();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FrmDetailsMedicament frmDetailsMedicament = new FrmDetailsMedicament();
            this.Close();
            frmDetailsMedicament.ShowDialog();
        }
    }
}
