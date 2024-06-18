using ArrSuite.ApiWrapper.Tests.Common;
using Dapper;

namespace ArrSuite.ApiWrapper.Radarr.IntegrationTests.V3.Fixtures;

public class RadarrDatabaseFixture()
    : DatabaseFixtureBase("radarr.db", "v3")
{
    public async Task MovieLookupTests()
    {
        await using var connection = CreateConnection;
        await connection.OpenAsync();

        const string movieMetadataSql =
            """
            INSERT INTO MovieMetadata (TmdbId, Images, Title, OriginalLanguage, Status, Runtime, Recommendations)
            VALUES (@TmdbId, @Images, @Title, @OriginalLanguage, @Status, @Runtime, @Recommendations)
            """;

        var movieMetadata = new
        {
            TmdbId = 11,
            Images = "{}",
            Title = "Star wars",
            OriginalLanguage = 1,
            Status = 0,
            Runtime = 120,
            Recommendations = "{}"
        };
        
        const string movieSql =
            """
                INSERT INTO Movies (Path, Monitored, QualityProfileId, MovieFileId, MinimumAvailability, MovieMetadataId)
                VALUES (@Path, @Monitored, @QualityProfileId, @MovieFileId, @MinimumAvailability, @MovieMetadataId)
            """;

        var resss = await connection.ExecuteAsync(movieMetadataSql, movieMetadata);
        
        var movie = new
        {
            Path = "/some/path",
            Monitored = 0,
            QualityProfileId = 1, 
            MovieFileId = 1,
            MinimumAvailability = 1,
            MovieMetadataId = 1
        };

        var resu = await connection.ExecuteAsync(movieSql, movie);
        
        await connection.CloseAsync();
    }
}
