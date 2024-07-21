namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDataAccess newDatabase;
            Console.WriteLine("Hello! What kind of database would you like to use? I currently support List, SQL, and Mongo databases.");
            string newData = Console.ReadLine().ToLower();
            newDatabase = DataAccessFactory.GetDataAccessType(newData);
            newDatabase.LoadData();
            newDatabase.SaveData();
        }
    }
}
