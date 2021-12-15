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
    public partial class FrmModificationVisite : Form
    {
        private Visite visite;
        private DateTime date;
        private string heureArrive;
        private string heureDepart;
        private string motif;
        private string commentaires;
        private string prescription;
        private string statut;
        private string prevention;
        private int id_eleve;

        public FrmModificationVisite(Visite visite)
        {
            InitializeComponent();
            this.visite = visite;
            dateTimeDateVisite.Text = this.visite.Date.ToString();
            txtHeureArriveVisite.Text = this.visite.HeureArrive;
            txtHeureDepartVisite.Text = this.visite.HeureDepart;
            txtMotifVisite.Text = this.visite.Motif;
            txtCommentairesVisite.Text = this.visite.Commentaires;
            List<Medicament> liste = Gestion.GetMedicaments();
            listBoxMedicamentVisite.DataSource = liste;
            listBoxStatutVisite.Text = this.visite.Statut;
            listBoxPreventionParentsVisite.Text = this.visite.Prevention;
            List<Eleve> liste2 = Gestion.GetEleves();
            listBoxNomPrenomEleveVisite.DataSource = liste2;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            FrmDetailsVisite frmDetailVisite = new FrmDetailsVisite();
            this.Close();
            frmDetailVisite.ShowDialog();
        }

        private void btnModifierVisite_Click(object sender, EventArgs e)
        {
            if (dateTimeDateVisite.Text == string.Empty || txtHeureArriveVisite.Text == string.Empty || txtHeureDepartVisite.Text == string.Empty || txtMotifVisite.Text == string.Empty || txtCommentairesVisite.Text == string.Empty || listBoxMedicamentVisite.Text == string.Empty || listBoxStatutVisite.Text == string.Empty || listBoxPreventionParentsVisite.Text == string.Empty)
            {
                erreurChampsVides.Visible = true;
            }
            else
            {
                erreurChampsVides.Visible = false;

                Visite visite = new Visite(this.visite.Id, Convert.ToDateTime(dateTimeDateVisite.Text), txtHeureArriveVisite.Text, txtHeureDepartVisite.Text, txtMotifVisite.Text, txtCommentairesVisite.Text, listBoxMedicamentVisite.Text, listBoxStatutVisite.Text, listBoxPreventionParentsVisite.Text);

                Gestion.ModifVisite(visite);

                lblSuccess.Visible = true;
            }
        }
    }
}
