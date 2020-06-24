namespace MongoDbConsolDemo
{
    public class CustomerDatabaseSettings : IDataBaseSettings
    {
        #region Constructor
        public CustomerDatabaseSettings()
        {
            ConnectionString = "mongodb://localhost:27017";
            DatabaseName = "CustomerDb";
            CollectionName = "Customers";
        }
        #endregion

        public string ConnectionString { get; private set; }
        public string DatabaseName { get; private set; }
        public string CollectionName { get; private set; }
    }
}
