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
        }

        private void lblNomEleve_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // vérification que les champs ne sont pas vides
                if (txtNomEleve.Text == string.Empty || txtPrenomEleve.Text == string.Empty || dpdClasse.Text == string.Empty || dtmDateDeNaissanceEleve.Text == string.Empty || txtSanteEleve.Text == string.Empty || txtTelephoneEleve.Text == string.Empty || txtTelephoneParentEleve.Text == string.Empty || txtTiersTempsEleve.Text == string.Empty || txtCommentairesSanteEleve.Text == string.Empty || txtCommentairesSanteEleve.Text == string.Empty)
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
                            int idClasse = Gestion.GetIdClasseEleve(dpdClasse.Text);

                            Eleve eleve = new Eleve(txtNomEleve.Text, txtPrenomEleve.Text, Convert.ToDateTime(dtmDateDeNaissanceEleve.Text), txtSanteEleve.Text, txtTelephoneEleve.Text, txtTelephoneParentEleve.Text, txtTiersTempsEleve.Text, txtCommentairesSanteEleve.Text, idClasse);

                            Gestion.AjoutEleve(eleve);

                            lblSuccess.Visible = true;

                        }
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblAjoutEleve_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestion_InfirmerieDataSet.CLASSE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cLASSETableAdapter.Fill(this.gestion_InfirmerieDataSet.CLASSE);

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            FrmDetailEleve frmDetailELeve = new FrmDetailEleve();
            frmDetailELeve.ShowDialog();

            this.Hide();
        }
    }
}
