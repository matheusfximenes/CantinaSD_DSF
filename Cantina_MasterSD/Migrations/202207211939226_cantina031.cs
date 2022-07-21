namespace Cantina_MasterSD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cantina031 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        PedidoId = c.Int(nullable: false, identity: true),
                        cliente_IdCliente = c.Int(),
                    })
                .PrimaryKey(t => t.PedidoId)
                .ForeignKey("dbo.Clientes", t => t.cliente_IdCliente)
                .Index(t => t.cliente_IdCliente);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedidoes", "cliente_IdCliente", "dbo.Clientes");
            DropIndex("dbo.Pedidoes", new[] { "cliente_IdCliente" });
            DropTable("dbo.Produtoes");
            DropTable("dbo.Pedidoes");
        }
    }
}
