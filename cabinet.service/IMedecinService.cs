using cabinet.domain.entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabinet.service
{
    public interface IMedecinService
    {
        List<medecin> GetAllMedecins();
        medecin GetMedecinById(int id_med);
        void AddMedecin(medecin medecin);
        void UpdateMedecin(medecin medecin);
        void DeleteMedecin(int id_med);
    }
}
