namespace CleaningProducts.DataAccess.Migrations
{
	using System;
	using System.Data.Entity.Migrations;

	public partial class AddSupplierTable : DbMigration
	{
		public override void Up()
		{
			CreateTable(
					"dbo.Suppliers",
					c => new
					{
						Id = c.Int(nullable: false, identity: true),
						Code = c.String(),
						Name = c.String(),
						Telephone = c.String(),
					})
					.PrimaryKey(t => t.Id);

		}

		public override void Down()
		{
			DropTable("dbo.Suppliers");
		}
	}
}
