using ChargerInfo.API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChargerInfo.API.Controllers
{
    public class DummyController : Controller
    {
        private ChargerInfoContext _cx;
        public DummyController(ChargerInfoContext cx)
        {
            _cx = cx;
        }

        [HttpGet("api/testCharger")]
        public IActionResult testdb()
        {
            return Ok();
        }
    }
}
