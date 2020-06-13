using CleaningProducts.Core.Entities;
using System.Collections.Generic;

namespace CleaningProducts.Core.Interfaces
{
	public interface ISupplierRepository
	{
		Supplier AddSupplier(Supplier supplier);
		List<Supplier> GetSuppliers(string CompnanyName);
	}
}
