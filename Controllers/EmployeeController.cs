using Group3_MVCFinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace Group3_MVCFinalProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Employee/Login
        [HttpPost]
        public IActionResult Login(EmployeeLogin model)
        {
            if (ModelState.IsValid)
            {
                // Dummy authentication logic (replace with actual database check)
                if (model.Email == "admin@example.com" && model.Password == "password123")
                {
                    TempData["Message"] = "Login successful!";
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid login credentials.");
            }

            return View(model);
        }

        // GET: Employee/Logout
        public IActionResult Logout()
        {
            TempData["Message"] = "You have been logged out.";
            return RedirectToAction("Login");
        }
    }
}