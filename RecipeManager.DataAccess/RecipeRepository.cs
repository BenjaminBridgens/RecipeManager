using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeManager.Entities;
using System.Data;

namespace RecipeManager.DataAccess
{
    public class RecipeRepository : DataRepository
    {

        public List<Recipe> GetAllRecipes()
        {
            string sql = "SELECT * FROM Recipes";
            DataSet set = executer.Execute(sql);
            List<Recipe> recipes = new List<Recipe>(0);
            IngredientRepository ingRepo = new IngredientRepository();
            DataTable table = set.Tables[0];
            foreach(DataRow row in table.Rows )
            {
                int id = (int)row["RecipeId"];
                string name = (string)row["RecipeName"];
                List<Ingredient> ingList = ingRepo.GetIngredientsFor(idd: id);
                int persons = (int)row["Persons"];
                Recipe r = new Recipe(name, ingList, persons, id);

                recipes.Add(r);
            }

            return recipes;
        }

































    }
}
