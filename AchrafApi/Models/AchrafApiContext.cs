using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AchrafApi.Models
{
    public class AchrafApiContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public AchrafApiContext() : base("name=AchrafApiContext")
        {
        }

        public System.Data.Entity.DbSet<DataBaseAccess.Models.Etudiant> Etudiants { get; set; }

        public System.Data.Entity.DbSet<AchrafApi.Models.Rencontre> Rencontres { get; set; }
    }
}
