using System.Collections.ObjectModel;
using ArrSuite.ApiWrapper.Sonarr.V3.Models.Enums;

namespace ArrSuite.ApiWrapper.Sonarr.V3.Models;

public sealed class MediaInfo
{
    public string RawStreamData { get; set; } = string.Empty;
    public string RawFrameData { get; set; } = string.Empty;
    public int SchemaRevision { get; set; }
    public string ContainerFormat { get; set; } = string.Empty;
    public string VideoFormat { get; set; } = string.Empty;
    public string VideoCodecId { get; set; } = string.Empty;
    public string VideoProfile { get; set; } = string.Empty;
    public long VideoBitrate { get; set; }
    public int VideoBitDepth { get; set; }
    public string VideoColourPrimaries { get; set; } = string.Empty;
    public string VideoTransferCharacteristics { get; set; } = string.Empty;
    //public DoviConfigurationRecordSideData DoviConfigurationRecord { get; set; }
    public HdrFormat VideoHdrFormat { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public string AudioFormat { get; set; } = string.Empty;
    public string AudioCodecId { get; set; } = string.Empty;
    public string AudioProfile { get; set; } = string.Empty;
    public long AudioBitrate { get; set; }
    public TimeSpan RunTime { get; set; }
    public int AudioStreamCount { get; set; }
    public int AudioChannels { get; set; }
    public string AudioChannelPositions { get; set; } = string.Empty;
    public decimal VideoFps { get; set; }
    public IReadOnlyCollection<string> AudioLanguages { get; set; } = new Collection<string>();
    public IReadOnlyCollection<string> Subtitles { get; set; } = new Collection<string>();
    public string ScanType { get; set; } = string.Empty;
}
