using System.Collections.ObjectModel;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Models;

public sealed class CustomFormat
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool? IncludeCustomFormatWhenRenaming { get; set; }

    public IReadOnlyCollection<CustomFormatSpecificationSchema> Specifications { get; set; } =
        new Collection<CustomFormatSpecificationSchema>();
}
