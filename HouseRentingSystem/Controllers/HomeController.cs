﻿using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HouseRentingSystem.Controllers
{
    public class HomeController : BaseController
	{
		private readonly ILogger<HomeController> logger;
		private IHouseService houseService;

		public HomeController(
			ILogger<HomeController> logger,
			IHouseService houseService)
		{
			this.logger = logger;
			this.houseService = houseService;
		}

		[AllowAnonymous]
		public async Task<IActionResult> Index()
		{
			var model = await houseService.LastThreeHousesAsync();

			return View(model);
		}

		[AllowAnonymous]
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error(int statusCode)
		{
			if (statusCode == 400)
			{
				return View("Error400");
			}

            if (statusCode == 401)
            {
                return View("Error401");
            }

            return View();
		}
	}
}