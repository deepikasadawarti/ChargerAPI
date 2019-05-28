using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChargerInfo.API.Entities;

namespace ChargerInfo.API.Services
{
    public class ChargerInfoRepository : IChargerInfoRepository
    {
        private ChargerInfoContext _context;
        public ChargerInfoRepository(ChargerInfoContext context)
        {
            _context = context;
        }
        public IEnumerable<Charger> GetChargers()
        {
            return _context.chargers.OrderBy(c => c.chargerStationType).ToList();
        }
        public Charger GetCharger(int chargerId)
        {
            return _context.chargers.Where(c => c.id == chargerId).FirstOrDefault();
        }
        public Session GetSession(int sessionId)
        {
            return _context.sessions.Where(s => s.id == sessionId).FirstOrDefault();
        }
        public IEnumerable<Session> GetSessions()
        {
            return _context.sessions.ToList();
        }

        public Session AddSession(Session session)
        {
            _context.sessions.Add(session);
            _context.SaveChanges();
            return session;
        }

        public Session UpdateSessionDetails(Session session)
        {
            Session SessionfromEntity = GetSession(session.id);

            SessionfromEntity.sessionStopTime = session.sessionStopTime;
            SessionfromEntity.status = session.status;
            _context.sessions.Update(SessionfromEntity);
            _context.SaveChanges();
            return session;

        }
    }
}

