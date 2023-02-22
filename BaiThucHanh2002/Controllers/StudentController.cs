using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh2002.Models;
namespace BaiThucHanh2002.Controllers
{
    public class StudentController : Controller  
    {
         public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
     }

}
