using Models.Enums;
using Models.Objects;

namespace Services.Interfaces
{
    interface ISessionService
    {
        public Task<Session> GetSessionIdAsync(SessionType sessionType);
    }
}
