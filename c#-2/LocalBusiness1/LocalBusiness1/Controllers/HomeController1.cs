using LocalBusiness1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LocalBusiness1.Controllers
{
    public class HomeController1 : Controller
    {
        private readonly LocalBussinessdfaContext _context;

        public HomeController1(LocalBussinessdfaContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Users2 objUser)
        {
            if (ModelState.IsValid)
            {
                var obj = _context.Users2s.Where(a => a.Email.Equals(objUser.Email) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                if (obj != null)
                {
                    ViewData["Email"] = obj.Email.ToString();
                    ViewData["Password"] = obj.Password.ToString();
                    return RedirectToAction(nameof(UserDashBoard));

                }


            }
            return RedirectToAction(nameof(UserDashBoard));
        }
        public ActionResult UserDashBoard()
        {
            if (ViewData["Email"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}
