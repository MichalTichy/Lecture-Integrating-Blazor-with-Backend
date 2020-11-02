﻿using CookBook.Models;
using EnumsNET;

namespace CookBook.Models
{
    public class RecipeDetailIngredientModel
    {
        public IngredientListModel Ingredient { get; set; } =new IngredientListModel();
        public double Amount { get; set; }
        public Unit Unit { get; set; }
        public string UnitText => Unit.AsString(EnumFormat.Description);
    }
}