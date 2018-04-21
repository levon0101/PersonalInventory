using Autofac;
using PersonalInventory.DataAccess;
using PersonalInventory.UI.Data;
using PersonalInventory.UI.ViewModel;
using Prism.Events;

namespace PersonalInventory.UI.Startup
{
    public  class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<PersonalInventoryDbContext>().AsSelf();

            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<NavigationViewModel>().As<INavigationViewModel>();
            builder.RegisterType<ItemDetailViewModel>().As<IItemDetailViewModel>();

            builder.RegisterType<LookupDataService>().AsImplementedInterfaces();
            builder.RegisterType<ItemDataService>().As<IItemDataService>();

            return builder.Build();
        }
    }
}
