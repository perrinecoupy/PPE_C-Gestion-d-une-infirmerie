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
                erreurIdentifiant.Visible = true;
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

            if (Gestion.EstConnecte(txtIdentifiant.Text, txtMotdePasse.Text))
            {
                FrmGestion choixAdmin = new FrmGestion();
                this.Hide();
                choixAdmin.Show();
            }

            else
            {
                //message d'erreur si le nom d'utilisateur ou le mot de passe n'est pas bon
                MessageBox.Show("Identifiant ou mot de passe incorrects");
            }
        }

        // Bouton qui permet de quitter l'application
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
