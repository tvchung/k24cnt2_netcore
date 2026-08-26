using Microsoft.AspNetCore.Mvc;
using TvcLesson02Theory.Models;

namespace TvcLesson02Theory.Controllers
{
    public class TvcProductController : Controller
    {
        public IActionResult TvcIndex()
        {
            // Dữ liệu lưu trong đối  tượng: ViewBag, ViewData, TempData
            ViewBag.name = "Trịnh Văn Chung";
            ViewData["productVD"] = "Laptop Dell Vostro";
            TempData["UNI"] = "Trường Đại học Nguyễn Trãi - NTU";

            return View();
        }

        public IActionResult GetProduct()
        {
            // Tạo mock data product
            TvcProduct tvcProduct = new TvcProduct()
            {
                ProductID = "2400012323",
                ProductName = "Trịnh Văn Chung",
                YearRelease=1979,
                Price = 1000
            };

            ViewBag.product = tvcProduct;
            ViewData["product"] = tvcProduct;

            return View("product");
        }
    }
}
