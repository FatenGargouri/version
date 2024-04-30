using cabinet.data;
using cabinet.domain.entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabinet.service
{
    public class RendezvousService : IRendezvousService
    {
        private readonly cabinetContext _context;

        public RendezvousService(cabinetContext context)
        {
            _context = context;
        }

        public List<rendezvous> GetAllRendezvouss()
        {
            return _context.rendezvouss.ToList();
        }

        public rendezvous GetRendezvousById(int id_ren)
        {
            return _context.rendezvouss.Find(id_ren);
        }

        public void AddRendezvous(rendezvous rendezvous)
        {
            _context.rendezvouss.Add(rendezvous);
            _context.SaveChanges();
        }

        public void UpdateRendezvous(rendezvous rendezvous)
        {
            _context.Entry(rendezvous).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteRendezvous(int id_ren)
        {
            var rendezvous = _context.rendezvouss.Find(id_ren);
            if (rendezvous != null)
            {
                _context.rendezvouss.Remove(rendezvous);
                _context.SaveChanges();
            }
        }

    }
}
