namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class Ratings
{
    public Rating Imdb { get; init; } = new();
    public Rating Metacritic { get; init; } = new();
    public Rating RottenTomatoes { get; init; } = new();
    public Rating Tmdb { get; init; } = new();
}
