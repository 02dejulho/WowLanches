using Microsoft.EntityFrameworkCore;
using WowLanches.Context;
using WowLanches.Models;
using WowLanches.Repositories.Interfaces;

namespace WowLanches.Repositories
{
    public class LancheRepository : ILanchesRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);
        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p => p.IsLanchePreferido).Include(c => c.Categoria);
        public Lanche GetLancheById (int lancheId) => _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
    }
}