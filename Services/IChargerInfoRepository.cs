using ChargerInfo.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChargerInfo.API.Services
{
    public interface IChargerInfoRepository
    {
        IEnumerable<Charger> GetChargers();
        Charger GetCharger(int chargerId);
        Session GetSession(int SessionId);
        IEnumerable<Session> GetSessions();
        Session AddSession(Session session);
        Session UpdateSessionDetails(Session session);



    }
}
