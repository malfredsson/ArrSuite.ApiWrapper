namespace ArrSuite.ApiWrapper.Sonarr.V3.Models;

public sealed class Revision
{
    public int Version { get; set; }
    public int Real { get; set; }
    public bool IsRepack { get; set; }
}
