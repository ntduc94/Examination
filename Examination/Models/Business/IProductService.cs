using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Examination.Models.Data;
using Examination.Models.View;

namespace Examination.Models.Business
{
	public interface IProductService
	{
		List<Product> GetProducts();
		void AddProduct(CreateProductView formData);
		Product GetProductById(int id);
		void UpdateProductById(int id, EditProductView formData);
		void DeleteProductById(int id);
	}
}