using apbd_2023_egzamin_s16324.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apbd_2023_egzamin_s16324.Repos
{
    public interface IProjectRepo
    {

        Task<ProjectDTO> GetProject(int id);
    }
}
