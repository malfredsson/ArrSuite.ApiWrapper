using System.Collections.ObjectModel;

namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class CustomFormat
{
    public IReadOnlyCollection<CustomFormatSpecification> Specifications { get; init; } =
        new Collection<CustomFormatSpecification>();
    public bool? IncludeCustomFormatWhenRenaming { get; init; }
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
}
