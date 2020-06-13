using CleaningProducts.Core.Entities;
using CleaningProducts.Core.Interfaces;
using CleaningProducts.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace CleaningProducts.Repository.Suppliers
{
	public class SupplierRepository : ISupplierRepository
	{
		private readonly CleaningProductsContext _context;

		public SupplierRepository(CleaningProductsContext context)
		{
			_context = context;
		}
		public Supplier AddSupplier(Supplier supplier)
		{
			_context.Suppliers.Add(supplier);
			_context.SaveChanges();
			return supplier;
		}

		public List<Supplier> GetSuppliers(string CompanyName)
		{
			return string.IsNullOrEmpty(CompanyName) ? _context.Suppliers.ToList() : _context.Suppliers.Where(s => s.Name.Contains(CompanyName)).ToList();
		}

	}
}
