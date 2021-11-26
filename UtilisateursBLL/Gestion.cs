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

        // Méthode qui ajoute un élève dans la base de données
        public static void AjoutEleve(Eleve eleve)
        {
            GestionDAO.AjoutEleve(eleve);
        }

        // Méthode qui retourne l'id qui correspond au libelle de la classe de l'élève
        public static int GetIdClasseEleve(int id)
        {
            return GestionDAO.GetIdClasseEleve(id);
        }

        public static List<Classe> GetLesClasses()
        {
            return GestionDAO.GetLesClasses();
        }

        // Méthode qui ajoute un adhérent dans la base de données
        public static int GetDernierIdEleve()
        {
            return GestionDAO.GetDernierIdEleve();
        }

        // Méthode qui retourne la liste des élèves
        public static List<Eleve> GetEleves()
        {
            return GestionDAO.GetEleves();
        }

        // Méthode qui retourne une liste contenant un élève
        public static Eleve GetUnEleve(int id)
        {
            return GestionDAO.GetUnEleve(id);
        }

        // méthode qui retourne le libellé qui correspond à l'id de la classe de l'adhérent
        public static string GetLibelleClasseAdherent(int id)
        {
            return GestionDAO.GetLibelleClasseAdherent(id);
        }

        // méthode qui supprime un adhérent de la base de données
        public static void SupprimeEleve(Eleve unEleve)
        {
            GestionDAO.SupprimeEleve(unEleve);
        }

        // Méthode qui modifie un adhérent dans la base de données
        public static void ModifEleve(Eleve eleve)
        {
            GestionDAO.ModifEleve(eleve);
        }

    }
}
