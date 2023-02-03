using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd_2023_egzamin_s16324.Models
{
    public class Project
    {
        public Project()
        {
            Tasks = new HashSet<Task>();
        }
        public int IdTeam { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        
    }
}
