namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameMusteriSoyadiMusteriUnvani : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "MusteriUnvani", c => c.String());
            DropColumn("dbo.Musteris", "MusteriSoyadi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musteris", "MusteriSoyadi", c => c.String());
            DropColumn("dbo.Musteris", "MusteriUnvani");
        }
    }
}
