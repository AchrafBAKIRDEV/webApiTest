using DataBaseAccess.IService;
using DataBaseAccess.Models;

namespace DataBaseAccess.Service
{
    public class ServiceTeam : IServiceTeam
    {
        public decimal? CalculMoyenneDeuxEtudiant(Etudiant e1, Etudiant e2)
        {
            return e1.Moyenne + e2.Moyenne;
        }

        public string Affiche(decimal? moyenne)
        {
            return "Moy is: " + moyenne;
        }
    }
}
