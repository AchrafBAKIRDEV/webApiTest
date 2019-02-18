using System;
using System.ComponentModel.DataAnnotations;

namespace AchrafApi.Models
{
    public class Rencontre
    {
        public int Id { get; set; }

        [Required]
        public string Libelle { get; set; }

        [Required]
        public DateTime Rdv { get; set; }

        [Required]
        public string Adresse { get; set; }
        public string Commentaire { get; set; }
    }
}