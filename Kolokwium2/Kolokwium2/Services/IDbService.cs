using System;
using System.Threading.Tasks;
using Kolokwium2.DTOs.Requests;
using Kolokwium2.Models;

namespace Kolokwium2.Services {

    public interface IDbService {
        Task<Artist> GetArtist(int id);
        void UpdatePerformanceDate(UpdateRequest updateRequest, int idArtist, int idEvent);
    }
}
