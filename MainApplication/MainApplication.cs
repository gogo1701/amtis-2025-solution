using Services;
public class MainApplication
{
    private readonly HttpClient _httpClient;
    private readonly Uri _baseUri;
    private readonly SessionService _sessionService;

    public MainApplication()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = _baseUri
        };

        _baseUri = new Uri("https://competition-engine-production.up.railway.app/");
        _sessionService = new SessionService(_httpClient, _baseUri);
    }

    public SessionService SessionService => _sessionService;
}
