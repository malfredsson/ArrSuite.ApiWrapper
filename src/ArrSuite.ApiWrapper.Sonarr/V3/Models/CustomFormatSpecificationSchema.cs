using System.Collections.ObjectModel;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Models;

public sealed class CustomFormatSpecificationSchema
{
    public string Name { get; set; } = string.Empty;
    public string Implementation { get; set; } = string.Empty;
    public string ImplementationName { get; set; } = string.Empty;
    public string InfoLink { get; set; } = string.Empty;
    public bool Negate { get; set; }
    public bool Required { get; set; }
    public IReadOnlyCollection<CustomFormatSpecificationSchema> Presets { get; set; } =
        new Collection<CustomFormatSpecificationSchema>();
}
