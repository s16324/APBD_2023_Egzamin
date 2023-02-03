using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd_2023_egzamin_s16324.DTOs
{
    public class AddTaskDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public int IdTeam { get; set; }
        public int IsAssignedTo { get; set; }
        public int IdCreator { get; set; }
        public TaskTypeDTO TaskType { get; set; }
    }
}
