using BI.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI.Domain.IRepository
{
    public interface IProjectService
    {
        Task<IEnumerable<ProjectDTO>> GetProjects();
        Task<ProjectDTO> GetProject(int id);
        Task<ProjectDTO> CreateProject(CreateProjectDTO createProjectDTO);
        Task<bool> UpdateProject(int id, UpdateProjectDTO updateProjectDTO);
        Task<bool> DeleteProject(int id);
    }
}
