using apbd_2023_egzamin_s16324.DTOs;
using apbd_2023_egzamin_s16324.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd_2023_egzamin_s16324.Repos
{
    public class TaskRepo : ITaskRepo
    {
        private readonly MainDbContext context;
        public TaskRepo(MainDbContext context)
        {
            this.context = context;
        }

        public async Task<string> AddTask(AddTaskDTO reqBody)
        {
            var RequiredTaskTypeId = reqBody.TaskType.IdTaskType;
            var ExistingTaskType = context.TaskType.Where(e => e.IdTaskType == RequiredTaskTypeId).Any();


            if (!ExistingTaskType)
            {
                await context.AddAsync(new TaskType { IdTaskType = reqBody.TaskType.IdTaskType, Name = reqBody.TaskType.Name });
                //await context.SaveChangesAsync();
                


            }

            await context.AddAsync(new Models.Task { 
                Name = reqBody.Name,
                Description = reqBody.Description,
                Deadline = reqBody.Deadline,
                IdTeam = reqBody.IdTeam,
                IdAssignedTo = reqBody.IsAssignedTo,
                IdCreator = reqBody.IdCreator,
                IdTaskType = RequiredTaskTypeId
            });
            await context.SaveChangesAsync();
            return "Dodano rekord";
        }


    }
}
