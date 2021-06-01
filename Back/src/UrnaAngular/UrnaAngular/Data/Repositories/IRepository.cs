using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrnaAngular.Models;

namespace UrnaAngular.Data.Repositories
{
    public interface IRepository
    {
        //GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //Candidato
        Task<Candidato[]> GetAllCandidatosAsync();
        Task<Candidato> GetCandidatoAsyncById(int candidatoId);

        //Voto

        Task<Voto[]> GetAllVotosAsync();
        Task<Voto> GetVotosByLegendaAsync(int legenda);
    }
}
