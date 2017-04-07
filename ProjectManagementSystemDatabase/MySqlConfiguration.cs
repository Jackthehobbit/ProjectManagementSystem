using System.Data.Entity;
namespace DbBackedTextAdventure
{
    class MySqlConfiguration : DbConfiguration
    {
        public MySqlConfiguration()
        {
            SetHistoryContext("MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));
        }
        
    }
}
