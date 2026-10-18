using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Zenith_Shell.Models;

namespace Zenith_Shell.Services;

public sealed class AppSearchService : IAppSearchService
{
    private IReadOnlyList<AppEntry>? _cache;

    public Task<IReadOnlyList<AppEntry>> GetAllAppsAsync(CancellationToken ct = default)
    {
        // TODO: reemplazar por enumeración real (Start Menu, AppX, .lnk, etc.)
        _cache ??= new List<AppEntry>
        {
            new() { Name = "Notepad",       ExecutablePath = "notepad.exe" },
            new() { Name = "Calculator",    ExecutablePath = "calc.exe" },
            new() { Name = "Paint",         ExecutablePath = "mspaint.exe" },
            new() { Name = "Command Prompt",ExecutablePath = "cmd.exe" },
            new() { Name = "PowerShell",    ExecutablePath = "powershell.exe" },
            new() { Name = "Task Manager",  ExecutablePath = "taskmgr.exe" },
        };
        return Task.FromResult(_cache);
    }

    public async Task<IReadOnlyList<AppEntry>> SearchAsync(string query, CancellationToken ct = default)
    {
        var all = await GetAllAppsAsync(ct);
        if (string.IsNullOrWhiteSpace(query))
            return all;

        var q = query.Trim().ToLowerInvariant();
        return all.Where(a => a.SearchText.Contains(q)).ToList();
    }
}