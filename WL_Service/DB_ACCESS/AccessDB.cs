using System.Data.OleDb;

namespace WL_Service.DB_ACCESS
{
    public class AccessDB
    {
        private readonly string _connectionString;

        public AccessDB()
        {
            string databasePath = Path.Combine(AppContext.BaseDirectory, "DataBase", "WatchListDataBase.accdb");

            _connectionString =
                $"Provider=Microsoft.ACE.OLEDB.12.0;" +
                $"Data Source={databasePath};";
        }

        public OleDbConnection GetConnection()
        {
            return new OleDbConnection(_connectionString);
        }
    }
}
