namespace RelatoriosTags.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RelatoriosTags.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(RelatoriosTags.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.RelatoriosTags.AddOrUpdate(t => t.TagID,
                new Models.RelatorioTagModels { Tag = "P401-1E", Fluido = "Bagaço de Laranja", Vedacao = "Selo Simples Tipo 216...", Criticidade = "4", Mtbf = 2 },
                new Models.RelatorioTagModels { Tag = "P804-4B", Fluido = "Bagaço de Laranja", Vedacao = "Selo Simples Tipo 216...", Criticidade = "4", Mtbf = 2 }
                );
        }
    }
}
