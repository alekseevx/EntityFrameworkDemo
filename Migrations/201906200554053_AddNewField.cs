namespace EntityFrameworkDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "NewField", c => c.String(maxLength: 2000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "NewField");
        }
    }
}
