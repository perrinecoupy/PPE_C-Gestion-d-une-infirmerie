﻿using System;
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

        // Méthode qui ajoute un élève dans la base de données
        public static void AjoutEleve(Eleve eleve)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO ELEVE (Nom_eleve, Prenom_eleve, Date_de_naissance_eleve, Sante_eleve, Numero_telephone_eleve, Numero_telephone_parent_eleve, Tiers_temps_eleve, Commentaires_sante_libre_eleve, #Id_classe_eleve) VALUES (@Nom_eleve, @Prenom_eleve, @Date_de_naissance_eleve, @Sante_eleve, @Numero_telephone_eleve, @Numero_telephone_parent_eleve, @Tiers_temps_eleve, @Commentaires_sante_libre_eleve, @Id_classe_eleve)";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@Nom_eleve", eleve.Nom);
            cmd.Parameters.AddWithValue("@Prenom_eleve", eleve.Prenom);
            cmd.Parameters.AddWithValue("@Date_de_naissance_eleve", eleve.DateNaissance);
            cmd.Parameters.AddWithValue("@Sante_eleve", eleve.Sante);
            cmd.Parameters.AddWithValue("@Numero_telephone_eleve", eleve.NumTelEleve);
            cmd.Parameters.AddWithValue("@Numero_telephine_parent_eleve", eleve.NumTelParent);
            cmd.Parameters.AddWithValue("@Tiers_temps_eleve", eleve.TiersTemps);
            cmd.Parameters.AddWithValue("@Commentaires_sante_libre_eleve", eleve.Commentaire);
            cmd.Parameters.AddWithValue("@Id_classe_eleve", eleve.Classe);

            // Execution de la requete
            cmd.ExecuteNonQuery();

            maConnexion.Close();
        }

        // Méthode qui retourne l'id d'un élève
        public static int GetDernierIdEleve()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT id_eleve FROM ELEVE WHERE id_eleve = (SELECT max(id_eleve) FROM ELEVE)";

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                return Convert.ToInt32(monReader["id_eleve"]);
            }

            monReader.Close();
            maConnexion.Close();

            return 0;
        }

        // méthode qui retourne l'id qui correspond au libelle de la classe de l'élève
        public static int GetIdClasseEleve(int id)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT id_classe FROM CLASSE WHERE id_classe = @id";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@libelle", id);

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();



            monReader.Read();
            
            int idClasse = (int)monReader["id_classe"];
            
            monReader.Close();
            maConnexion.Close();

            return idClasse;
        }

        // Méthode qui retourne la liste des élèves
        public static List<Eleve> GetEleves()
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM ELEVE";

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            var lesEleves = new List<Eleve>();

            while (monReader.Read())
            {
                Eleve eleve = new Eleve(Convert.ToInt32(monReader["id_eleve"]), monReader["nom_eleve"].ToString(), monReader["prenom_eleve"].ToString(), Convert.ToDateTime(monReader["date_de_naissance_eleve"]), monReader["sante_eleve"].ToString(), monReader["numero_telephone_eleve"].ToString(), monReader["numero_telephone_parent_eleve"].ToString(), monReader["tiers_temps_eleve"].ToString(), monReader["commentaires_sante_libre_eleve"].ToString(), (Convert.ToInt32(monReader["id_classe_eleve"])));

                lesEleves.Add(eleve);

                monReader.Close();
                maConnexion.Close();
            }
            monReader.Close();
            maConnexion.Close();

            return lesEleves;
        }

        // Méthode qui retourne un élève
        public static Eleve GetUnEleve(int id)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM ADHERENT WHERE Id_adherent = @id";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@id", id);

            // Lecture des données
            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                Eleve eleve = new Eleve(Convert.ToInt32(monReader["id_eleve"]), monReader["nom_eleve"].ToString(), monReader["prenom_eleve"].ToString(), Convert.ToDateTime(monReader["date_de_naissance_eleve"]), monReader["sante_eleve"].ToString(), monReader["numero_telephone_eleve"].ToString(), monReader["numero_telephone_parent_eleve"].ToString(), monReader["tiers_temps_eleve"].ToString(), monReader["commentaires_sante_libre_eleve"].ToString(), (Convert.ToInt32(monReader["id_classe_eleve"])));

                return eleve;
            }

            monReader.Close();
            maConnexion.Close();

            return null;
        }

        // Méthode qui supprime un élève dans la base de données
        public static void SupprimeEleve(int id)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM ELEVE WHERE Id_eleve = @id";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@id", id);

            // Execution de la requete
            cmd.ExecuteNonQuery();

            maConnexion.Close();
        }

        // Méthode qui modifie un élève dans la base de données
        public static void ModifEleve(Eleve eleve)
        {
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Requette sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "UPDATE ELEVE SET Nom_eleve = @nom_eleve,  Prenom_eleve = @Prenom_eleve,  Date_de_naissance_eleve = @Date_de_naissance_eleve, Sante_eleve = @Sante_eleve, Numero_telephone_eleve = @Numero_detelephone_eleve, Numero_telephone_parent_eleve = @Numero_de_telephone_parent_eleve, Tiers_temps_eleve = @Tiers_temps_eleve, Commentaires_sante_libre_eleve = @Commentaires_sante_libre_eleve, #Id_classe_eleve = @Id_classe_id WHERE @Id_eleve = @id)";

            // Ajout des paramètres
            cmd.Parameters.AddWithValue("@Nom_eleve", eleve.Nom);
            cmd.Parameters.AddWithValue("@Prenom_eleve", eleve.Prenom);
            cmd.Parameters.AddWithValue("@Date_de_naissance_eleve", eleve.DateNaissance);
            cmd.Parameters.AddWithValue("@Sante_eleve", eleve.Sante);
            cmd.Parameters.AddWithValue("@Numero_telephone_eleve", eleve.NumTelEleve);
            cmd.Parameters.AddWithValue("@Numero_telephine_parent_eleve", eleve.NumTelParent);
            cmd.Parameters.AddWithValue("@Tiers_temps_eleve", eleve.TiersTemps);
            cmd.Parameters.AddWithValue("@Commentaires_sante_libre_eleve", eleve.Commentaire);
            cmd.Parameters.AddWithValue("@Id_classe_eleve", eleve.Classe);

            // Execution de la requete
            cmd.ExecuteNonQuery();

            maConnexion.Close();
        }
    }
}
