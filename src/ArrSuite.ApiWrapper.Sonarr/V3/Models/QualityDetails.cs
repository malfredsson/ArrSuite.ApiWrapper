namespace ArrSuite.ApiWrapper.Sonarr.V3.Models;

public sealed class QualityDetails
{
    public Quality Quality { get; set; } = new();
    public Revision Revision { get; set; } = new();
}
