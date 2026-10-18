using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Zenith_Shell.Models;
using Zenith_Shell.Services;

namespace Zenith_Shell.ViewModels;

public sealed class MainViewModel : ViewModelBase
{
    private readonly IAppSearchService _searchService;

    private string _query = string.Empty;
    public string Query
    {
        get => _query;
        set
        {
            if (SetProperty(ref _query, value))
                _ = SearchAsync();
        }
    }

    public ObservableCollection<AppEntry> Results { get; } = new();

    private AppEntry? _selectedApp;
    public AppEntry? SelectedApp
    {
        get => _selectedApp;
        set => SetProperty(ref _selectedApp, value);
    }

    public MainViewModel(IAppSearchService searchService)
    {
        _searchService = searchService;
    }

    public async Task InitializeAsync()
    {
        await SearchAsync();
    }

    private async Task SearchAsync()
    {
        var results = await _searchService.SearchAsync(_query);
        Results.Clear();
        foreach (var r in results)
            Results.Add(r);
    }
}