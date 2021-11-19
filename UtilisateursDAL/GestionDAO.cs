using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using UtilisateursBO;

namespace UtilisateursDAL
{
    public class GestionDAO
    {
        private static GestionDAO unUtilisateurDAO;

        // Accesseur en lecteur qui va renvoyer une instance
        public static GestionDAO GestionUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new GestionDAO();
            }

            return unUtilisateurDAO;
        }

        // Méthode qui retourne vrai si les informations de connexion sont bonnes
        public static bool EstConnecte(string login, string mdp)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT login_utilisateur, mot_de_passe_utilisateur FROM UTILISATEUR";

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                if (monReader["login_utilisateur"].ToString() == login && monReader["mot_de_passe_utilisateur"].ToString() == mdp)
                {
                    monReader.Close();
                    maConnexion.Close();

                    return true;
                }
            }
            monReader.Close();
            maConnexion.Close();

            return false;
        }
    }

    // Méthode qui ajoute un adhérent dans la base de données
    public static void AjoutEleve (Eleve eleve)
    {
        // Connexion à la BD
        SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

        // Requette sql
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = maConnexion;
        cmd.CommandText = "INSERT INTO Eleve (nom_eleve, prenom_eleve, age_eleve, sexe_eleve, date_de_naissance_eleve, sante_eleve, numero_telephone_eleve, numero_telephone_parent_eleve, tiers_temps_eleve, commentaires_sante_libre_eleve, #id_classe_eleve) VALUES (@Nom_eleve, @Prenom_eleve, @Age_eleve, @Sexe_eleve, @Date_de_naissance_eleve, @Sante_eleve, @Numero_telephone_eleve, @Numero_telephone_parent_eleve, @Tiers_temps_eleve, @Commentaires_sante_libre_eleve, @Id_classe_eleve)";

        // Ajout des paramètres
        cmd.Parameters.AddWithValue("@Nom_eleve", eleve.Nom);
        cmd.Parameters.AddWithValue("@Prenom_eleve", eleve.Prenom);
        cmd.Parameters.AddWithValue("@Age_eleve", eleve.Age);
        cmd.Parameters.AddWithValue("@Sexe_eleve", eleve.Sexe);
        cmd.Parameters.AddWithValue("@Date_de_naissance_eleve", eleve.DateNaissance);
        cmd.Parameters.AddWithValue("@Sante_eleve", eleve.Sante);
        cmd.Parameters.AddWithValue("@Numero_telephone_eleve", eleve.NumeroTelEleve);
        cmd.Parameters.AddWithValue("@Numero_telephine_parent_eleve", eleve.NumTelParent);
        cmd.Parameters.AddWithValue("@Tiers_temps_eleve", eleve.TiersTemps);
        cmd.Parameters.AddWithValue("@Commentaires_sante_libre_eleve", eleve.Commentaire);
        cmd.Parameters.AddWithValue("@Id_classe_eleve", eleve.Classe);

        // Execution de la requete
        cmd.ExecuteNonQuery();

        maConnexion.Close();
    }
}
