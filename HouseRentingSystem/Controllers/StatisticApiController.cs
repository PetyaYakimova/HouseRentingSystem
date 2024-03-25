using HouseRentingSystem.Core.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
	[Route("api/statistic")]
	[ApiController]
	public class StatisticApiController : ControllerBase
	{
		private readonly IStatisticService statisticService;

		public StatisticApiController(IStatisticService statisticService)
		{
			this.statisticService = statisticService;
		}

		[HttpGet]
		public async Task<IActionResult> GetStatistic()
		{
			var result = await statisticService.TotalAsync();

			return Ok(result);
		}
	}
}
