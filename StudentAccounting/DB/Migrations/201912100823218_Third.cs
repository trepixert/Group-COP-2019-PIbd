namespace DB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "EntryDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "EntryDate", c => c.DateTime(nullable: false));
        }
    }
}
