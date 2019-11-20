using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class LotoNumbersController : Controller
    {
        public static List<Models.LotoNumber> Lst = CreateList().GetAwaiter().GetResult();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InitLotoNumbers()
        {
            foreach (var number in Lst)
            {
                if (number.ActionOnClick != null) break;
                number.ActionOnClick = OnBtnClick;
            }
            return View(Lst);
        }

        private static async Task<List<Models.LotoNumber>> CreateList()
        {
            await Common.Helper.LoadDataFromCsvAsync();

            var lst = new List<Models.LotoNumber>();
            for (var i = 1; i <= Shared_Functions.Variables.N; i++)
            {
                var number = new Models.LotoNumber {Index = i};
                lst.Add(number);
            }
            return lst;
        }

        public ActionResult OnBtnClick(WebApplication.Models.LotoNumber number)
        {
            var value = Lst.FirstOrDefault(x => x.Index == number.Index);
            if (value != null)
            {
                value.IsSelected = !value.IsSelected;
            }
            return RedirectToAction(nameof(InitLotoNumbers));
        }
    }
}