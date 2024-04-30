using cabinet.domain.entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabinet.service
{
    public interface IRendezvousService
    {
        List<rendezvous> GetAllRendezvouss();
        rendezvous GetRendezvousById(int id_ren);
        void AddRendezvous(rendezvous rendezvous);
        void UpdateRendezvous(rendezvous rendezvous);
        void DeleteRendezvous(int id_rend);
    }
}
