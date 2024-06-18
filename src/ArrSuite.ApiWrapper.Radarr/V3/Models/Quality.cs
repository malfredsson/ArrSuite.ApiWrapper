using ArrSuite.ApiWrapper.Radarr.V3.Models.Enums;

namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class Quality
{
    public int Id { get; init; }
    public int Resolution { get; init; }
    public Modifier Modifier { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Source { get; init; } = string.Empty;
}
