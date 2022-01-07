using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisateursBO
{
    public class Eleve
    {
        int id;
        string nom;
        string prenom;
        DateTime dateNaissance;
        string sante;
        string numTelEleve;
        string numTelParent;
        string tiersTemps;
        string commentaire;
        int classe;
        int diplome;

        // Constructeur utilisé pour sauvegarder l'id de l'élève pour appliquer les modifications et la suppression
        public Eleve(int id)
        {
            this.id = id;
        }

        // Fonction magique qui permet d'afficher le nom des élèves
        public override string ToString()
        {
            return nom;
        }

        // constructeur utilisé pour afficher les données des élèves
        public Eleve(int id, string nom, string prenom, DateTime dateNaissance, string sante, string numTelEleve, string numTelParent, string tiersTemps, string commentaire, int classe, int diplome)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.sante = sante;
            this.numTelEleve = numTelEleve;
            this.numTelParent = numTelParent;
            this.tiersTemps = tiersTemps;
            this.commentaire = commentaire;
            this.classe = classe;
            this.diplome = diplome;
        }

        // constructeur utilisé pour afficher les données des élèves
        public Eleve(int id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }

        // constructeur utilisé pour ajouter un élève dans la base de données
        public Eleve(string nom, string prenom, DateTime dateNaissance, string sante, string numTelEleve, string numTelParent, string tiersTemps, string commentaire, int classe, int diplome)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.sante = sante;
            this.numTelEleve = numTelEleve;
            this.numTelParent = numTelParent;
            this.tiersTemps = tiersTemps;
            this.commentaire = commentaire;
            this.classe = classe;
            this.diplome = diplome;
        }

        // Setters et getters
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string Sante { get => sante; set => sante = value; }
        public string NumTelEleve { get => numTelEleve; set => numTelEleve = value; }
        public string NumTelParent { get => numTelParent; set => numTelParent = value; }
        public string TiersTemps { get => tiersTemps; set => tiersTemps = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
        public int Classe { get => classe; set => classe = value; }
        public int Diplome { get => diplome; set => diplome = value; }
    }
}
