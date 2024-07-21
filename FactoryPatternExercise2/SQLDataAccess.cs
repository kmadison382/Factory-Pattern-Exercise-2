using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public string Name {get; set;} = "SQL";
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from a {Name} database");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a {Name} database");
        }
    }
}