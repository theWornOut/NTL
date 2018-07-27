using System;

namespace NTL.Infrastructure.Logger
{
    public class ActionLog
    {
        public Guid ActionLogId { get; set; }
        public string UserRole { get; set; }
        public string UserName { get; set; }
        public string ClientLoggedInUser { get; set; }
        public string UserFullName { get; set; }
        public DateTime DateTimeUtc { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Request { get; set; }
        public string ComputerName { get; set; }
        public string IpAddress { get; set; }
        public string HttpMethod { get; set; }
        public string Parameters { get; set; }
        public string UserAgent { get; set; }
        public string BrowserName { get; set; }
        public string BrowserVersion { get; set; }
        public string SessionId { get; set; }
    }
}