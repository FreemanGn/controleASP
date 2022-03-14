using controlleParc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controlleParc.Repositories
{
    public interface IConducteurRepo
    {
        Task<IEnumerable<Conducteur>> findAll();
        Task<Conducteur> findById(int id);
        Task AddConducteur(Conducteur conducteur);
        Task UpdateConducteur (Conducteur conducteur);
        Task DeleteConducteur (Conducteur conducteur);
    }
}
