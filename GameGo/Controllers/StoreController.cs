using GameGo.Models;
using GameGo.Models.StoreModels;
using GameGo.Service;
using Microsoft.AspNet.Identity;
using System;
using System.Web.Mvc;

namespace GameGo.Controllers
{
    [Authorize]
    public class StoreController : Controller
    {
        private readonly Lazy<StoreService> _svc;

        public StoreController()
        {
            _svc =
                new Lazy<StoreService>(
                    () =>
                    {
                        var userId = Guid.Parse(User.Identity.GetUserId());
                        return new StoreService(userId);
                    }
                );
        }
        public ActionResult Index()
        {
            var Stores = _svc.Value.GetStores();

            return View(Stores);
        }

        public ActionResult Create()
        {
            var vm = new StoreCreateViewModel();

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StoreCreateViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            if (!_svc.Value.CreateStore(vm))
            {
                ModelState.AddModelError("", "Unable to create Store");
                return View(vm);
            }

            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var vm = _svc.Value.GetStoreById(id);

            return View(vm);
        }

        public ActionResult Edit(int id)
        {
            var vm = _svc.Value.GetStoreById(id);

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StoreDetailViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            if (!_svc.Value.UpdateStore(vm))
            {
                ModelState.AddModelError("", "Unable to update Store");
                return View(vm);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public ActionResult DeleteGet(int id)
        {
            var vm = _svc.Value.GetStoreById(id);

            return View(vm);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            _svc.Value.DeleteStore(id);

            return RedirectToAction("Index");
        }
    }
}