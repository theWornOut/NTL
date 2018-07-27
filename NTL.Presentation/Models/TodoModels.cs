using System.Collections.Generic;

namespace NTL.Presentation.Models
{
    public class TodoModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

        public virtual ICollection<TaskModels> TaskModels { get; set; }
    }
}