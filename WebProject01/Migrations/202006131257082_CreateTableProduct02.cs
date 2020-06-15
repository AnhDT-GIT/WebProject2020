namespace WebProject01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableProduct02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProdPrice", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProdPrice");
        }
    }
}
