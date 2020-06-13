using CleaningProducts.Core.Entities;
using CleaningProducts.Core.Interfaces;
using System.Linq;
using System.Web.Http;

namespace CleaningProducts.API.Controllers
{
	public class SupplierController : ApiController
	{
		private readonly ISupplierRepository _supplierRepository;

		public SupplierController(ISupplierRepository supplierRepository)
		{
			_supplierRepository = supplierRepository;
		}

		[HttpGet]
		public IHttpActionResult GetSuppliers(string CompanyName = "")
		{
			var result = _supplierRepository.GetSuppliers(CompanyName).ToList();
			return Json(result);
		}

		[HttpPost]
		public IHttpActionResult Post(Supplier supplier)
		{
			var result = _supplierRepository.AddSupplier(supplier);
			return Json(result);
		}
	}
}
