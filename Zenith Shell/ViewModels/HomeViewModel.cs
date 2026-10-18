using System.Collections.ObjectModel;
using DevWinUI; // <--- ¡ESTO FALTABA!
using Zenith_Shell.Models;

namespace Zenith_Shell.ViewModels;

public sealed partial class HomeViewModel : ViewModelBase // <--- Agregado 'partial'
{
    public ObservableCollection<StoreCarouselItem> CarouselItems { get; } = []; // Sintaxis C# 12
    public ObservableCollection<HomeCardItem> SidebarTopItems { get; } = [];
    public ObservableCollection<HomeCardItem> SidebarBottomItems { get; } = [];
    public ObservableCollection<HomeCardItem> TrendingGames { get; } = [];
    public ObservableCollection<HomeCardItem> TrendingApps { get; } = [];

    public HomeViewModel()
    {
        LoadMockData();
    }

    private void LoadMockData()
    {
        // ... (El resto del código de datos se mantiene igual, pero recuerda que 
        // CarouselItems.Add(...) sigue siendo válido).
    }
}