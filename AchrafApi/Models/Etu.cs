using System;
using System.ComponentModel.DataAnnotations;

namespace AchrafApi.Models
{
    public class Etu
    {
        public int Id { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        [Required]
        public DateTime Age { get; set; }

        public string Universite { get; set; }
        public string Commentaire { get; set; }

        public Etu(int id, string nom, string prenom, DateTime age, string commentaire)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Commentaire = commentaire;
        }
    }
}