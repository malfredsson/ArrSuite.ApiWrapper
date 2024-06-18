namespace ArrSuite.ApiWrapper.V3;

public abstract class ArrSuiteV3ApiClient(string url, string apiKey) :
    ArrSuiteApiClient(url, "v3", apiKey);