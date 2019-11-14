﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class LotoNumbersController : Controller
    {
        public static List<Models.LotoNumber> Lst = CreateList();
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

        private static List<Models.LotoNumber> CreateList()
        {
            var lst = new List<Models.LotoNumber>();
            for (var i = 1; i <= Shared_Functions.Variables.N; i++)
            {
                var number = new Models.LotoNumber();
                number.Index = i;
                lst.Add(number);
            }
            return lst;
        }

        public ActionResult OnBtnClick(Models.LotoNumber number)
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