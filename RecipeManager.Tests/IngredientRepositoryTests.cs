using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeManager.DataAccess;
using RecipeManager.Entities;
using System.Collections.Generic;

namespace RecipeManager.Tests
{
    [TestClass]
    public class IngredientRepositoryTests
    {
        [TestMethod]
        public void GetAllIngredientsPasses()
        {
            // Arrange:
            bool expected = true;
            bool actual;
            IngredientRepository ingRepo = new IngredientRepository();

            // Act:
            List<Ingredient> ingredients = ingRepo.GetAllIngredients();

            // Assert:
            if(ingredients.Count > 0 )
            {
                actual = true;
            }
            else
            {
                actual = false;
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
