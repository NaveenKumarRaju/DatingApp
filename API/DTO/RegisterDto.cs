using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTO
{
    public class RegisterDto
    {
        [Required]
        [StringLength(15, ErrorMessage = "Username should be only 15 characters")]
        public string UserName { get; set;}
        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set;}
    }
}