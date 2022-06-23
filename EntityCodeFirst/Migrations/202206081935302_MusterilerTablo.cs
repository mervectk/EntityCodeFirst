﻿namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MusterilerTablo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        MusteriID = c.Int(nullable: false, identity: true),
                        MusteriAdi = c.String(),
                        MusteriSoyadi = c.String(),
                    })
                .PrimaryKey(t => t.MusteriID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Musteris");
        }
    }
}
