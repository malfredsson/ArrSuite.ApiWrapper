namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class QualityDetails
{
    public Quality Quality { get; init; } = new();
    public Revision Revision { get; init; } = new();
}
