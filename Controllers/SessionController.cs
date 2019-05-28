using ChargerInfo.API.Entities;
using ChargerInfo.API.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChargerInfo.API.Controllers
{
    [Route("api")]
    public class SessionController : Controller
    {
        private readonly IChargerInfoRepository _ichargerInfoRepository;
        public SessionController(IChargerInfoRepository ichargerInfoRepository)
        {
            _ichargerInfoRepository = ichargerInfoRepository;
        }

        [HttpGet("GetSession/{sessionId}")]
        public Session GetSession(int sessionId)
        {
            return _ichargerInfoRepository.GetSession(sessionId);

        }

        [HttpGet("GetSessions")]
        public List<Session> GetSessions()
        {
            return _ichargerInfoRepository.GetSessions().ToList();
        }


        [HttpPost("StartSession")]
        public Session AddSession(
            [FromBody] Session session)
        {
            return _ichargerInfoRepository.AddSession(session);

        }

        [HttpPut("StopSession")]
        public Session UpdateSessionDetails(
            [FromBody] Session session)
        {
            return _ichargerInfoRepository.UpdateSessionDetails(session);
        }
    }
}
