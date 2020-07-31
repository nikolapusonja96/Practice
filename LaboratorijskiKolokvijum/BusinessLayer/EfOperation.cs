using LaboratorijskiKolokvijum.DataLayer;

namespace LaboratorijskiKolokvijum.BusinessLayer
{
    public abstract class EfOperation : Operation
    {
        private BazaContext context { get; } = new BazaContext();

        protected BazaContext Db => context;
    }
}
