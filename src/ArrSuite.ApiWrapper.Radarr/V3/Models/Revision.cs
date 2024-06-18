namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class Revision
{
    public int Real { get; init; }
    public int Version { get; init; }
    public string Modifier { get; init; } = string.Empty;
}
