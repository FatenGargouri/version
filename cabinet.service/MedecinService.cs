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
    public class MedecinService : IMedecinService
    {
        private readonly cabinetContext _context;

        public MedecinService(cabinetContext context)
        {
            _context = context;
        }

        public List<medecin> GetAllMedecins()
        {
            return _context.medecines.ToList();
        }

        public medecin GetMedecinById(int id_med)
        {
            return _context.medecines.Find(id_med);
        }

        public void AddMedecin(medecin medecin)
        {
            _context.medecines.Add(medecin);
            _context.SaveChanges();
        }

        public void UpdateMedecin(medecin medecin)
        {
            _context.Entry(medecin).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteMedecin(int id_med)
        {
            var medecin = _context.medecines.Find(id_med);
            if (medecin != null)
            {
                _context.medecines.Remove(medecin);
                _context.SaveChanges();
            }
        }
    }
}



        

