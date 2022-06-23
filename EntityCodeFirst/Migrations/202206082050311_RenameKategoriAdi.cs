namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameKategoriAdi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriAdi", c => c.String());
            Sql("Update Kategoris set KategoriAdi=KategoriIsmi");//sql sorgu yazdım
            DropColumn("dbo.Kategoris", "KategoriIsmi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "KategoriIsmi", c => c.String());
            Sql("Update Kategoris set KategoriIsmi=KategoriAdi");//sql sorgu yazdım.
            DropColumn("dbo.Kategoris", "KategoriAdi");
        }
    }
}
