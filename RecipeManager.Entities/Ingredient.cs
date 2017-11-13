using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.Entities
{
    public class Ingredient
    {
        #region Fields
        private readonly int id;
        private string name;
        private IngredientKind kind;
        private decimal price;
        #endregion

        #region Constructors
        public Ingredient(decimal price, string name, IngredientKind kind, int id)
        {
            this.id = id;
            Name = name;
            Kind = kind;
            Price = price;
        }
        public Ingredient(decimal price, string name, IngredientKind kind)
        {
            Price = price;
            Name = name;
            Kind = kind;
        }
        #endregion

        #region Properties
        public int Id => id;
        public string Name { get => name; set => name = value; }
        public IngredientKind Kind { get => kind; set => kind = value; }
        public decimal Price { get => price; set => price = value; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{name} is a {kind} and it kosts: {price}.";
        }
        #endregion
    }
}
