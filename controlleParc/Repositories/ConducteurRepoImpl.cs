using controlleParc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controlleParc.Repositories
{
    public class ConducteurRepoImpl : IConducteurRepo
    {

        public AppDbContext Context { get; }
        public ConducteurRepoImpl
            (AppDbContext context)
        {
            Context = context;
        }
        public async Task AddConducteur(Conducteur conducteur)
        {
            try
            {
                await Context.Conducteurs.AddAsync(conducteur);
                await Context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }

        public async Task DeleteConducteur(Conducteur conducteur)
        {
            try
            {
                Context.Conducteurs.Remove(conducteur);
                await Context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }

        public async Task<IEnumerable<Conducteur>> findAll()
        {
            try
            {
                return await Context.Conducteurs.ToListAsync();
            }
            catch (Exception)
            {
                return new List<Conducteur>();
            }
        }

        public async Task<Conducteur> findById(int id)
        {
            try
            {
                return await Context.Conducteurs.FindAsync(id);
            }
            catch (Exception)
            {
                return new Conducteur();
            }
        }

        public async Task UpdateConducteur(Conducteur conducteur)
        {
            try
            {
                Context.Conducteurs.Update(conducteur);
                await Context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }
    }
}




