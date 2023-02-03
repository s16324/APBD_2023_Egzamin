using apbd_2023_egzamin_s16324.DTOs;
using apbd_2023_egzamin_s16324.Repos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd_2023_egzamin_s16324.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepo _repo;

        public TaskController(ITaskRepo repo)
        {
            this._repo = repo;
        }

        [HttpPost]
        public async Task<IActionResult> AddTask([FromBody] AddTaskDTO reqBody)
        {
            return Ok(await _repo.AddTask(reqBody));
        }



    }
}
