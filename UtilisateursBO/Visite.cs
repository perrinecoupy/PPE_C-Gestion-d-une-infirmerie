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
        string heureArrive;
        string heureDepart;
        string motif;
        string commentaires;
        string prescription;
        string quantite;
        string statut;
        string prevention;
        int id_eleve;

        // constructeur utilisé pour ajouter une visite dans la base de données
        public Visite(int id, DateTime date, string heureArrive, string heureDepart, string motif, string commentaires, string prescription, string quantite, string statut, string prevention)
        {
            this.Id = id;
            this.Date = date;
            this.HeureArrive = heureArrive;
            this.HeureDepart = heureDepart;
            this.Motif = motif;
            this.Commentaires = commentaires;
            this.Prescription = prescription;
            this.Quantite = quantite;
            this.Statut = statut;
            this.Prevention = prevention;
        }
        public Visite(int id, DateTime date, string heureArrive, string heureDepart, string motif, string commentaires, string prescription, string statut, string prevention, int id_eleve)
        {
            this.Id = id;
            this.Date = date;
            this.HeureArrive = heureArrive;
            this.HeureDepart = heureDepart;
            this.Motif = motif;
            this.Commentaires = commentaires;
            this.Prescription = prescription;
            this.Statut = statut;
            this.Prevention = prevention;
            this.Id_eleve = id_eleve;
        }
        public Visite(int id, DateTime date, string heureArrive, string heureDepart, string motif, string commentaires, string prescription, string quantite, string statut, string prevention, int id_eleve)
        {
            this.Id = id;
            this.Date = date;
            this.HeureArrive = heureArrive;
            this.HeureDepart = heureDepart;
            this.Motif = motif;
            this.Commentaires = commentaires;
            this.Prescription = prescription;
            this.Quantite = quantite;
            this.Statut = statut;
            this.Prevention = prevention;
            this.Id_eleve = id_eleve;
        }

        // constructeur utilisé pour afficher les données des visites
        public Visite(DateTime date, string heureArrive, string heureDepart, string motif, string commentaires, string prescription, string quantite, string statut, string prevention, int id_eleve)
        {
            this.Date = date;
            this.HeureArrive = heureArrive;
            this.HeureDepart = heureDepart;
            this.Motif = motif;
            this.Commentaires = commentaires;
            this.Prescription = prescription;
            this.Quantite = quantite;
            this.Statut = statut;
            this.Prevention = prevention;
            this.Id_eleve = id_eleve;
        }

        // Setters et getters
        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string HeureArrive { get => heureArrive; set => heureArrive = value; }
        public string HeureDepart { get => heureDepart; set => heureDepart = value; }
        public string Motif { get => motif; set => motif = value; }
        public string Commentaires { get => commentaires; set => commentaires = value; }
        public string Prescription { get => prescription; set => prescription = value; }
        public string Quantite { get => quantite; set => quantite = value; }
        public string Statut { get => statut; set => statut = value; }
        public string Prevention { get => prevention; set => prevention = value; }
        public int Id_eleve { get => id_eleve; set => id_eleve = value; }
    }
}
