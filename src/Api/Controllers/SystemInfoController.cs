﻿using Common;
using Common.Dto.Api;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
	[ApiController]
	[Route("api/systeminfo")]
	[Produces("application/json")]
	[Consumes("application/json")]
	public class SystemInfoController : Controller
	{
		public SystemInfoController() { }

		/// <summary>
		/// Fetches information about the service and system.
		/// </summary>
		/// <returns>SystemInfoGetResponse</returns>
		/// <response code="200">Returns the system information</response>
		[HttpGet]
		public ActionResult<SystemInfoGetResponse> Get()
		{
			return Ok(GetData());
		}

		private SystemInfoGetResponse GetData()
		{
			return new SystemInfoGetResponse()
			{
				OperatingSystem = Environment.OSVersion.Platform.ToString(),
				OperatingSystemVersion = Environment.OSVersion.VersionString,

				RunTimeVersion = Environment.Version.ToString(),

				Version = Constants.AppVersion,

				GitHub = "https://github.com/philosowaffle/peloton-to-garmin",
				Documentation = "https://philosowaffle.github.io/peloton-to-garmin/",
				Forums = "https://github.com/philosowaffle/peloton-to-garmin/discussions",
				Donate = "https://www.buymeacoffee.com/philosowaffle",
				Issues = "https://github.com/philosowaffle/peloton-to-garmin/issues",
				Api = $"{this.Request.Scheme}://{this.Request.Host}/swagger"
			};
		}
	}
}
