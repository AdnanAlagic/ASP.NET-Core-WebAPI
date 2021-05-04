using System.Collections.Generic;

namespace API.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string UserFirstName { get; set; }

        public string UserLastName { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Assignment> Assignments { get; set; }
    }
}
