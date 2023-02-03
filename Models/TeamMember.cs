using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd_2023_egzamin_s16324.Models
{
    public class TeamMember
    {
        public TeamMember()
        {
            Tasks = new HashSet<Task>();
        }
        public int IdTeamMember { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
