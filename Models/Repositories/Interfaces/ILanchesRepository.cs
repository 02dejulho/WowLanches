using WowLanches.Models;

namespace WowLanches.Repositories.Interfaces

{
    public interface ILanchesRepository
{
    IEnumerable<Lanche> Lanches {get;}
    IEnumerable<Lanche> LanchesPreferidos {get;}
    Lanche GetLancheById (int lancheId);
}

}

