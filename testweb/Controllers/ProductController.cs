using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using testweb.Models;

namespace testweb.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepository;


        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        public void changeOrigin(int id)
        {
          //  this.productRepository = new ProductRepository(new StoreContext());
            //this.productRepository = new ProductRepository(new StoreMemContext());
        }





       

        // GET: Product
        public IActionResult Index()
        {
            return View  (productRepository.GetProducts());
        }

        // GET: Product/Details/5
        public IActionResult Details(int id)
        {
            var product =  productRepository.GetProductByID(id);
              
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            ViewData["categoryid"] = new SelectList(productRepository.GetCategories(), "id" ,"name");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?Linkid=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("id,name,price,categoryid")] Product product)
        {
            if (ModelState.IsValid)
            {
                productRepository.InsertProduct(product);
                productRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            ViewData["categoryid"] = new SelectList(productRepository.GetCategories(), "id", "name", product.id);
            return RedirectToAction("Index");
        }

    
    }
}
