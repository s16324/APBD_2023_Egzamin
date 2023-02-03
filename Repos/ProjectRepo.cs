using apbd_2023_egzamin_s16324.DTOs;
using apbd_2023_egzamin_s16324.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd_2023_egzamin_s16324.Repos
{
    public class ProjectRepo : IProjectRepo
    {
        private readonly MainDbContext context;
        public ProjectRepo(MainDbContext context)
        {
            this.context = context;
        }

        public async Task<ProjectDTO> GetProject(int id)
        {
            //var project = await context.Prescription.FindAsync(id);
            var project = await context.Project.FindAsync(id);

            if(project != null)
            {
                ProjectDTO pro = await context.Project.Where(e => e.IdTeam == id).Select(e => new ProjectDTO
                {
                    IdProject = e.IdTeam,
                    Name = e.Name,
                    Deadline = e.Deadline,
                    Tasks = e.Tasks.Select(e => new TaskDTO { IdTask = e.IdTask, Name = e.Name, Description = e.Description, Deadline = e.Deadline, TaskType=e.IdTaskTypeNavigation.Name })
                }).FirstAsync();

                return pro;
            }
            else
            {
                return null;
            }
        }
    }
}
