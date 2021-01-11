namespace Book_Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bookstableadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        author = c.String(),
                        description = c.String(),
                        price = c.Single(nullable: false),
                        category = c.String(),
                        coverImage = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
