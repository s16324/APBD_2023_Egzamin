using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd_2023_egzamin_s16324.Models
{
    public class Task
    {
        public int IdTask { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public int IdTeam { get; set; }
        public int IdTaskType { get; set; }
        public int IdAssignedTo { get; set; }
        public int IdCreator { get; set; }
        public virtual Project IdProjectNavigation { get; set; }
        public virtual TeamMember IdTeamMemberNavigation { get; set; }
        public virtual TaskType IdTaskTypeNavigation { get; set; }
    }
}
