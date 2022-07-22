using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Mydatabase;
using Repository;
using Repository.Interfaces;
using System.Data.Entity;
using Service.Interfaces;

namespace GUI
{
    public class Bootstrap // инверсия управления
    {
        public static WindsorContainer BuildContainer()
        {
            WindsorContainer container = new WindsorContainer();
            container.Register(Component.For<DbContext>().ImplementedBy<MyDatabaseEntityContext>());
            container.Register(Component.For<IUnitOfWork>().ImplementedBy<UnitOfWork>());
            container.Register(Classes.FromAssemblyNamed("Repository").
                BasedOn(typeof(IRepository<,>)).WithService.Base().WithServiceDefaultInterfaces());
            container.Register(Classes.FromAssemblyNamed("Service").
                BasedOn(typeof(IService)).WithService.Base().WithServiceDefaultInterfaces());
            return container;
        }
    }
}
