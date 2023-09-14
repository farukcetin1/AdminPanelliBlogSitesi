namespace KisiselSayfa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyNewMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "kulAdi", c => c.String());
            AddColumn("dbo.Admins", "sifre", c => c.String());
            DropColumn("dbo.Admins", "username");
            DropColumn("dbo.Admins", "password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "password", c => c.String());
            AddColumn("dbo.Admins", "username", c => c.String());
            DropColumn("dbo.Admins", "sifre");
            DropColumn("dbo.Admins", "kulAdi");
        }
    }
}
