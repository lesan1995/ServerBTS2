namespace ServerBTS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhaMangs", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NhaMangs", "Image");
        }
    }
}
