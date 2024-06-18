using ArrSuite.ApiWrapper.Sonarr.V3.Models.Enums;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Models;

public sealed class Quality
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public QualitySource Source { get; set; }
    public int Resolution { get; set; }
}
