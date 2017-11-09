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



















































    }
}
