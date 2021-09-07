using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }
        public DbSet<Ametinimetus> Ametinimetused { get; set; }
        public DbSet<Haigusleht> Haiguslehed { get; set; }
        public DbSet<Laenutamine> Laenutused { get; set; }
        public DbSet<Laps> Lapsed { get; set; }
        public DbSet<Puhkus> Puhkused { get; set; }
        public DbSet<Töötaja> Töötajad { get; set; }
    }
}