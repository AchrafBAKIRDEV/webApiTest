using DataBaseAccess.IService;
using DataBaseAccess.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace DataBaseAccess.Service
{
    public class ServiceEtudiant : IServiceEtudiant, IDisposable
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public List<Etudiant> GetEtudiantAll()
        {
            var etudiantList = new List<Etudiant>();
            etudiantList.Add(new Etudiant(1, "BAKIR", "Achraf", DateTime.Now, ""));
            etudiantList.Add(new Etudiant(2, "BAKIR", "Ahmed", DateTime.Now, ""));
            etudiantList.Add(new Etudiant(5, "BAKIR", "Walid", DateTime.Now, ""));

            return etudiantList;
        }

        public Etudiant GetEtudiantById(int id)
        {
            var etudiantList = new List<Etudiant>();
            etudiantList.Add(new Etudiant(1, "BAKIR", "Achraf", DateTime.Now, ""));
            etudiantList.Add(new Etudiant(2, "BAKIR", "Ahmed", DateTime.Now, ""));
            etudiantList.Add(new Etudiant(5, "BAKIR", "Walid", DateTime.Now, ""));

            return etudiantList.FirstOrDefault(e => e.Id == id);
        }
    }
}
