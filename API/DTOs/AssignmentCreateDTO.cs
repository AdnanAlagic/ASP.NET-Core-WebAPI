using System;

namespace API.DTOs
{
    public class AssignmentCreateDTO
    {
        public string AssignmentTitle { get; set; }

        public string AssignmentDescription { get; set; }

        public DateTime AssignmentStartDate { get; set; }

        public DateTime AssignmentEndDate { get; set; }

        public int AssignmentStatusId { get; set; }

        public int AssignmentPriorityId { get; set; }

        public int AssignmentUserId { get; set; }

        public string AssignmentPhotoAttach { get; set; }
    }
}
