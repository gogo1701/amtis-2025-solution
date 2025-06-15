using Models.Enums;
using Models.Objects;
using Services.Interfaces;
using System.Net.Http.Json;

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

        public async Task<Session> GetSessionIdAsync(SessionType sessionType)
        {
            var session = new Session
            {
                SessionType = sessionType.ToString().ToLowerInvariant()
            };

            var response = await _httpClient.PostAsJsonAsync("sessions", session);

            var responseContent = await response.Content.ReadFromJsonAsync<Session>();

            session.SessionId = responseContent.SessionId;
            session.DailyClientLimit = responseContent.DailyClientLimit;
            session.WeeklyClientLimit = responseContent.WeeklyClientLimit;
            session.AllowedTransactionsPer10s = responseContent.AllowedTransactionsPer10s;
            session.InterchangeFeePercentage = responseContent.InterchangeFeePercentage;
            session.StandardDailyLimit = responseContent.StandardDailyLimit;
            session.StandardWeeklyLimit = responseContent.StandardWeeklyLimit;
            session.PremiumDailyLimit = responseContent.PremiumDailyLimit;
            session.PremiumWeeklyLimit = responseContent.PremiumWeeklyLimit;

            return session;
        }
    }
}
