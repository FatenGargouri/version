using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cabinet.data;
using cabinet.domain.entites;

namespace cabinet.service
{
    public class SpecialiteService : ISpecialiteService
    {

        private readonly cabinetContext _context;

        public SpecialiteService(cabinetContext context)
        {
            _context = context;
        }

        public List<specialite> GetAllSpecialites()
        {
            return _context.specialites.ToList();
        }

        public specialite GetSpecialiteById(int id_spec)
        {
            return _context.specialites.Find(id_spec);
        }

        public void AddSpecialite(specialite specialite)
        {
            _context.specialites.Add(specialite);
            _context.SaveChanges();
        }

        public void UpdateSpecialite(specialite specialite)
        {
            _context.Entry(specialite).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteSpecialite(int id_spec)
        {
            var specialite = _context.specialites.Find(id_spec);
            if (specialite != null)
            {
                _context.specialites.Remove(specialite);
                _context.SaveChanges();
            }
        }
    }
}

