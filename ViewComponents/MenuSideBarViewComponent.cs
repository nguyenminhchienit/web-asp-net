using Microsoft.AspNetCore.Mvc;
using TakisShop.Data;
using TakisShop.ViewModels;

namespace TakisShop.ViewComponents
{
    public class MenuSideBarViewComponent :  ViewComponent
    {
        private readonly TakisShopContext _context;

        public MenuSideBarViewComponent(TakisShopContext context) { 
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var data = _context.Loais.Select(l => new MenuSideBarViewModel
            {
                MaLoai = l.MaLoai,
                TenLoai = l.TenLoai,
                SoLuong = l.HangHoas.Count(),
            });
            return View(data);
        }
    }
}
