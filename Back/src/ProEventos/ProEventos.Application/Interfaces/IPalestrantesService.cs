using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Application.Interfaces
{
    public interface IPalestranteService
    {
        Task<Evento> AddPalestrantes(Palestrante model);
        Task<Palestrante> UpdatePalestrante(int eventoId, Palestrante model);
        Task<bool> DeletePalestrante(int eventoId);
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includePalestrantes = false);
        Task<Palestrante[]> GetAllPalestrantesByTemaAsync(string tema, bool includePalestrantes = false);
        Task<Palestrante> GetPalestrantesByIdAsync(int eventoId, bool includePalestrantes = false);
    }
}
