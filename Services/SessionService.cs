using Models.Enums;
using Services.Interfaces;

namespace Services
{
    public class SessionService : ISessionService
    {
        private readonly HttpClient _httpClient;
        public SessionService(HttpClient httpClient, Uri uri)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = uri;
        }

        public Task<string> GetSessionIdAsync(SessionType sessionType)
        {
            throw new NotImplementedException();
        }
    }
}
