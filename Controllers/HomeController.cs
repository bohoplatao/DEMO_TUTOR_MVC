using DEMO_TUTOR_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DEMO_TUTOR_MVC.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        // khai báo DBContext 
        DemoCode1stContext _context;
        public HomeController(ILogger<HomeController> logger)
        {
            //_logger = logger;
            _context = new DemoCode1stContext();
        }
        public IActionResult Login() // ACtion được dùng để mở View 
        {
                return View();
                
        }
        [HttpPost]
        public IActionResult Login(string email, string sdt) // ACtion này dùng để đăng nhập 
        {
            //Kiểm tra xem thông tin nhập vào có trù khớp với đối tượng nào trong DB ko?
            var account = _context.KhachHangs.ToList();// lấy ra all danh sách 
            // Lấy ra thông tin account theo thông tin nhập vào
            var acc= account.FirstOrDefault(p=>p.Email == email && p.Sdt == sdt);
            // kiểm tra xem có lấy được dữ liệu thật hay không?
            if (acc != null) // nếu lấy được <=> tài khoản lấy ra không null
            {
                TempData["login"] = email;
                return RedirectToAction("Index");
            }
            else // lấy ra bị null <=> không có tài khoản nào như thế cả 
            {
                
               
                return View(); // vẫn trả về View đó 
            }
            
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
