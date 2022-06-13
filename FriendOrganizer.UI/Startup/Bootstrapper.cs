using Autofac;

namespace FriendOrganizer.UI.Startup;
public class Bootstrapper
{
    public Autofac.IContainer Bootstrap()
    {
        var builder = new ContainerBuilder();
        builder.RegisterType<MainWindow>().AsSelf();
        builder.RegisterType<MainViewModel>().AsSelf();
        builder.RegisterType<FriendDataService>().As<IFriendDataService>();

        return builder.Build();
    }
}