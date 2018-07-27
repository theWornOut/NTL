using System;

namespace NTL.Presentation.Models
{
    public class TaskModels
    {
        public int Id { get; set; }
        public int TodoId { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public bool? Reminder { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public virtual TodoModels TodoEntity { get; set; }
    }
}