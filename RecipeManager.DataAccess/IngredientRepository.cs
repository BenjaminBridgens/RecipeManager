using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeManager.Entities;
using System.Data;

namespace RecipeManager.DataAccess
{
    public class IngredientRepository: DataRepository
    {
        public List<Ingredient> GetAllIngredients()
        {
            string sql = $"SELECT * FROM Ingredients";
            DataSet set = executer.Execute(sql);
            List<Ingredient> allIngredients = new List<Ingredient>(0);
            DataTable table = set.Tables[0];
            foreach(DataRow row in table.Rows )
            {
                int id = (int)row["IngredientId"];
                string name = (string)row["IngredientName"];
                decimal price = (decimal)row["Price"];
                string kind = (string)row["IngredientType"];
                IngredientKind iK = (IngredientKind)Enum.Parse(typeof(IngredientKind), ((string)row["IngredientType"]).Trim());
                Ingredient i = new Ingredient(price, name, iK, id);

                allIngredients.Add(i);
            }

            return allIngredients;
        }













    }
}
