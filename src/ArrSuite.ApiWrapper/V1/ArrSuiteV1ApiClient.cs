namespace ArrSuite.ApiWrapper.V1;

public abstract class ArrSuiteV1ApiClient(string url, string apiKey) :
    ArrSuiteApiClient(url, "v1", apiKey);