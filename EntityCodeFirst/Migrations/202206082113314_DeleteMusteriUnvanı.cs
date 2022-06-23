namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteMusteriUnvanı : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Musteris", "MusteriUnvani");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Musteris", "MusteriUnvani", c => c.String());
        }
    }
}
