using System.Collections.ObjectModel;

namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class CustomFormatSpecification
{
    public IReadOnlyCollection<CustomFormatSpecificationField> Fields { get; init; } =
        new Collection<CustomFormatSpecificationField>();
    public IReadOnlyCollection<string> Presets { get; init; } = new Collection<string>();
    public bool Negate { get; init; }
    public int Id { get; init; }
    public string Implementation { get; init; } = string.Empty;
    public string ImplementationName { get; init; } = string.Empty;
    public string InfoLink { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public string Required { get; init; } = string.Empty;
}
