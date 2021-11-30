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
    public partial class FrmSuppressionMedicament : Form
    {
        public FrmSuppressionMedicament()
        {
            InitializeComponent();

            List<Medicament> liste = new List<Medicament>();
            liste = Gestion.GetMedicaments();
            // Rattachement de la List à la source de données du comboBox

            combotBoxSupprimer.ValueMember = "Id";

            combotBoxSupprimer.DisplayMember = "Nom";

            combotBoxSupprimer.DataSource = liste;
        }

        private void bnbNonSuppressionMedicament_Click(object sender, EventArgs e)
        {
            FrmDetailsMedicament frmDetailsMedicament = new FrmDetailsMedicament();
            this.Hide();
            frmDetailsMedicament.ShowDialog();
        }

        private void bnbOuiSuppressionMedicament_Click(object sender, EventArgs e)
        {
            Medicament unMedicament = (Medicament)combotBoxSupprimer.SelectedItem;

            Gestion.SupprimeMedicament(unMedicament);
            DialogResult dialogResult = MessageBox.Show("Le médicament a bien été supprimé de la base de données.", "Enregistrement", MessageBoxButtons.OK);
        }
    }
}
