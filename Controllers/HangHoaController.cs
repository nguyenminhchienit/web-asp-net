using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TakisShop.Data;
using TakisShop.ViewModels;

namespace TakisShop.Controllers
{
    public class HangHoaController : Controller
    {
        private readonly TakisShopContext _context;

        public HangHoaController(TakisShopContext context) {
            _context = context;
        }
        public IActionResult Index(int? loai)
        {
            var products = _context.HangHoas.AsQueryable();

            if (loai.HasValue)
            {
                products = products.Where(p => p.MaLoai == loai.Value);
            }

            var result = products.Select(p => new ProductViewModel
            {
                MaHH = p.MaHh,
                TenHH = p.TenHh,
                TenLoai = p.MaLoaiNavigation.TenLoai,
                DonGia = p.DonGia ?? 0,
                Hinh = p.Hinh ?? "",
                MoTa = p.MoTa ?? ""

            });
            return View(result);
        }

        public IActionResult Search(string? query)
        {
            var products = _context?.HangHoas.AsQueryable();
            if(query != null && products != null)
            {
                products = products.Where(p => p.TenHh.Contains(query));
            }
            var result = products.Select(p => new ProductViewModel
            {
                MaHH = p.MaHh,
                TenHH = p.TenHh,
                TenLoai = p.MaLoaiNavigation.TenLoai,
                DonGia = p.DonGia ?? 0,
                Hinh = p.Hinh ?? "",
                MoTa = p.MoTa ?? ""

            });
            return View(result);
        }

        public IActionResult Search2(string query)
        {
            // Start with the initial product query
            var products = _context.HangHoas.AsQueryable() ?? Enumerable.Empty<HangHoa>().AsQueryable();

            // Check if the query is not null or empty
            if (!string.IsNullOrEmpty(query))
            {
                products = products.Where(p => p.TenHh != null && p.TenHh.Contains(query));
            }

            // Select the relevant fields into a new ProductViewModel
            var result = products.Select(p => new ProductViewModel
            {
                MaHH = p.MaHh,
                TenHH = p.TenHh,
                TenLoai = p.MaLoaiNavigation != null ? p.MaLoaiNavigation.TenLoai : "", // Safe access
                DonGia = p.DonGia ?? 0,
                Hinh = p.Hinh ?? "",
                MoTa = p.MoTa ?? "" // Ensure MoTa is not null
            }).ToList();

            return View("Search",result);
        }

        public IActionResult Detail(int? mahh)
        {
            var product = _context.HangHoas
                .Include(p => p.MaLoaiNavigation).FirstOrDefault(p => p.MaHh == mahh);
            if(product == null)
            {
                return Redirect("/not-found");
            }
            return View(product);
        }
    }
}
