using ArrSuite.ApiWrapper.Tests.Common;
using Dapper;

namespace ArrSuite.ApiWrapper.Lidarr.IntegrationTests.V1.Fixtures;

public class LidarrDatabaseFixture() : DatabaseFixtureBase("lidarr.db", "v1")
{
    public async Task AddAlbum()
    {
        const string sql =
            """
                INSERT INTO Albums (ForeignAlbumId, Title, CleanTitle, Images, Monitored, AlbumType, ArtistMetadataId,
                                    AnyReleaseOk, OldForeignAlbumIds)
                    VALUES(@ForeignAlbumId, @Title, @CleanTitle, @Images, @Monitored, @AlbumType, @ArtistMetadataId,
                           @AnyReleaseOk, @OldForeignAlbumIds)
            """;

        var album = new
        {
          ForeignAlbumId = "",
          Title = "No Line on the Horizon",
          CleanTitle = "nolineonhorizon",
          Images = "{}",
          Monitored = 0,
          AlbumType = "",
          ArtistMetadataId = 1,
          AnyReleaseOk = 1,
          OldForeignAlbumIds = ""
        };

        var connection = CreateConnection;
        await connection.OpenAsync();

        var rows = await connection.ExecuteAsync(sql, album);
    }
}
