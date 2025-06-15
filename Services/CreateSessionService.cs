namespace Services
{
    public class CreateSessionService
    {
        HttpClient _httpClient;
        public CreateSessionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public CreateSessionService()
        {

        }
    }
}
