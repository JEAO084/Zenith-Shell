using Microsoft.UI.Xaml;
using Zenith_Shell.ViewModels;

namespace Zenith_Shell;

public sealed partial class MainWindow : Window
{
    public MainViewModel ViewModel => App.MainViewModel;

    public MainWindow()
    {
        InitializeComponent();
        // Navegamos al inicio por defecto
        ContentFrame.Navigate(typeof(Views.HomePage));
    }
}