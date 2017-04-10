namespace WebApplication6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Droids",
                c => new
                    {
                        DroidName = c.String(nullable: false, maxLength: 128),
                        DroidClass = c.String(),
                        Accuracy = c.Int(nullable: false),
                        MovementRating = c.Int(nullable: false),
                        RequiresLevel5ProgrammingAbility = c.Boolean(nullable: false),
                        ReviewofDroid = c.String(),
                    })
                .PrimaryKey(t => t.DroidName);
            
            CreateTable(
                "dbo.LightSabers",
                c => new
                    {
                        AvailableForDarksideOnly = c.Boolean(nullable: false),
                        SaberType = c.String(),
                        SaberColor = c.String(),
                        SaberLength = c.Int(nullable: false),
                        LightSaberReview = c.String(),
                    })
                .PrimaryKey(t => t.AvailableForDarksideOnly);
            
            CreateTable(
                "dbo.Ships",
                c => new
                    {
                        ShipName = c.String(nullable: false, maxLength: 128),
                        ShipType = c.String(),
                        MainWeapons = c.String(),
                        SecondaryWeapons = c.String(),
                        EquippedWithShield = c.Boolean(nullable: false),
                        ShipReview = c.String(),
                    })
                .PrimaryKey(t => t.ShipName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ships");
            DropTable("dbo.LightSabers");
            DropTable("dbo.Droids");
        }
    }
}
