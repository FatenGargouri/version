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
    public class DossierService : IDossierService
    {

        private readonly cabinetContext _context;

        public DossierService(cabinetContext context)
        {
            _context = context;
        }

        public List<dossier> GetAllDossiers()
        {
            return _context.dossier.ToList();
        }

        public dossier GetDossierById(int id_dos)
        {
            return _context.dossier.Find(id_dos);
        }

        public void AddDossier(dossier dossier)
        {
            _context.dossier.Add(dossier);
            _context.SaveChanges();
        }

        public void UpdateDossier(dossier dossier)
        {
            _context.Entry(dossier).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteDossier(int id_dos)
        {
            var dossier = _context.dossier.Find(id_dos);
            if (dossier != null)
            {
                _context.dossier.Remove(dossier);
                _context.SaveChanges();
            }
        }
    }
    
}
