using MySql.Data.Entity;

namespace FCP.MySql.Data.Entity
{
    public class MySqlEFDbConfiguration : MySqlEFConfiguration
    {
        public MySqlEFDbConfiguration()
        {
            SetHistoryContext(MySqlProviderInvariantName.ProviderName,
                (connection, schema) => new MySqlEFHistoryContext(connection, schema));

            SetTableExistenceChecker(MySqlProviderInvariantName.ProviderName, new MySqlTableExistenceChecker());
        }
    }
}
