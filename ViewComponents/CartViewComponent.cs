using Microsoft.AspNetCore.Mvc;
using TakisShop.Helpers;
using TakisShop.ViewModels;

namespace TakisShop.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke ()
        {
            var Cart = HttpContext.Session.Get<List<CartItemVM>>(MySetting.CART_KEY) ?? new List<CartItemVM> ();
            return View("CartPanel", new CartVM
            {
                Quantity = Cart.Count(),
                Total = Cart.Sum(p => p.ThanhTien)
            }); ;
        }
    }
}
