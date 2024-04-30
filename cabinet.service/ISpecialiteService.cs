using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cabinet.data;
using cabinet.domain.entites;

namespace cabinet.service
{
    public interface ISpecialiteService
    {
        List<specialite> GetAllSpecialites();
        specialite GetSpecialiteById(int id_spec);
        void AddSpecialite(specialite specialite);
        void UpdateSpecialite(specialite specialite);
        void DeleteSpecialite(int id_spec);
    }
}
