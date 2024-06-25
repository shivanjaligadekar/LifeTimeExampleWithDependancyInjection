using LifeTimeExampleWithDependancyInjection.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeTimeExampleWithDependancyInjection.Controllers
{
    public class SupplierController : Controller
    {
        private readonly ISupplierRepository _repository;
        public SupplierController(ISupplierRepository repository) 
        {
            _repository = repository;
        }
        // GET: SupplierController
        public ActionResult Index()
        {
            List<SupplierViewModel> list =_repository.GetSuppliers();
            return View(list);
        }

        // GET: SupplierController/Details/5
        public ActionResult Details(int id)
        {
            SupplierViewModel model = _repository.FindSupplier(id);
            return View(model);
        }

        // GET: SupplierController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SupplierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                SupplierViewModel viewModel = new SupplierViewModel();
                viewModel.SuppId = Convert.ToInt32(collection["SuppId"]);
                viewModel.SupplierName = collection["SupplierName"];
                viewModel.City = collection["City"];
                _repository.Insert(viewModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupplierController/Edit/5
        public ActionResult Edit(int id)
        {
            SupplierViewModel model = _repository.FindSupplier(id);
            return View(model);
        }

        // POST: SupplierController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Edit(int id, IFormCollection collection)
        {
            try
            {
                SupplierViewModel viewModel = new SupplierViewModel();
                viewModel.SuppId = Convert.ToInt32(collection["SuppId"]);
                viewModel.SupplierName = collection["SupplierName"];
                viewModel.City = collection["City"];
                _repository.Update(id, viewModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupplierController/Delete/5
        public ActionResult Delete(int id)
        {
            SupplierViewModel model= _repository.FindSupplier(id);
            return View(model);
        }

        // POST: SupplierController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _repository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
