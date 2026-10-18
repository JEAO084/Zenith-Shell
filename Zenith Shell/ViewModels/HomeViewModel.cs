using System.Collections.ObjectModel;
using Zenith_Shell.Models;

namespace Zenith_Shell.ViewModels;

public sealed class HomeViewModel : ViewModelBase
{
    // Lista que alimentará el StoreCarousel
    public ObservableCollection<StoreCarouselItem> CarouselItems { get; } = new();

    // Listas para las tarjetas de la derecha
    public ObservableCollection<HomeCardItem> SidebarTopItems { get; } = new();
    public ObservableCollection<HomeCardItem> SidebarBottomItems { get; } = new();

    // Listas para las secciones de abajo
    public ObservableCollection<HomeCardItem> TrendingGames { get; } = new();
    public ObservableCollection<HomeCardItem> TrendingApps { get; } = new();

    public HomeViewModel()
    {
        LoadMockData();
    }

    private void LoadMockData()
    {
        // 1. Datos del Carrusel (Izquierda)
        CarouselItems.Add(new StoreCarouselItem
        {
            Title = "Campaign Early Access",
            Description = "Pre-order to play now",
            ImageSource = "https://picsum.photos/seed/cod/800/400", // Imagen de prueba
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

        // 2. Datos de la barra derecha (Simulando Microsoft 365, Minecraft, WhatsApp)
        SidebarTopItems.Add(new HomeCardItem
        {
            Title = "Microsoft 365",
            Description = "$99.99",
            ImageSource = "https://picsum.photos/seed/office/400/200"
        });

        SidebarBottomItems.Add(new HomeCardItem
        {
            Title = "Minecraft",
            Description = "Adventure",
            ImageSource = "https://picsum.photos/seed/mc/200/150",
            BadgeText = "Free"
        });
        SidebarBottomItems.Add(new HomeCardItem
        {
            Title = "WhatsApp",
            Description = "Social",
            ImageSource = "https://picsum.photos/seed/wa/200/150",
            BadgeText = "Free"
        });

        // 3. Trending Games & Apps (Simulando la parte inferior)
        TrendingGames.Add(new HomeCardItem { Title = "Roblox", Description = "Action & adventure", ImageSource = "https://picsum.photos/seed/roblox/100/100", BadgeText = "Owned" });
        TrendingGames.Add(new HomeCardItem { Title = "eFootball", Description = "Sports", ImageSource = "https://picsum.photos/seed/efoot/100/100", BadgeText = "Free" });

        TrendingApps.Add(new HomeCardItem { Title = "ChatGPT", Description = "Developer tools", ImageSource = "https://picsum.photos/seed/chatgpt/100/100", BadgeText = "Free" });
        TrendingApps.Add(new HomeCardItem { Title = "TikTok", Description = "Entertainment", ImageSource = "https://picsum.photos/seed/tiktok/100/100", BadgeText = "Owned" });
    }
}