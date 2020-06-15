namespace WebProject01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, CATENAME) VALUES (1, 'Burger')");
            Sql("INSERT INTO CATEGORIES (ID, CATENAME) VALUES (2, 'Combo')");
            Sql("INSERT INTO CATEGORIES (ID, CATENAME) VALUES (3, 'Chicken')");
            Sql("INSERT INTO CATEGORIES (ID, CATENAME) VALUES (4, 'Rice')");
            Sql("INSERT INTO CATEGORIES (ID, CATENAME) VALUES (5, 'Snack')");
            Sql("INSERT INTO CATEGORIES (ID, CATENAME) VALUES (6, 'Drink')");
        }
        
        public override void Down()
        {
        }
    }
}
