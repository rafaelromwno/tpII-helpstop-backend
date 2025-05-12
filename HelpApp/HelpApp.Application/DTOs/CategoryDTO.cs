using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpApp.Application.DTOs
{
    public class CategoryDTO
    {
        #region Atributos
                
        public int Id { get; set; }

        [Required(ErrorMessage = "Invalid name, name is required.")]
        [MinLength(3, ErrorMessage = "Invalid name, too short, minimum 3 characters.")]
        [MaxLength(100, ErrorMessage = "Invalid name, too long, maximum 100 characters.")]
        public string? Name { get; set; }



        #endregion
    }
}
