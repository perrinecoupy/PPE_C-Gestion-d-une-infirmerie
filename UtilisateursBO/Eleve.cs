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
        string Nom;
        string Prenom;
        int Age;
        char Sexe;
        DateTime DateNaissance;
        string Sante;
        string NumTelEleve;
        string NumTelParent;
        string TiersTemps;
        string Commentaire;
        int Classe;

        public Eleve(int id, string nom, string prenom, int age, char sexe, DateTime dateNaissance, string sante, string numTelEleve, string numTelParent, string tiersTemps, string commentaire, int classe)
        {
            this.Id = id;
            Nom1 = nom;
            Prenom1 = prenom;
            Age1 = age;
            Sexe1 = sexe;
            DateNaissance1 = dateNaissance;
            Sante1 = sante;
            NumTelEleve1 = numTelEleve;
            NumTelParent1 = numTelParent;
            TiersTemps1 = tiersTemps;
            Commentaire1 = commentaire;
            Classe1 = classe;
        }

        public int Id { get => id; set => id = value; }
        public string Nom1 { get => Nom; set => Nom = value; }
        public string Prenom1 { get => Prenom; set => Prenom = value; }
        public int Age1 { get => Age; set => Age = value; }
        public char Sexe1 { get => Sexe; set => Sexe = value; }
        public DateTime DateNaissance1 { get => DateNaissance; set => DateNaissance = value; }
        public string Sante1 { get => Sante; set => Sante = value; }
        public string NumTelEleve1 { get => NumTelEleve; set => NumTelEleve = value; }
        public string NumTelParent1 { get => NumTelParent; set => NumTelParent = value; }
        public string TiersTemps1 { get => TiersTemps; set => TiersTemps = value; }
        public string Commentaire1 { get => Commentaire; set => Commentaire = value; }
        public int Classe1 { get => Classe; set => Classe = value; }
    }
}
