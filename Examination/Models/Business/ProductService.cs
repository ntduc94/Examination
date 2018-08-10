using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AutoMapper;
using Examination.DAL;
using Examination.Models.Data;
using Examination.Models.View;

namespace Examination.Models.Business
{
	public class ProductService : IProductService
	{
		private readonly ExamContext _db;

		public ProductService()
		{
			_db = new ExamContext();
		}
		public List<Product> GetProducts()
		{
			return _db.Products.ToList();
		}

		public void AddProduct(CreateProductView formData)
		{
			var product = Mapper.Map<Product>(formData);
			product.CreatedAt  = DateTime.Now;
			product.UpdatedAt  = DateTime.Now;

			_db.Products.Add(product);
			_db.SaveChanges();
		}

		public Product GetProductById(int id)
		{
			return _db.Products.Find(id);
		}

		public void UpdateProductById(int id, EditProductView formData)
		{
			var product = _db.Products.Find(id);
			if (product == null) return;
			product.Name = formData.Name;
			product.ImportAt = formData.ImportAt;
			product.Price = formData.Price;
			product.Stock = formData.Stock;
			product.UpdatedAt = DateTime.Now;

			try
			{
				_db.Products.Attach(product);
				_db.Entry(product).State = EntityState.Modified;
				_db.SaveChanges();
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public void DeleteProductById(int id)
		{
			var product = _db.Products.Find(id);
			if (product == null) return;
			try
			{
				_db.Entry(product).State = EntityState.Deleted;
				_db.SaveChanges();
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}