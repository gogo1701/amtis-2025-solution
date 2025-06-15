using Models.Enums;
using Models.Objects;
using Services.Interfaces;
using System.Text;
using System.Text.Json;

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

        public Task<Session> GetSessionIdAsync(SessionType sessionType)
        {
            Session session = new Session();

            var requestBody = new
            {
                session.SessionId, 
                session.SessionType
            };

            var jsonRequestBody = new StringContent(
                JsonSerializer.Serialize(requestBody),
                Encoding.UTF8,
                "application/json"
            );  

            var response = _httpClient.PostAsync(_httpClient.BaseAddress + "sessions", jsonRequestBody);

            var responseContent = response.Result.Content.ReadAsStringAsync().Result;

            session = JsonSerializer.Deserialize<Session>(responseContent);

            return session.;
        }
    }
}
