using System;

namespace NTL.Infrastructure.Logger
{
    public class EmailLog
    {
        public EmailLog()
        {
            CreateDate = DateTime.Now;
            SendAt = DateTime.Now;
        }

        public long Id { get; set; }
        public string EmailTo { get; set; }
        public string EmailCc { get; set; }
        public string EmailBcc { get; set; }
        public DateTime CreateDate { get; set; }
        public string Subject { get; set; }
        public string DisplayName { get; set; }
        public SentStatus SentStatus { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime SendAt { get; set; }

        public virtual EmailBody EmailBody { get; set; }
    }

    public class EmailBody
    {
        public long Id { get; set; }
        public string Body { get; set; }

        public virtual EmailLog EmailLog { get; set; }
    }

    public enum SentStatus
    {
        Waiting,
        Sending,
        Ok,
        Error
    }
}
