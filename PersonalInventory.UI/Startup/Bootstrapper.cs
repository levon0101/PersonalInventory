using Autofac;
using PersonalInventory.UI.Data;
using PersonalInventory.UI.ViewModel;

namespace PersonalInventory.UI.Startup
{
    public  class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<ItemDataService>().As<IItemDataService>();

            return builder.Build();
        }
    }
}
