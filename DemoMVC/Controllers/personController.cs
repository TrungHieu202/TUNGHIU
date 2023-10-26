using System.Reflection.PortableExecutable;
using System.Net;using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers;
public class personController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Index(string personID,string Fullname)
    {
        string ps = personID + "-" + Fullname;
        
         ViewBag.capnhat =ps;
        return View();
        
    }

}

