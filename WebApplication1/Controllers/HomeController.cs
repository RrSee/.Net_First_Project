using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Entities;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public ViewResult Drinks()
		{
			List<Drink> drinks = new()
			{
				new Drink
				{
					id = 1,
					name = "Sprite",
					price = 2
				},
				new Drink
				{
					id = 2,
					name = "Pepsi",
					price = 1
				},
				new Drink
				{
					id = 3,
					name = "Mirinda",
					price = 3
				}
			};
			return View(drinks);
		}

		public ViewResult HotMeals()
		{
			List<HotMeal> hotMeals = new()
			{
				new HotMeal
				{
					id = 1,
					name = "kabab",
					price = 10
				},
				new HotMeal
				{
					id = 2,
					name = "Lule",
					price = 15
				},
				new HotMeal
				{
					id = 3,
					name = "Tike",
					price = 20
				},
			};
			return View(hotMeals);
		}

		public JsonResult FastFoods(string key = "", int id = -1)
		{
			List<FastFood> fastFoods = new()
			{
				new FastFood
				{
					id = 1,
					name = "burger",
					price = 10
				},
				new FastFood
				{
					id = 2,
					name = "qanad",
					price = 10
				},
				new FastFood
				{
					id = 3,
					name = "nageds",
					price = 10
				}
			};
			
			if(id == -1)
			{
				var data = fastFoods.Where(e => e.name.Contains(key));
				return Json(data);
			}
			else
			{
				var data = fastFoods.Where(e => e.id == id || e.name.Contains(key));
				return Json(data);
			}
		}

	}
}
