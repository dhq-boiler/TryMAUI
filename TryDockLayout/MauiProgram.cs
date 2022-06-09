using TryDockLayout.MauiPane.Hosting;

namespace TryDockLayout;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureMauiPane();

        return builder.Build();
    }
}
