using System;

namespace API.Models
{
    public class Assignment
    {
        public Assignment()
        {
            this.AssignmentIsDeleted = false;
        }

        public int AssignmentId { get; set; }

        public string AssignmentTitle { get; set; }

        public string  AssignmentDescription{ get; set; }

        public DateTime AssignmentStartDate { get; set; }

        public DateTime AssignmentEndDate { get; set; }

        public int AssignmentStatusId { get; set; }

        public Status StatusAssignment { get; set; }

        public int AssignmentPriorityId { get; set; }

        public Priority PriorityAssignment { get; set; }

        public int AssignmentUserId { get; set; }

        public User UserAssignment{ get; set; }

        public string AssignmentPhotoAttach { get; set; }

        public Boolean AssignmentIsDeleted { get; set; }
    }
}
