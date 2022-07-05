namespace Minicore_Rivadeneira.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Minicore_Rivadeneira.Models.dbf62c9ea3413d4d87b292aec9009e0e71Entities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Minicore_Rivadeneira.Models.dbf62c9ea3413d4d87b292aec9009e0e71Entities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
