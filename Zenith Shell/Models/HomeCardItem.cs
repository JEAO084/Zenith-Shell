namespace Zenith_Shell.Models;

public sealed class HomeCardItem
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageSource { get; set; } = string.Empty;
    public string? BadgeText { get; set; } // Ej: "Game Pass", "Free"
}