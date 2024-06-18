namespace ArrSuite.ApiWrapper.Radarr.V3.Models;

public sealed class MediaInfo
{
    public int AudioBitrate { get; init; }
    public int AudioChannels { get; init; }
    public int AudioStreamCount { get; init; }
    public int Id { get; init; }
    public int VideoBitDepth { get; init; }
    public int VideoBitrate { get; init; }
    public int VideoFps { get; init; }
    public string AudioCodec { get; init; } = string.Empty;
    public string AudioLanguages { get; init; } = string.Empty;
    public string Resolution { get; init; } = string.Empty;
    public string RunTime { get; init; } = string.Empty;
    public string ScanType { get; init; } = string.Empty;
    public string Subtitles { get; init; } = string.Empty;
    public string VideoCodec { get; init; } = string.Empty;
    public string VideoDynamicRange { get; init; } = string.Empty;
    public string VideoDynamicRangeType { get; init; } = string.Empty;
}
