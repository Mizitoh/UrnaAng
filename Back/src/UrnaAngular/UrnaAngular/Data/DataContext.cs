using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrnaAngular.Models;

namespace UrnaAngular.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }
        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Voto> Votos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Candidato>().HasData(new List<Candidato>()
            {
                new Candidato(1,"Branco","Branco","Branco",DateTime.Now,00),
                new Candidato(2,"Nulo","Nulo","Nulo",DateTime.Now,99),
                new Candidato(3,"Lula","Madona","PT",DateTime.Now,12),
                new Candidato(4,"FHC","Mickey","PSDB",DateTime.Now,45),
                new Candidato(5,"Jumento","Capitao Jegue","PSL",DateTime.Now,17)
            });

            builder.Entity<Voto>().HasData(new List<Voto>()
            {
                new Voto(1,1,1),
                new Voto(2,2,1),
                new Voto(3,5,1),
                new Voto(4,3,1),
                new Voto(5,3,1),
                new Voto(6,4,1),
                new Voto(7,4,1),
                new Voto(8,3,1),
                new Voto(9,5,1),
                new Voto(10,3,1),
                new Voto(11,2,1),
                new Voto(12,3,1)
            });
        }
    }
}
