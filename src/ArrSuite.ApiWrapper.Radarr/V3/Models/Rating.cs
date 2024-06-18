using ArrSuite.ApiWrapper.Radarr.V3.Models.Enums;

namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class Rating
{
    public double Value { get; init; }
    public long Votes { get; init; }
    public RatingType Type { get; init; }
}
