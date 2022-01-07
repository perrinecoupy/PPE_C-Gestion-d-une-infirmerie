using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisateursBO
{
    public class Diplome
    {
        int id;
        string libelle;

        // constructeur utilisé pour afficher les données des diplômes
        public Diplome(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        // Fonction magique qui permet d'afficher le nom des diplômes
        public override string ToString()
        {
            return libelle;
        }

        // Setters et getters
        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
