namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class SelectOption
{
    public bool DividerAfter { get; init; }
    public int Order { get; init; }
    public int Value { get; init; }
    public string Hint { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
}
