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
    public partial class FrmAjoutMedicament : Form
    {
        public FrmAjoutMedicament()
        {
            InitializeComponent();
        }

        private void btnAjoutMedicament_Click(object sender, EventArgs e)
        {
            // vérification que les champs ne sont pas vides
            if (txtNomMedicament.Text == string.Empty)
            {
                erreurChampsVides.Visible = true;
            }
            // si ils ne sont pas vides
            else
            {
                erreurChampsVides.Visible = false;

                // Ajout de l'élève
                if (erreurChampsVides.Visible == false)
                {

                    Medicament medicament = new Medicament(txtNomMedicament.Text);

                    Gestion.AjoutMedicament(medicament);

                    lblSuccess.Visible = true;

                }
            }
        }

        private void btnAnnulerMedicament_Click(object sender, EventArgs e)
        {
            FrmDetailsMedicament frmDetailMedicament = new FrmDetailsMedicament();
            this.Hide();
            frmDetailMedicament.ShowDialog();
        }
    }
}
