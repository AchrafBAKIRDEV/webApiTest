using DataBaseAccess.Models;

namespace DataBaseAccess.IService
{
    public interface IServiceTeam
    {
        decimal? CalculMoyenneDeuxEtudiant(Etudiant e1, Etudiant e2);
        string Affiche(decimal? moyenne);
    }
}
