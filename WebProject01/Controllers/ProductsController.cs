using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProject01.Models;
using WebProject01.ViewModels;

namespace WebProject01.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _dbContext;
        public ProductsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpGet]
        // GET: Products
        public ActionResult Create()
        {
            var viewModel = new ProductViewModel
            {
                Categories = _dbContext.Categories.ToList(),
                Heading = "Thêm sản phẩm"
            };
            return View("Create", viewModel);
        }

        
        [HttpPost]
        [Authorize(Roles = "ADMIN")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel viewModel)
        {
            //if (!ModelState.IsValid)
            //{
            //    viewModel.Categories = _dbContext.Categories.ToList();
            //    return View("Create", viewModel);
            //}
            if(ModelState.IsValid){
                var product = new Product();

                product.Id = viewModel.Id;
                product.ProdName = viewModel.ProdName;
                product.ProdImg = viewModel.ProdImg;
                product.ProdDes = viewModel.ProdDes;
                product.ProdPrice = viewModel.ProdPrice;
                product.CategoryId = viewModel.Category;

                _dbContext.Products.Add(product);
                _dbContext.SaveChanges();
            }
            else
            {
                return HttpNotFound();
            }

            return RedirectToAction("Create", "Products");
        }

        public ActionResult Menu()
        {
            var product = _dbContext.Products;

            return View(product);
        }

        public ActionResult EditDelete()
        {
            var product = _dbContext.Products;

            return View(product);
        }
        
        public ActionResult Edit(int id)
        {
            var product = _dbContext.Products.Single(c => c.Id == id);

            var viewModel = new ProductViewModel
            {
                Categories = _dbContext.Categories.ToList(),
                ProdName = product.ProdName,
                ProdDes = product.ProdDes,
                ProdImg = product.ProdImg,
                ProdPrice = product.ProdPrice,
                Category = product.CategoryId,
                Heading = "Sửa sản phẩm",
                Id = product.Id
            };
            return View("Create", viewModel);
        }

        [Authorize(Roles = "ADMIN")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(ProductViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Categories = _dbContext.Categories.ToList();
                return View("Create", viewModel);
            }
            var product = _dbContext.Products.Single(c => c.Id == viewModel.Id);

            product.ProdName = viewModel.ProdName;
            product.ProdDes = viewModel.ProdDes;
            product.ProdImg = viewModel.ProdImg;
            product.ProdPrice = viewModel.ProdPrice;
            product.CategoryId = viewModel.Category;

            _dbContext.SaveChanges();

            return RedirectToAction("EditDelete", "Products");
        }

        [Authorize(Roles = "ADMIN")]
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var product = _dbContext.Products.Single(c => c.Id == id);
            if (product == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();

            return RedirectToAction("EditDelete", "Products");
        }
    }
}