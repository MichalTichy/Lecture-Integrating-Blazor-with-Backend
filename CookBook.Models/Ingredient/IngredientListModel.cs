﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CookBook.Models
{
    public class IngredientListModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}