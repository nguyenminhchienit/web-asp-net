using Microsoft.AspNetCore.Mvc;
using TakisShop.Data;
using TakisShop.Helpers;
using TakisShop.ViewModels;

namespace TakisShop.Controllers
{
    public class CartController : Controller
    {
        private readonly TakisShopContext _context;

        public CartController(TakisShopContext context) { 
            _context = context;
        }
       

        const string CART_KEY = "MYCART";
        public List<CartItemVM> Carts => HttpContext.Session.Get<List<CartItemVM>>(CART_KEY) 
            ?? new List<CartItemVM>();

        public IActionResult Index()
        {
            return View(Carts);
        }
        public IActionResult AddToCart(int id, int quantity = 1)
        {
            var gioHang = Carts;
            var item = gioHang.SingleOrDefault(p => p.MaHH == id);
            if (item == null)
            {
                var product = _context.HangHoas.FirstOrDefault(p => p.MaHh == id);
                if(product == null)
                {
                    return Redirect("/not-found");
                }
                item = new CartItemVM
                {
                    MaHH = product.MaHh,
                    Hinh = product.Hinh ?? string.Empty,
                    TenHH = product.TenHh,
                    DonGia = product.DonGia ?? 0,
                    SoLuong = quantity
                };
                gioHang.Add(item);
            }
            else
            {
                item.SoLuong += quantity;
            }
            HttpContext.Session.Set(CART_KEY, gioHang);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveToCart (int id)
        {
            var gioHang = Carts;
            var item = gioHang.SingleOrDefault(p => p.MaHH == id); 
            if(item != null)
            {
                gioHang.Remove(item);
            }
            HttpContext.Session.Set(CART_KEY, gioHang);
            return RedirectToAction("Index");
        }
    }
}
