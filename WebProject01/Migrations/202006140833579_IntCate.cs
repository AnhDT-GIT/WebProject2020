namespace WebProject01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntCate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryId" });
            AddColumn("dbo.Products", "Category_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductViewModels", "Category", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "Category_Id");
            AddForeignKey("dbo.Products", "Category_Id", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Category_Id" });
            AlterColumn("dbo.ProductViewModels", "Category", c => c.Byte(nullable: false));
            AlterColumn("dbo.Products", "CategoryId", c => c.Byte(nullable: false));
            DropColumn("dbo.Products", "Category_Id");
            CreateIndex("dbo.Products", "CategoryId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
