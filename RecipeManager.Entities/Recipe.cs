using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Entities
{
    public class Recipe
    {
        #region Fields
        private string name;
        private List<Ingredient> ingredients;
        private int recipeID;
        #endregion

        #region Constructors
        public Recipe(string name, List<Ingredient> ingredints, int recipeID)
        {
            Name = name;
            Ingredients = ingredients;
            RecipeID = recipeID;
        }
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }
        public int RecipeID { get => recipeID; set => recipeID = value; }
        public List<Ingredient> Ingredients { get => ingredients; set => ingredients = value; }
        #endregion

        #region Methods

        #endregion

    }
}
