using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd_2023_egzamin_s16324.DTOs
{
    public class ProjectDTO
    {
        public int? IdProject { get; set; }
        public string Name { get; set; }
        public DateTime? Deadline { get; set; }
        public IEnumerable<TaskDTO> Tasks { get; set; }
    }
}
