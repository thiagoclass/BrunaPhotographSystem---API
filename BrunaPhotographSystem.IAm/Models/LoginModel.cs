﻿using System.ComponentModel.DataAnnotations;

namespace BrunaPhotographSystem.IAm.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Usuário")]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }
    }
}
