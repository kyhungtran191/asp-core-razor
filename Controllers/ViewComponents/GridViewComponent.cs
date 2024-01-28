using Microsoft.AspNetCore.Mvc;

namespace razor_asp.Controllers.ViewComponents
{
    public class GridViewComponent :  ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
