using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeManager.Entities;
using System.Data;

namespace RecipeManager.DataAccess
{
    public abstract class DataRepository
    {
        protected QueryExecuter executer;

        public DataRepository()
        {
            executer = new QueryExecuter();
        }
    }
}
