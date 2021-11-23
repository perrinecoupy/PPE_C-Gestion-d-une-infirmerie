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
    public partial class FrmModificationEleve : Form
    {
        public FrmModificationEleve()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            FrmDetailEleve frmDetailELeve = new FrmDetailEleve();
            frmDetailELeve.ShowDialog();

            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Eleve eleve = Gestion.GetUnEleve(Convert.ToInt32(id.Text));

            if (txtNomEleve.Text != "")
            {
                eleve.Nom = txtNomEleve.Text;
            }

            if (txtPrenomEleve.Text != "")
            {
                eleve.Nom = txtPrenomEleve.Text;
            }

            if (dpdClasse.Text != "")
            {
                eleve.Nom = dpdClasse.Text;
            }

            if (dtmDateDeNaissanceEleve.Text != "")
            {
                eleve.Nom = dtmDateDeNaissanceEleve.Text;
            }

            if (txtSanteEleve.Text != "")
            {
                eleve.Nom = txtSanteEleve.Text;
            }

            if (txtTelephoneEleve.Text != "")
            {
                eleve.Nom = txtTelephoneEleve.Text;
            }

            if (txtTelephoneParentEleve.Text != "")
            {
                eleve.Nom = txtTelephoneParentEleve.Text;
            }

            if (txtTiersTempsEleve.Text != "")
            {
                eleve.Nom = txtTiersTempsEleve.Text;
            }

            if (txtCommentairesSanteEleve.Text != "")
            {
                eleve.Nom = txtCommentairesSanteEleve.Text;
            }
        }
    }
}
