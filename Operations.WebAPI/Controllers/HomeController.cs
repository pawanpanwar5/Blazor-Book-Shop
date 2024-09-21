using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Operations.WebAPI.Utility;

namespace Operations.WebAPI.Controllers
{
    //Verbs: Get, Post, Put, Delete


    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        protected IConfiguration _config;
        private SchoolSettings _schoolSettings;

        //public HomeController(IConfiguration config, SchoolSettings schoolSettings)
        //{
        //    _config = config;
        //    _schoolSettings = schoolSettings;
        //}
        public HomeController(IConfiguration config, IOptions<SchoolSettings> schoolSettings)
        {
            _config = config;
            _schoolSettings = schoolSettings.Value;
        }
        [HttpGet]
        public IActionResult Get()
        {
            //return Ok(_config["UserData:FullName"]);
            return Ok(_schoolSettings.Address.City);
        }
    }
}
