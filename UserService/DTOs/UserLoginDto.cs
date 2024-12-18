﻿using System.ComponentModel.DataAnnotations;

namespace UserService.DTOs
{
    public record UserLoginDTO(
        [Required] string Email,
        [Required] string Password
    );

}
