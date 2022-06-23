namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Urunlers",
                c => new
                    {
                        UrunID = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(),
                        UrunMarkasi = c.String(),
                        UrunKategorisi = c.String(),
                        UrunStok = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UrunID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Urunlers");
        }
    }
}
