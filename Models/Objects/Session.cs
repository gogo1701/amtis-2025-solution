namespace Models.Objects
{
    public class Session
    {
        public string CompetitorId { get; set; } = "943cb6c0-4367-11f0-bc60-0242ac130003";
        public string SessionType { get; set; } = "test";
        public string GitSHA { get; set; } = "578d574f04fc6e8313c61c7deea9bf63da756db9";

        public string SessionId { get; set; }

        public int DailyClientLimit { get; set; }
        public int WeeklyClientLimit { get; set; }
        public int AllowedTransactionsPer10s { get; set; }
        public int InterchangeFeePercentage { get; set; }

        public float StandardDailyLimit { get; set; }
        public float StandardWeeklyLimit { get; set; }

        public float PremiumDailyLimit { get; set; }
        public float PremiumWeeklyLimit { get; set; }
    }
}
