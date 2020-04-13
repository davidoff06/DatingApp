﻿using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForLoginDto
    {
        [Required]
        public string UserName { get; set; }
        
        
        public string Password { get; set; }
    }
}
