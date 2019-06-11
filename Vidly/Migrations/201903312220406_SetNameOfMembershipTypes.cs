namespace Vitty.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNameOfMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pagar e Ir' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Por mês' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Trimestral' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Anual' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
