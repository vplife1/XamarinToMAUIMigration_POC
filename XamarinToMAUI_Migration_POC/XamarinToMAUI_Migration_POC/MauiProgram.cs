using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace XamarinToMAUI_Migration_POC;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiCompatibility();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            })
            .ConfigureMauiHandlers((handlers) => {
                handlers.AddCompatibilityRenderer(typeof(PressableView), typeof(PressableView));
               
            });

        return builder.Build();
    }
}

