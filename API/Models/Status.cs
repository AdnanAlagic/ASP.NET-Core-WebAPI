using System.Collections.Generic;

namespace API.Models
{
    public class Status
    {
        public int StatusId { get; set; }

        public string StatusTitle { get; set; }

        public ICollection<Assignment> AssignmentsStatus { get; set; }
    }
}
