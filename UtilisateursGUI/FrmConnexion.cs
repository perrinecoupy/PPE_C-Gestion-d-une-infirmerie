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
using System.Configuration;

namespace UtilisateursGUI
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();

            Gestion.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            bool vide = false;

            // vérification du remplissage des champs

            if (txtIdentifiant.Text == string.Empty)
            {
                txtIdentifiant.Visible = true;
                vide = true;
            }
            else
            {
                erreurIdentifiant.Visible = false;
            }

            if (txtMotdePasse.Text == string.Empty)
            {
                erreurMotDePasse.Visible = true;
                vide = true;
            }
            else
            {
                erreurMotDePasse.Visible = false;
            }

            // vérification des informations de connexion

            if (!Gestion.EstConnecte(txtIdentifiant.Text, txtMotdePasse.Text))
            {
                if (vide)
                {
                    erreurIdentification.Visible = false;
                }
                else
                {
                    erreurIdentification.Visible = true;
                }
            }

            else
            {
                if(vide != true)
                {
                    if (Gestion.EstConnecte(txtIdentifiant.Text, txtMotdePasse.Text))
                    {
                        ChoixAdmin choixAdmin = new ChoixAdmin();
                        choixAdmin.Show();
                    }

                    else
                    {
                        Comptabilite comptabilite = new Comptabilite();
                        comptabilite.Show();
                    }

                    this.Hide();
                }
            }
        }
    }
}
