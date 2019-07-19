namespace Vitty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NIF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "NIF", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "NIF");
        }
    }
}
