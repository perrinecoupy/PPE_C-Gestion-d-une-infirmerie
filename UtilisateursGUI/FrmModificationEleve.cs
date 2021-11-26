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
        private Eleve eleve;
        private string nom;
        private string prenom;
        //private DateTime dateNaissance;
        private DateTime dateNaissance = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        private string sante;
        private string numTelEleve;
        private string numTelParent;
        private string tiersTemps;
        private string commentaire;
        private int classe;

        

        public FrmModificationEleve(Eleve eleve)
        {
            InitializeComponent();
            this.eleve = eleve;
            txtNomEleve.Text = this.eleve.Nom;
            txtPrenomEleve.Text = this.eleve.Prenom;
            dtmDateDeNaissanceEleve.Text = this.eleve.DateNaissance.ToString();
            txtSanteEleve.Text = this.eleve.Sante;
            txtTelephoneEleve.Text = this.eleve.NumTelEleve;
            txtTelephoneParentEleve.Text = this.eleve.NumTelParent;
            txtTiersTempsEleve.Text = this.eleve.TiersTemps;
            txtCommentairesSanteEleve.Text = this.eleve.Commentaire;
            List<Classe> liste = Gestion.GetLesClasses();
            dpdClasse.DataSource = liste;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            FrmDetailEleve frmDetailELeve = new FrmDetailEleve();
            frmDetailELeve.ShowDialog();

            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            Eleve eleve = new Eleve(nom, prenom, dateNaissance, sante, numTelEleve, numTelParent, tiersTemps, commentaire, classe);

            Gestion.ModifEleve(eleve);
        }
    }
}
