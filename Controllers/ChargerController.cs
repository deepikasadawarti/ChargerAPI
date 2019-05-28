using ChargerInfo.API.Entities;
using ChargerInfo.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChargerInfo.API.Controllers
{


    [Route("api/chargerInfo")]
    public class ChargerController : Controller
    {
        private IChargerInfoRepository _ichargerInfoRepository;
        public ChargerController(IChargerInfoRepository ichargerInfoRepository)
        {
            _ichargerInfoRepository = ichargerInfoRepository;
        }

        [HttpGet()]
        public IActionResult GetChargers()
        {
            var chargerEntites = _ichargerInfoRepository.GetChargers();
            var results = new List<Charger>();
            foreach (var chargerEntity in chargerEntites)
            {
                results.Add(new Charger
                {
                    id = chargerEntity.id,
                    chargerStationType = chargerEntity.chargerStationType,
                    powerInVolt = chargerEntity.powerInVolt
                });
            }

            return Ok(results);
        }

        [HttpGet("{chargerId}")]

        public IActionResult GetCharger(int chargerId)
        {
            var charger = _ichargerInfoRepository.GetCharger(chargerId);
            var result = new Charger()
            {
                id = charger.id,
                chargerStationType = charger.chargerStationType,
                powerInVolt = charger.powerInVolt
            };
            if (result == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }
        }
    }
}
