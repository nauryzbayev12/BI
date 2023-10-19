using BI.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BI.Domain.DTOs
{
    public class CreateProjectDTO
    {
        /// <summary>
        /// Название проекта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Дата и время создания
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// ID пользователя 
        /// </summary>  
        public string UserId { get; set; }
       
    }

    public class UpdateProjectDTO : CreateProjectDTO
    {
        
    }

    public class ProjectDTO : CreateProjectDTO
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Почта
        /// </summary>
        public string Email { get; set; }


    }



}
