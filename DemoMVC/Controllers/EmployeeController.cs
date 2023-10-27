using System.Reflection.PortableExecutable;
using System.Net;using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers;
public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Index(string personID,string Fullname,string Luong)
    {
        string ps = personID + "-" + Fullname + "-" + Luong;
        
         ViewBag.abc =ps;
        return View();
        
    }

}