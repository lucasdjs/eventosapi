using ProEventos.Application.Interfaces;
using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Application.Services
{
    public class PalestrantesServices : IPalestranteService
    {
        public Task<Evento> AddPalestrantes(Palestrante model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePalestrante(int eventoId)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesAsync(bool includePalestrantes = false)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesByTemaAsync(string tema, bool includePalestrantes = false)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante> GetPalestrantesByIdAsync(int eventoId, bool includePalestrantes = false)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante> UpdatePalestrante(int eventoId, Palestrante model)
        {
            throw new NotImplementedException();
        }
    }
}
