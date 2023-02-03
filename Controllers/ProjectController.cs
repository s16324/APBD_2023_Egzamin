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
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepo _repo;

        public ProjectController(IProjectRepo repo)
        {
            this._repo = repo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProject(int id)
        {

            return Ok(await _repo.GetProject(id));

        }

    }
}
