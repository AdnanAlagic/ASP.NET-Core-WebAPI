using System;

namespace API.DTOs
{
    public class AssignmentGetDTO
    {
        public int AssignmentId { get; set; }

        public string AssignmentTitle { get; set; }

        public string AssignmentDescription { get; set; }

        public DateTime AssignmentStartDate { get; set; }

        public DateTime AssignmentEndDate { get; set; }

        public StatusGetDTO StatusAssignment { get; set; }

        public PriorityGetDTO PriorityAssignment { get; set; }

        public UserGetDTO UserAssignment { get; set; }

        public string AssignmentPhotoAttach { get; set; }

        public Boolean AssignmentIsDeleted { get; set; }
    }
}
