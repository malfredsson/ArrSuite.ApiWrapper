using System.Collections.ObjectModel;

namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class CustomFormatSpecificationField
{
    public IReadOnlyCollection<SelectOption> SelectOptions { get; init; } = new Collection<SelectOption>();
    public bool Advanced { get; init; }
    public bool IsFloat { get; init; }
    public int Order { get; init; }
    public string HelpLink { get; init; } = string.Empty;
    public string HelpText { get; init; } = string.Empty;
    public string HelpTextWarning { get; init; } = string.Empty;
    public string Hidden { get; init; } = string.Empty;
    public string Label { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public string Placeholder { get; init; } = string.Empty;
    public string Privacy { get; init; } = string.Empty;
    public string Section { get; init; } = string.Empty;
    public string SelectOptionsProviderAction { get; init; } = string.Empty;
    public string Type { get; init; } = string.Empty;
    public string Unit { get; init; } = string.Empty;
    public string Value { get; init; } = string.Empty;
}
