namespace VentasAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimerVersion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Apellidos = c.String(),
                        Nombres = c.String(),
                        Direccion = c.String(),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        ProductoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.ProductoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Productoes");
            DropTable("dbo.Clientes");
        }
    }
}
