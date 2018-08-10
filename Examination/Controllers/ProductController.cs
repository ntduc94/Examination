using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Examination.Models.Business;
using Examination.Models.Data;
using Examination.Models.View;

namespace Examination.Controllers
{
    public class ProductController : Controller
    {
	    private readonly IProductService _productService;

	    public ProductController()
	    {
		    _productService = new ProductService();
	    }
        // GET: Product
        public ActionResult Index()
        {
	        try
	        {
		        var products = _productService.GetProducts();
		        var productsView = Mapper.Map<List<ListProductView>>(products);
		        return View(productsView);
	        }
	        catch (Exception e)
	        {
		        Console.WriteLine(e);
		        throw;
	        }
        }

        // GET: Product/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Product/Create
        public ActionResult Create()
        {
            return View(new CreateProductView());
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(CreateProductView formData)
        {
            try
            {
                _productService.AddProduct(formData);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
	        try
	        {
		        return View(Mapper.Map<EditProductView>(_productService.GetProductById(id)));
	        }
	        catch (Exception e)
	        {
		        Console.WriteLine(e);
		        throw;
	        }
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EditProductView formData)
        {
            try
            {
                _productService.UpdateProductById(id, formData);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Mapper.Map<DeleteProductView>(_productService.GetProductById(id)));
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, DeleteProductView viewData)
        {
            try
            {
                _productService.DeleteProductById(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
