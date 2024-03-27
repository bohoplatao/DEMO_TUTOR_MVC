using DEMO_TUTOR_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DEMO_TUTOR_MVC.Controllers
{
    public class KhachHangController : Controller
    {
        DemoCode1stContext context;
        public KhachHangController()
        {
            context = new DemoCode1stContext();
        }
        // GET: KhachHangController
        public ActionResult Index()
        {
            var khachhangs = context.KhachHangs.ToList(); // lấy ra từ DB thông qua DBSet
            // truyền dữ liệu sang View 
            return View(khachhangs);
        }

        // GET: KhachHangController/Details/5
        public ActionResult Details(string sdt)
        {
            var khachhang = context.KhachHangs.ToList().FirstOrDefault(p => p.Sdt == sdt);
            return View(khachhang);
        }

        // GET: KhachHangController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KhachHangController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KhachHangController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KhachHangController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KhachHangController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KhachHangController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
