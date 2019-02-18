using DataBaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAccess.IService
{
    public interface IServiceEtudiant
    {
        Etudiant GetEtudiantById(int id);
        List<Etudiant> GetEtudiantAll();
     }
}
