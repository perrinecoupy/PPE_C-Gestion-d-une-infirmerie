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
    public partial class lblAjoutEleve : Form
    {
        public lblAjoutEleve()
        {
            InitializeComponent();
            List<Classe> liste = Gestion.GetLesClasses();

            dpdClasse.DataSource = liste;

            List<Diplome> liste2 = Gestion.GetLesDiplomes();

            dpdDiplome.DataSource = liste2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // vérification que les champs ne sont pas vides
                if (txtNomEleve.Text == string.Empty || txtPrenomEleve.Text == string.Empty || dpdClasse.Text == string.Empty || dtmDateDeNaissanceEleve.Text == string.Empty || txtSanteEleve.Text == string.Empty || txtTelephoneEleve.Text == string.Empty || txtTelephoneParentEleve.Text == string.Empty || txtTiersTempsEleve.Text == string.Empty || txtCommentairesSanteEleve.Text == string.Empty || txtCommentairesSanteEleve.Text == string.Empty || dpdDiplome.Text == string.Empty)
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
                        List<Classe> idClasse = Gestion.GetLesClasses();

                            Eleve eleve = new Eleve(txtNomEleve.Text, txtPrenomEleve.Text, Convert.ToDateTime(dtmDateDeNaissanceEleve.Text), txtSanteEleve.Text, txtTelephoneEleve.Text, txtTelephoneParentEleve.Text, txtTiersTempsEleve.Text, txtCommentairesSanteEleve.Text, ((Classe)dpdClasse.SelectedItem).Id);

                            Gestion.AjoutEleve(eleve);

                            lblSuccess.Visible = true;

                        }
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            FrmDetailEleve frmDetailELeve = new FrmDetailEleve();
            this.Hide();
            frmDetailELeve.ShowDialog();
        }
    }
}
