namespace Cantina_MasterSD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cantina033 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Pedidoes", new[] { "cliente_IdCliente" });
            AddColumn("dbo.Clientes", "Nome", c => c.String(nullable: false));
            AddColumn("dbo.Clientes", "Telefone", c => c.String(nullable: false));
            AddColumn("dbo.Clientes", "CpfCnpj", c => c.String(nullable: false));
            AddColumn("dbo.Clientes", "Endereco", c => c.String(nullable: false));
            AddColumn("dbo.Pedidoes", "Status", c => c.String());
            AddColumn("dbo.Pedidoes", "Preco", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Pedidoes", "Quentinha_QuentinhaId", c => c.Int());
            AddColumn("dbo.Quentinhas", "Nome", c => c.String(nullable: false));
            AddColumn("dbo.Quentinhas", "Descricao", c => c.String());
            AddColumn("dbo.Quentinhas", "Preco", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            CreateIndex("dbo.Pedidoes", "Cliente_IdCliente");
            CreateIndex("dbo.Pedidoes", "Quentinha_QuentinhaId");
            AddForeignKey("dbo.Pedidoes", "Quentinha_QuentinhaId", "dbo.Quentinhas", "QuentinhaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedidoes", "Quentinha_QuentinhaId", "dbo.Quentinhas");
            DropIndex("dbo.Pedidoes", new[] { "Quentinha_QuentinhaId" });
            DropIndex("dbo.Pedidoes", new[] { "Cliente_IdCliente" });
            DropColumn("dbo.Quentinhas", "Preco");
            DropColumn("dbo.Quentinhas", "Descricao");
            DropColumn("dbo.Quentinhas", "Nome");
            DropColumn("dbo.Pedidoes", "Quentinha_QuentinhaId");
            DropColumn("dbo.Pedidoes", "Preco");
            DropColumn("dbo.Pedidoes", "Status");
            DropColumn("dbo.Clientes", "Endereco");
            DropColumn("dbo.Clientes", "CpfCnpj");
            DropColumn("dbo.Clientes", "Telefone");
            DropColumn("dbo.Clientes", "Nome");
            CreateIndex("dbo.Pedidoes", "cliente_IdCliente");
        }
    }
}
