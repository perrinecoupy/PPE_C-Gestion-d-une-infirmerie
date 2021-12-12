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

        // Méthode qui retourne les classes
        public static List<Classe> GetLesClasses()
        {
            return GestionDAO.GetLesClasses();
        }

        // Méthode qui ajoute un élève dans la base de données
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

        public static List <Eleve> GetUnEleveNomPrenom()
        {
            return GestionDAO.GetUnEleveNomPrenom();
        }

        // méthode qui retourne le libellé qui correspond à l'id de la classe de l'élève
        public static string GetLibelleClasseEleve(int id)
        {
            return GestionDAO.GetLibelleClasseEleve(id);
        }

        // méthode qui supprime un élève de la base de données
        public static void SupprimeEleve(Eleve unEleve)
        {
            GestionDAO.SupprimeEleve(unEleve);
        }

        // Méthode qui modifie un élève dans la base de données
        public static void ModifEleve(Eleve eleve)
        {
            GestionDAO.ModifEleve(eleve);
        }

        // Méthode qui retourne la liste des médicaments
        public static List<Medicament> GetMedicaments()
        {
            return GestionDAO.GetMedicaments();
        }

        // Méthode qui ajoute un médicament dans la base de données
        public static void AjoutMedicament(Medicament medicament)
        {
            GestionDAO.AjoutMedicament(medicament);
        }

        // Méthode qui modifie un médicament dans la base de données
        public static void ModifMedicament(Medicament medicament)
        {
            GestionDAO.ModifMedicament(medicament);
        }

        // méthode qui supprime un médicament de la base de données
        public static void SupprimeMedicament(Medicament unMedicament)
        {
            GestionDAO.SupprimeMedicament(unMedicament);
        }

        // Méthode qui retourne la liste des élèves
        public static List<Visite> GetVisites()
        {
            return GestionDAO.GetVisites();
        }

        // Méthode qui ajoute une visite dans la base de données
        public static void AjoutVisite(Visite visite)
        {
            GestionDAO.AjoutVisite(visite);
        }
    }
}
