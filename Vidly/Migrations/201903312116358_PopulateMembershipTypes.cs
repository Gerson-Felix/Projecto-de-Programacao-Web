namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscuntRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscuntRate) VALUES (2, 300, 1, 100)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscuntRate) VALUES (3, 900, 3, 150)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscuntRate) VALUES (4, 3000, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
