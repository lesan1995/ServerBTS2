namespace ServerBTS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trams", "SanTram", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trams", "SanTram");
        }
    }
}
