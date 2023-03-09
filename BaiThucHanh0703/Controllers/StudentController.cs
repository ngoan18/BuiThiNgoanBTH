using Microsoft.AspNetCore.Mvc;
namespace BaiThucHanh0703.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    [HttpPost]
    public IActionResult Index(String FullName)
    {
        string strResult = "Hello" + FullName;
        ViewBag.message = strResult;
        return View();
    }
    public IActionResult GiaiPhuongTrinhBac2()
    {
        return View();
    }
    [HttpPost]
    public IActionResult GiaiPhuongTrinhBac2(String hesoA, String hesoB, String hesoC)
    {
        double delta, x1, x2, a = 0, b = 0, c = 0;
        string ketqua;

        if(!String.IsNullOrEmpty(hesoA)) a= Convert.ToDouble(hesoA);
        if(!String.IsNullOrEmpty(hesoB)) b= Convert.ToDouble(hesoB);
        if(!String.IsNullOrEmpty(hesoC)) c= Convert.ToDouble(hesoC);
        if(a == 0) ketqua = "Khong phai la phuowng trinh bac 2";
        else
        {
            delta = Math.Pow(b,2) - 4 * a * c;
            if (delta < 0) ketqua = "Phuong trinh vo nghiem";
            else if (delta == 0)
            {
                x1 = -b/(2*a);
                ketqua = "Phuong trinh co nghiem kep = " + x1;
                
            }
            else 
            {
                x1 = (-b + Math.Sprt(delta))/(2*a);
                x1 = (-b - Math.Sprt(delta))/(2*a);
                ketqua = "Phuong trinh co hai nghiem phan biet: X1 = " + x1", X2 = " + x2;

            }
        }
        ViewBag.message = ketqua;
        return View();
    }

    }
}