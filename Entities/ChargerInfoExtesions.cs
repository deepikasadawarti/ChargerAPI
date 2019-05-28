using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChargerInfo.API.Entities
{
    public static class ChargerInfoExtesions
    {
        public static void EnsureSeedDataForContext(this ChargerInfoContext context)
        {
            if (context.chargers.Any())
            {
                return;
            }
            var chargerDb = new List<Charger>()
            {
                new Charger()
                {
                    chargerStationType = "Residential",
                    powerInVolt = 240
                },
                new Charger()
                {
                    chargerStationType = "public",
                    powerInVolt = 120
                }
            };
            context.chargers.AddRange(chargerDb);
            context.SaveChanges();
        }
    }
}
