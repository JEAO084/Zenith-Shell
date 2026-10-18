using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Zenith_Shell.Models;

namespace Zenith_Shell.Services;

public interface IAppSearchService
{
    /// <summary>Devuelve todas las apps conocidas (cacheadas).</summary>
    Task<IReadOnlyList<AppEntry>> GetAllAppsAsync(CancellationToken ct = default);

    /// <summary>Filtra las apps por texto (case-insensitive).</summary>
    Task<IReadOnlyList<AppEntry>> SearchAsync(string query, CancellationToken ct = default);
}