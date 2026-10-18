using System.Collections.ObjectModel;
using DevWinUI;
using Zenith_Shell.Models;

namespace Zenith_Shell.ViewModels;

public sealed partial class HomeViewModel : ViewModelBase
{
    // Carrusel
    public ObservableCollection<StoreCarouselItem> CarouselItems { get; } = [];

    // Tarjetas laterales (Propiedades individuales para evitar crashes)
    public HomeCardItem? SidebarTopItem { get; set; }
    public HomeCardItem? SidebarBottomItem1 { get; set; }
    public HomeCardItem? SidebarBottomItem2 { get; set; }

    // Secciones inferiores
    public ObservableCollection<HomeCardItem> TrendingGames { get; } = [];
    public ObservableCollection<HomeCardItem> TrendingApps { get; } = [];

    public HomeViewModel()
    {
        LoadMockData();
    }

    private void LoadMockData()
    {
        // 1. Carrusel
        CarouselItems.Add(new StoreCarouselItem
        {
            Title = "Campaign Early Access",
            Description = "Pre-order to play now",
            ImageSource = "https://picsum.photos/seed/cod/800/400",
            ShowActionButton = true,
            ActionButtonText = "See details"
        });
        CarouselItems.Add(new StoreCarouselItem
        {
            Title = "Cyberpunk 2077",
            Description = "Explore the dark future",
            ImageSource = "https://picsum.photos/seed/cyber/800/400",
            ShowActionButton = true,
            ActionButtonText = "Buy now"
        });

        // 2. Tarjetas laterales
        SidebarTopItem = new HomeCardItem
        {
            Title = "Microsoft 365",
            Description = "$99.99",
            ImageSource = "https://picsum.photos/seed/office/400/200"
        };

        SidebarBottomItem1 = new HomeCardItem
        {
            Title = "Minecraft",
            Description = "Adventure",
            ImageSource = "https://picsum.photos/seed/mc/200/150"
        };

        SidebarBottomItem2 = new HomeCardItem
        {
            Title = "WhatsApp",
            Description = "Social",
            ImageSource = "https://picsum.photos/seed/wa/200/150"
        };

        // 3. Tendencias
        TrendingGames.Add(new HomeCardItem { Title = "Roblox", Description = "Action & adventure", ImageSource = "https://picsum.photos/seed/roblox/100/100" });
        TrendingGames.Add(new HomeCardItem { Title = "eFootball", Description = "Sports", ImageSource = "https://picsum.photos/seed/efoot/100/100" });

        TrendingApps.Add(new HomeCardItem { Title = "ChatGPT", Description = "Developer tools", ImageSource = "https://picsum.photos/seed/chatgpt/100/100" });
        TrendingApps.Add(new HomeCardItem { Title = "TikTok", Description = "Entertainment", ImageSource = "https://picsum.photos/seed/tiktok/100/100" });
    }
}