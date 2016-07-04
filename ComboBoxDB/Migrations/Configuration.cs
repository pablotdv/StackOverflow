namespace ComboBoxDB.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ComboBoxDB.Models.ComboBoxDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ComboBoxDB.Models.ComboBoxDBContext context)
        {
            context.ProdutoGrupos.AddOrUpdate(a => a.Descricao,
                new Models.ProdutoGrupo() { Descricao = "Grupo 1" },
                new Models.ProdutoGrupo() { Descricao = "Grupo 2" },
                new Models.ProdutoGrupo() { Descricao = "Grupo 3" },
                new Models.ProdutoGrupo() { Descricao = "Grupo 4" },
                new Models.ProdutoGrupo() { Descricao = "Grupo 5" });

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
        }
    }
}
