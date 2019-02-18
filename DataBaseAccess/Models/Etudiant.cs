using System;
namespace DataBaseAccess.Models
{
    public class Etudiant 
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Age { get; set; }
        public string Universite { get; set; }
        public string Commentaire { get; set; }
        public decimal? Moyenne { get; set; }

        public Etudiant(int id, string nom, string prenom, decimal? moyenne)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Moyenne = moyenne;
        }
        public Etudiant(int id, string nom, string prenom, DateTime age, string commentaire)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Commentaire = commentaire;
        }
    }
}