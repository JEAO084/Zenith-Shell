using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Zenith_Shell.Views; // Asegúrate de tener este using

namespace Zenith_Shell;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        // Al abrir la ventana, seleccionamos el primer ítem (Home) y navegamos a la página
        MainNav.SelectedItem = MainNav.MenuItems[0];
    }

    private void MainNav_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        // Si el usuario hace clic en un elemento del menú
        if (args.SelectedItemContainer is NavigationViewItem item)
        {
            string tag = item.Tag.ToString() ?? string.Empty;

            switch (tag)
            {
                case "Home":
                    ContentFrame.Navigate(typeof(HomePage));
                    break;
                case "Apps":
                    // Aquí irá tu página de todas las apps en el futuro
                    // ContentFrame.Navigate(typeof(AppsPage));
                    break;
                case "Gaming":
                    // Aquí irá tu página de juegos en el futuro
                    // ContentFrame.Navigate(typeof(GamingPage));
                    break;
            }
        }
    }
}