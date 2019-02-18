using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DataBaseAccess.Models;
using DataBaseAccess.IService;
using DataBaseAccess.Service;

namespace AchrafApi.Test
{
    [TestClass]
    public class TeamTest
    {
        [TestMethod]
        public void Return_five_when_Moyenne_e1_3_and_Moyenne_e2_2()
        {
            var e1 = new Etudiant(1, "Achraf", "BAKIR", 17);
            var e2 = new Etudiant(1, "Walid", "BAKIR", 18);
            var serviceTeamMock = Mock.Of<IServiceTeam>();
            Mock.Get(serviceTeamMock).Setup(serv => serv.CalculMoyenneDeuxEtudiant(e1, e2)).Returns(10);
            var service = new ServiceTeam();
            string aff = service.Affiche(serviceTeamMock.CalculMoyenneDeuxEtudiant(e1, e2));
            Assert.AreEqual("Moy is: 10", aff);


            var ss = Mock.Of<IServiceTeam>();
            Mock.Get(ss).Setup(d => d.CalculMoyenneDeuxEtudiant(e1, e2)).Returns(10);
        }
    }
}
 