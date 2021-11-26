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

            Eleve eleve = Gestion.GetUnEleve(Convert.ToInt32(idEleve.Text));

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

            Gestion.ModifEleve(eleve);

            string LibelleClasse = Gestion.GetLibelleClasseEleve(eleve.Classe);

            txtNomEleve.Text = eleve.Id.ToString();
            txtPrenomEleve.Text = eleve.Nom;
            dpdClasse.Text = eleve.Prenom;
            dtmDateDeNaissanceEleve.Text = eleve.DateNaissance.ToString();
            txtSanteEleve.Text = eleve.Sante.ToString();
            txtTelephoneEleve.Text = eleve.NumTelEleve;
            txtTelephoneParentEleve.Text = eleve.NumTelParent;
            txtTiersTempsEleve.Text = eleve.TiersTemps;
            txtCommentairesSanteEleve.Text = eleve.Commentaire;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            FrmDetailEleve frmDetailELeve = new FrmDetailEleve();
            frmDetailELeve.ShowDialog();

            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Eleve eleve = Gestion.GetUnEleve(Convert.ToInt32(idEleve.Text));

            string LibelleClasse = Gestion.GetLibelleClasseEleve(eleve.Classe);

            idEleve.Text = eleve.Id.ToString();
            txtNomEleve.Text = eleve.Nom;
            txtPrenomEleve.Text = eleve.Prenom;
            dpdClasse.Text = eleve.Classe.ToString();
            dtmDateDeNaissanceEleve.Text = eleve.DateNaissance.ToString();
            txtSanteEleve.Text = eleve.Sante;
            txtTelephoneEleve.Text = eleve.NumTelEleve;
            txtTelephoneParentEleve.Text = eleve.NumTelParent;
            txtTiersTempsEleve.Text = eleve.TiersTemps;
            txtCommentairesSanteEleve.Text = eleve.Commentaire;

            lblSuccess.Visible = false;
        }
    }
}
