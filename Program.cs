using Photino.Blazor;

namespace Slipstream;

internal static class Program
{
    private static async Task<int> Main(string[] args)
    {
        var builder = PhotinoBlazorApp.CreateBuilder(args);

        builder.RootComponents.Add<App>("#app");

        builder.ConfigureMainWindow(window => {
            window.SetTitle("Slipstream")
                  .SetSize(1000, 700)
                  .SetDevToolsEnabled(true);
            }
        );

        await using var app = builder.Build();

        return app.Run();
    }
}
