using AutoMapper;
using BI.Core;
using BI.Database.DatabaseContexts;
using BI.Domain.DTOs;
using BI.Domain.Exceptions;
using BI.Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI.Infrastructure.Repository
{
    public class ProjectService : IProjectService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        public ProjectService(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<IEnumerable<ProjectDTO>> GetProjects(DateTime? from, DateTime? to)
        {
            var projects =  await _context.Projects.Include(s => s.ApplicationUser).ToListAsync();

            if (from != null) 
            {
                projects = projects.Where(s => s.Created >= from).ToList();
            }
            if (to != null)
            {
                projects = projects.Where(s => s.Created <= to).ToList();
            }

            return _mapper.Map<IEnumerable<ProjectDTO>>(projects);
        }

        public async Task<ProjectDTO> GetProject(int id)
        {
            var project = await _context.Projects.FindAsync(id);

            if (project == null)
            {
                throw new EntityNotFoundException($"Project with Id {id} does not exist");
            }

            return _mapper.Map<ProjectDTO>(project);
        }

        public async Task<ProjectDTO> CreateProject(CreateProjectDTO createProjectDTO)
        {
            var project = _mapper.Map<Project>(createProjectDTO);

            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            return _mapper.Map<ProjectDTO>(project);
        }

        public async Task<bool> UpdateProject(int id, UpdateProjectDTO updateProjectDTO)
        {
            var project = await _context.Projects.FindAsync(id);

            if (project == null)
            {
                throw new EntityNotFoundException($"Project with Id {id} does not exist");
            }

            _mapper.Map(updateProjectDTO, project);

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteProject(int id)
        {
            var project = await _context.Projects.FindAsync(id);

            if (project == null)
            {
                throw new EntityNotFoundException($"Project with Id {id} does not exist");
            }

            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();

            return true;
        }


    }
}
