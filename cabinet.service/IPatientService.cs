using cabinet.domain.entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabinet.service
{
    public interface IPatientService
    {
        List<patient> GetAllPatients();
        patient GetPatientById(int id_pat);
        void AddPatient(patient patient);
        void UpdatePatient(patient patient);
        void DeletePatient(int id_pat);
    }
}
