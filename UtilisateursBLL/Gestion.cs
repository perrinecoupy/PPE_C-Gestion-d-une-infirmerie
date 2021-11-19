using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using UtilisateursDAL;
using UtilisateursBO;
using System.Configuration;

namespace UtilisateursBLL
{
    public class Gestion
    {
        private static Gestion uneGestionUtilisateurs; // objet BLL

        // Accesseur en lecture
        public static Gestion GetGestionUtilisateurs()
        {
            if (uneGestionUtilisateurs == null)
            {
                uneGestionUtilisateurs = new Gestion();
            }

            return uneGestionUtilisateurs;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui retourne vrai si les informations de connexion sont les bonnes
        public static bool EstConnecte(string login, string mdp)
        {
            return GestionDAO.EstConnecte(login, mdp);
        }

        // Méthode qui ajoute un adhérent dans la base de données
        public static void AjoutEleve(Eleve eleve)
        {
            GestionDAO.AjoutEleve(eleve);
        }
    }
}
