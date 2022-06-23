namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MusteriTablosuMusteriSehriSütun : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "MusteriSehri", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musteris", "MusteriSehri");
        }
    }
}
