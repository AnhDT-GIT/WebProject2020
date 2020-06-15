namespace WebProject01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateActionProductViewModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductViewModels", "Heading", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductViewModels", "Heading");
        }
    }
}
