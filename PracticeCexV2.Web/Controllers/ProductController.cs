using PracticeCexV2.Web.DbContexts;
using PracticeCexV2.Web.DomainModels;
using PracticeCexV2.Web.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace PracticeCexV2.Web.Controllers
{
    public class ProductController : Controller
    {

        private PracticeCexV2DbContext _context = new PracticeCexV2DbContext();
        // GET: Product
        public ActionResult Index()
        {
            var viewModel = _context.Products.Select(lmb => new ProductViewModel {
                ProductId = lmb.ProductId,
                ProductName = lmb.ProductName,
                Quantity = lmb.Quantity
            });
            return View(viewModel);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                _context.Products.Add(new Product
                {
                    ProductName = collection["ProductName"].ToString(),
                    Quantity = Convert.ToDecimal(collection["Quantity"])
                });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(new ProductViewModel
                {
                    ProductId = Convert.ToInt32(collection["ProductId"]),
                    ProductName = collection["ProductName"],
                    Quantity = Convert.ToDecimal(collection["Quantity"])
                });
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
