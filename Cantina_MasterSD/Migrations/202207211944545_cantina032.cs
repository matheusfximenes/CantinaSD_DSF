namespace Cantina_MasterSD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class cantina032 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Quentinhas",
                c => new
                {
                    QuentinhaId = c.Int(nullable: false, identity: true),
                })
                .PrimaryKey(t => t.QuentinhaId);

        }

        public override void Down()
        {
            DropTable("dbo.Quentinhas");
        }
    }
}
