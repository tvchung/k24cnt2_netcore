using Microsoft.AspNetCore.Mvc;
using TvcLesson03.Models;

namespace TvcLesson03.Controllers
{
    [Route("/danh-sach-san-pham")]
    public class TvcProductController : Controller
    {
        // Mock data
        private readonly List<TvcProduct> _products = new()
        {
            new TvcProduct
            {
                TvcProductId = "TVC-MB-001",
                TvcProductName = "iPhone 15 Pro Max 256GB",
                TvcYearRelease = 2023,
                TvcPrice = 29990000m
            },
            new TvcProduct
            {
                TvcProductId = "TVC-MB-002",
                TvcProductName = "Samsung Galaxy S24 Ultra 512GB",
                TvcYearRelease = 2024,
                TvcPrice = 31490000m
            },
            new TvcProduct
            {
                TvcProductId = "TVC-MB-003",
                TvcProductName = "Xiaomi 14 Ultra 5G",
                TvcYearRelease = 2024,
                TvcPrice = 27990000m
            },
            new TvcProduct
            {
                TvcProductId = "TVC-MB-004",
                TvcProductName = "Google Pixel 8 Pro 128GB",
                TvcYearRelease = 2023,
                TvcPrice = 21500000m
            },
            new TvcProduct
            {
                TvcProductId = "TVC-MB-005",
                TvcProductName = "OPPO Find N3 Flip 256GB",
                TvcYearRelease = 2023,
                TvcPrice = 19990000m
            },
            new TvcProduct
            {
                TvcProductId = "TVC-MB-006",
                TvcProductName = "Samsung Galaxy Z Fold5 512GB",
                TvcYearRelease = 2023,
                TvcPrice = 34990000m
            },
            new TvcProduct
            {
                TvcProductId = "TVC-MB-007",
                TvcProductName = "iPad Pro M4 11-inch Wi-Fi 256GB",
                TvcYearRelease = 2024,
                TvcPrice = 28990000m
            },
            new TvcProduct
            {
                TvcProductId = "TVC-MB-008",
                TvcProductName = "Samsung Galaxy Tab S9 Ultra",
                TvcYearRelease = 2023,
                TvcPrice = 25490000m
            },
            new TvcProduct
            {
                TvcProductId = "TVC-MB-009",
                TvcProductName = "ASUS ROG Phone 8 Pro 512GB",
                TvcYearRelease = 2024,
                TvcPrice = 28490000m
            },
            new TvcProduct
            {
                TvcProductId = "TVC-MB-010",
                TvcProductName = "Vivo X100 Pro 5G 256GB",
                TvcYearRelease = 2024,
                TvcPrice = 22990000m
            }
        };
        public IActionResult Index()
        {
            return Json(_products);
        }

        // Collection => view
        [Route("/all")]
        public IActionResult TvcGetAllProduct()
        {
            ViewData["products"] = _products;
            return View();
        }
    }
}
