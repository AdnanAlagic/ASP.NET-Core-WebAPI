using System.Collections.Generic;

namespace API.Models
{
    public class Priority
    {
        public int PriorityId { get; set; }

        public string PriorityTitle{ get; set; }

        public ICollection<Assignment> AssignmentsPriority{ get; set; }
    }
}
