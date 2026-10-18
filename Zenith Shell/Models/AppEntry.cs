namespace Zenith_Shell.Models;

public sealed class AppEntry
{
    public required string Name { get; init; }
    public required string ExecutablePath { get; init; }
    public string? IconPath { get; init; }
    public string? Arguments { get; init; }

    /// <summary>Texto usado para filtrar en la búsqueda.</summary>
    public string SearchText => Name.ToLowerInvariant();
}