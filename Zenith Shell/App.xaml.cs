using Microsoft.UI.Xaml;
using Zenith_Shell.Services;
using Zenith_Shell.ViewModels;

namespace Zenith_Shell;

public partial class App : Application
{
    public static IAppSearchService AppSearchService { get; } = new AppSearchService();
    public static MainViewModel MainViewModel { get; } = new(AppSearchService);

    public App() => InitializeComponent();

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        var window = new MainWindow();
        window.Activate();
    }
}