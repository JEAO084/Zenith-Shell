namespace Zenith_Shell.Services;

public interface ISettingsService
{
    // TODO: definir cuando lleguemos a settings (tema, hotkey, tamaño de ventana, etc.)
    T? Get<T>(string key, T? defaultValue = default);
    void Set<T>(string key, T value);
}