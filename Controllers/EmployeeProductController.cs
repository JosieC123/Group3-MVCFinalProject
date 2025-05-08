using Microsoft.AspNetCore.Mvc;

public class EmployeeProductController : Controller
{
  // this controller depends on the NorthwindRepository
  private DataContext _dataContext;
  public EmployeeProductController(DataContext db) => _dataContext = db;
  public IActionResult Category() => View(_dataContext.Categories.OrderBy(c => c.CategoryName));
  public IActionResult Index(int id){
    ViewBag.id = id;
    return View(_dataContext.Categories.OrderBy(c => c.CategoryName));
  }
}