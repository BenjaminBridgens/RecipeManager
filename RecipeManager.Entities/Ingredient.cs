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
        private decimal price;
        private string name;
        private IngredientKind kind;
        private readonly int id;
        #endregion

        #region Constructors
        public Ingredient(decimal price, string name, IngredientKind kind)
        {
            Price = price;
            Name = name;
            Kind = kind;
        }
        public Ingredient(decimal price, string name, IngredientKind kind, int id)
        {
            Price = price;
            Name = name;
            Kind = kind;
            this.id = id;
        }
        #endregion

        #region Properties
        public decimal Price { get => price; set => price = value; }
        public string Name { get => name; set => name = value; }
        public IngredientKind Kind { get => kind; set => kind = value; }
        public int Id => id;
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{name} is a {kind} and it kosts: {price}.";
        }
        #endregion
    }
}
