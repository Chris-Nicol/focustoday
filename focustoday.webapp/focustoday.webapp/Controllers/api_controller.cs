using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace focustoday.webapp.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        [Route("hello")]
        [HttpGet]
        // GET: /<controller>/
        public IActionResult Hello()
        {
            var msg = new { Message = "Hello World" };
            return this.Ok(msg);
        }
    }
}
