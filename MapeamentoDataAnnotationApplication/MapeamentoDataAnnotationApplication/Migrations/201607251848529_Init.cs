namespace MapeamentoDataAnnotationApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        CidadeId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.CidadeId);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        PessoaId = c.Int(nullable: false, identity: true),
                        CidadeNatalId = c.Int(nullable: false),
                        CidadeAtualId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PessoaId)
                .ForeignKey("dbo.Cidades", t => t.CidadeAtualId, cascadeDelete: true)
                .ForeignKey("dbo.Cidades", t => t.CidadeNatalId, cascadeDelete: true)
                .Index(t => t.CidadeNatalId)
                .Index(t => t.CidadeAtualId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pessoas", "CidadeNatalId", "dbo.Cidades");
            DropForeignKey("dbo.Pessoas", "CidadeAtualId", "dbo.Cidades");
            DropIndex("dbo.Pessoas", new[] { "CidadeAtualId" });
            DropIndex("dbo.Pessoas", new[] { "CidadeNatalId" });
            DropTable("dbo.Pessoas");
            DropTable("dbo.Cidades");
        }
    }
}
