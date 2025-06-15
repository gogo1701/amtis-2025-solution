using Services;

MainApplication mainApplication = new();

var application = await mainApplication.SessionService.GetSessionIdAsync(Models.Enums.SessionType.test);
Console.WriteLine($"Session ID: {application.SessionId}");

