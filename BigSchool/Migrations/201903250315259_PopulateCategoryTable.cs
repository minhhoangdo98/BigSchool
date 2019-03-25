namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORY (ID, NAME) VALUE (1, 'Development')");
            Sql("INSERT INTO CATEGORY (ID, NAME) VALUE (2, 'Business')");
            Sql("INSERT INTO CATEGORY (ID, NAME) VALUE (3, 'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
