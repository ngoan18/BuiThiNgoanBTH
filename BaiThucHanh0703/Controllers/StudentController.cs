using Microsoft.AspNetCore.Mvc;
namespace BaiThucHanh0703.Controllers
{
    public class Controllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GiaiPhuongTrinhBac2(string hesoA, string hesoB, string hesoC)
        {
            double delta, x1, x2, a = 0, b = 0, c = 0;
            string ketqua;
            if(!string.IsNullOrEmpty(hesoA)) a = Convert.ToDouble(hesoA);
            if(!string.IsNullOrEmpty(hesoB)) b = Convert.ToDouble(hesoB);
            if(!string.IsNullOrEmpty(hesoC)) c = Convert.ToDouble(hesoC);
            if(a == 0) ketqua = "Khong phai phuong trinh bac 2";
            else
            {
                delta = b * b - 4 * a * c;
                if(delta < 0 ) ket qua = " Phuong Trinh Vo Nghiem";
                else if(delta == 0)
                {
                    x1 = -b/(2*a);
                    ketqua = "Phuong trinh co nghiem kep = " + x1;
                }
                else
                {
                    x1 = (-b + Math.sqrt(delta))/(2*a);
                    x2 = (-b - Math.sqrt(delta))/(2*a);
                    ketqua = "Phuong trinh co 2 nghiem phan biet : X1 = " + x1 + ", X2 = " + x2;
                }
            }

            ViewBag.Message = ketqua;
            return View()        
        }

    }
}
   
    