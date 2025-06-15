using Models.Enums;

namespace Services.Interfaces
{
    interface ISessionService
    {
        public Task<string> GetSessionIdAsync(SessionType sessionType);
    }
}
