namespace ArrSuite.ApiWrapper.Sonarr.V3.Models;

public sealed class AlternateTitle
{
    public string Title { get; set; } = string.Empty;
    public int? SeasonNumber { get; set; }
    public int? SceneSeasonNumber { get; set; }
    public string SceneOrigin { get; set; } = string.Empty;
    public string Comment { get; set; } = string.Empty;
}
