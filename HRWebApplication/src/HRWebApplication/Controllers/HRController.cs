using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRWebApplication.Controllers
{
    [Route("api/users")]
    public class HRController : Controller
    {
        [HttpGet]
        public JsonResult GetUsers()
        {
            return new JsonResult(new List<object>()
            {
                new {id=1, Name="Zdr"},
                new {id=2, Name="Ana"}
            });
        }
    }

}
