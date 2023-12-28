using Microsoft.AspNetCore.Mvc;
using ReportAPI.Interface;

namespace ReportAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppController : ControllerBase

    {

        private readonly IAppService _appSer;
       

        public AppController(IAppService appSer)
        {
            this._appSer = appSer;
        }

        [HttpGet("GetReports")]
        public IActionResult GetReports()
        {
            var reports = _appSer.GetReports();

            if (reports == null || !reports.Any())
            {
                return NotFound();
            }

             return Ok(new { message = reports });
        }
    }
}