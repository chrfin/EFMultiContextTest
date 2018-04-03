namespace EFMultiContext.Plugin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PluginItems", "Author_Id", c => c.Int());
            CreateIndex("dbo.PluginItems", "Author_Id");
            AddForeignKey("dbo.PluginItems", "Author_Id", "dbo.Users", "Id");
        }

        public override void Down()
        {
            DropForeignKey("dbo.PluginItems", "Author_Id", "dbo.Users");
            DropIndex("dbo.PluginItems", new[] { "Author_Id" });
            DropColumn("dbo.PluginItems", "Author_Id");
        }
    }
}