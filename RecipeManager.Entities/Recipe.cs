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
        private int persons;
        private readonly int id;
        #endregion

        #region Constructors
        public Recipe(string name, List<Ingredient> ingredients,int persons)
        {
            Name = name;
            Ingredients = this.ingredients;
            Persons = persons;
        }
        public Recipe(string name, List<Ingredient> ingredients, int persons, int id)
        {
            Name = name;
            Ingredients = ingredients;
            Persons = persons;
            this.id = id;
        }
        #endregion

        #region Properties
        public string Name { get => name; set => name = value; }        
        public List<Ingredient> Ingredients { get => ingredients; set => ingredients = value; }
        public int Persons { get => persons; set => persons = value; }
        public int Id { get => id; }
        #endregion

        #region Methods
        public decimal GetPrice()
        {
            decimal price = 0;

            foreach(Ingredient Ing in Ingredients )
            {
                price += Ing.Price;
            }
            return price;
        }

        public override string ToString()
        {
            return $"{name} ";
        }
        #endregion

    }
}
