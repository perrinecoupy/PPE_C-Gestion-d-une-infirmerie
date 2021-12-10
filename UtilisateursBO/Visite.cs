using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisateursBO
{
    public class Visite
    {
        int id;
        DateTime date;
        DateTime heureArrive;
        DateTime heureDepart;
        string motif;
        string commentaires;
        char statut;
        char prevention;
        int id_eleve;

        public Visite(int id, DateTime date, DateTime heureArrive, DateTime heureDepart, string motif, string commentaires, char statut, char prevention, int id_eleve)
        {
            this.Id = id;
            this.Date = date;
            this.HeureArrive = heureArrive;
            this.HeureDepart = heureDepart;
            this.Motif = motif;
            this.Commentaires = commentaires;
            this.Statut = statut;
            this.Prevention = prevention;
            this.Id_eleve = id_eleve;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public DateTime HeureArrive { get => heureArrive; set => heureArrive = value; }
        public DateTime HeureDepart { get => heureDepart; set => heureDepart = value; }
        public string Motif { get => motif; set => motif = value; }
        public string Commentaires { get => commentaires; set => commentaires = value; }
        public char Statut { get => statut; set => statut = value; }
        public char Prevention { get => prevention; set => prevention = value; }
        public int Id_eleve { get => id_eleve; set => id_eleve = value; }
    }
}
