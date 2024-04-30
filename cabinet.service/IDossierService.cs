using cabinet.domain.entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cabinet.service
{
    public interface IDossierService
    {
       List<dossier> GetAllDossiers();
       dossier GetDossierById(int id_dos);
       void AddDossier(dossier dossier);
       void UpdateDossier(dossier dossier);
       void DeleteDossier(int id_dos);

    }
}
