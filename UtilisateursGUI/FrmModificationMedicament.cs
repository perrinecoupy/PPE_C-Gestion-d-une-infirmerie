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
    public partial class FrmModificationMedicament : Form
    {
        private Medicament medicament;
        public FrmModificationMedicament(Medicament medicament)
        {
            InitializeComponent();

            this.medicament = medicament;
            txtNomMedicament.Text = this.medicament.Nom;
        }

        private void btnModifierMedicament_Click(object sender, EventArgs e)
        {
            Medicament medicament = new Medicament(this.medicament.Id, txtNomMedicament.Text);

            Gestion.ModifMedicament(medicament);

            lblSuccess.Visible = true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            FrmDetailEleve frmDetailELeve = new FrmDetailEleve();
            frmDetailELeve.ShowDialog();

            this.Close();
        }
    }
}
