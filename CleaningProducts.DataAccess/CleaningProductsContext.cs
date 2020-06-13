using CleaningProducts.Core.Entities;
using System.Data.Entity;

namespace CleaningProducts.DataAccess
{
	public class CleaningProductsContext : DbContext
	{

		public CleaningProductsContext()
		 : base("name=CleaningProductsContext")
		{
		}
		public DbSet<Supplier> Suppliers { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
		}
	}
}
