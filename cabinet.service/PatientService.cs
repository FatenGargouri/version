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
    public class PatientService : IPatientService
    {

        private readonly cabinetContext _context;

        public PatientService(cabinetContext context)
        {
            _context = context;
        }

        public List<patient> GetAllPatients()
        {
            return _context.patients.ToList();
        }

        public patient GetPatientById(int id_pat)
        {
            return _context.patients.Find(id_pat);
        }

        public void AddPatient(patient patient)
        {
            _context.patients.Add(patient);
            _context.SaveChanges();
        }

        public void UpdatePatient(patient patient)
        {
            _context.Entry(patient).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeletePatient(int id_pat)
        {
            var patient = _context.patients.Find(id_pat);
            if (patient != null)
            {
                _context.patients.Remove(patient);
                _context.SaveChanges();
            }
        }

    }
}
