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
     public IActionResult Index(string fname,float hesoluong,float phucap,int luongcoban)
    {
        float tinhluong = luongcoban * hesoluong + phucap ;
        string tl = fname+ "-" + tinhluong;
        ViewBag.nhap = tl ;
        return View();
        
    }

}

