using Franken_.Model.Entities;

namespace Franken_.Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class FrankenDatabase : DbContext
    {
        // Your context has been configured to use a 'FrankenDatabase' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Franken_.Model.FrankenDatabase' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'FrankenDatabase' 
        // connection string in the application configuration file.
        public FrankenDatabase()
            : base("name=FrankenDatabase")
        {
        }

        public virtual DbSet<Statistic> Statistics { get; set; }

        public virtual DbSet<UsedImage> UsedImages { get; set; }
    }
}