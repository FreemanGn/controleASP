using controlleParc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controlleParc
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Conducteur> Conducteurs { get; set; }
        public DbSet<Vehicule> Vehicules { get; set; }
        public DbSet<Entretien> Entretiens { get; set; }
        public DbSet<EntretienVehicule> EntretienVehicules { get; set; }
    }
    }
