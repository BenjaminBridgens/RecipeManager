using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeManager.DataAccess;
using System.Data;

namespace RecipeManager.Tests
{
    [TestClass]
    public class QueryExecutorTests
    {
        [TestMethod]
        public void ConnectionTest()
        {
            // Arrenge:
            QueryExecuter q;

            // Act:
            q = new QueryExecuter();

            // Assert:
            Assert.IsNotNull(q);
        }

        [TestMethod]
        public void ExecutePasses()
        {
            // Arrange:
            string sql = "SELECT TOP 1 (RecipeName) FROM Recipes";
            QueryExecuter executer = new QueryExecuter();
            int expectedRows = 1;
            int actualRows;
            DataSet resultSet = new DataSet();

            // Act:
            resultSet = executer.Execute(sql);
            actualRows = resultSet.Tables[0].Rows.Count;

            // Assert:
            Assert.AreEqual(expectedRows, actualRows);
        }
















































    }
}
