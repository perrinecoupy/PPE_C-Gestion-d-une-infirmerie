using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisateursBO
{
    public class Medicament
    {
        int id;
        string nom;

        // constructeur utilisé pour afficher les données des médicaments
        public Medicament(int id, string nom)
        {
            this.Id = id;
            this.Nom = nom;
        }

        // Constructeur utilisé pour ajouter un médicament
        public Medicament (string nom)
        {
            this.Nom = nom;
        }

        // Setters et getters
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
    }
}
