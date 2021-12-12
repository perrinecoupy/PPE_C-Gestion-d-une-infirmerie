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
    public partial class FrmAjoutVisite : Form
    {
        public FrmAjoutVisite()
        {
            InitializeComponent();

            List<Eleve> liste = Gestion.GetUnEleveNomPrenom();

            listBoxNomPrenomEleveVisite.DataSource = liste;

            List<Medicament> liste2 = Gestion.GetMedicaments();

            listBoxMedicamentVisite.DataSource = liste2;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            FrmDetailsVisite frmDetailVisite = new FrmDetailsVisite();
            this.Hide();
            frmDetailVisite.ShowDialog();
        }

        private void btnAjoutVisite_Click(object sender, EventArgs e)
        {
            {
                // vérification que les champs ne sont pas vides
                if (listBoxNomPrenomEleveVisite.Text == string.Empty || dateTimeDateVisite.Text == string.Empty || txtHeureArriveVisite.Text == string.Empty || txtHeureDepartVisite.Text == string.Empty || txtMotifVisite.Text == string.Empty || txtCommentairesVisite.Text == string.Empty || listBoxMedicamentVisite.Text == string.Empty || listBoxStatutVisite.Text == string.Empty || listBoxPreventionParentsVisite.Text == string.Empty)
                {
                    erreurChampsVides.Visible = true;
                }

                // si ils ne sont pas vides
                else
                {
                    erreurChampsVides.Visible = false;

                    // Ajout de la visite
                    if (erreurChampsVides.Visible == false)
                    {
                        List<Eleve> idEleve = Gestion.GetEleves();

                        Visite visite = new Visite(Convert.ToDateTime(dateTimeDateVisite.Text), txtHeureArriveVisite.Text, txtHeureDepartVisite.Text, txtMotifVisite.Text, txtCommentairesVisite.Text, Convert.ToString(listBoxMedicamentVisite.SelectedItems), Convert.ToString(listBoxStatutVisite.SelectedItems), Convert.ToString(listBoxPreventionParentsVisite.SelectedItems), ((Eleve)listBoxNomPrenomEleveVisite.SelectedItem).Id);

                        Gestion.AjoutVisite(visite);

                        lblSuccess.Visible = true;

                    }
                }
            }
        }
    }
}
