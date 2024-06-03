using Microsoft.EntityFrameworkCore;
using WowLanches.Context;
using WowLanches.Models;
using WowLanches.Repositories.Interfaces;

namespace WowLanches.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);
        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches. //obtendo lanches
                                                        Where(p => p.IsLanchePreferido). //filtrando Lanche Preferido
                                                        Include(c => c.Categoria); //obtendo a Categoria
        public Lanche GetLancheById (int lancheId) 
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
        
         
    }
}