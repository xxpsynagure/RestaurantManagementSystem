﻿using MenuService.Models;

namespace MenuService.DTOs
{
    public class CategoryResponseDTO
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

    }

}
