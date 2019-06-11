namespace Vitty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateColumnNumberInStockTableMovie : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Movies DROP COLUMN NumberInStock");
            Sql("ALTER TABLE Movies ADD NumberInStock TINYINT");
        }
        
        public override void Down()
        {
            
        }
    }
}
