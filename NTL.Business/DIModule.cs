using Ninject.Modules;
using NTL.Infrastructure.UnitOfWork;

namespace NTL.Business
{
    public class DiModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EfUnitOfWork>();
        }
    }
}