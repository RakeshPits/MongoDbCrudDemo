namespace MongoDbConsolDemo
{
    public interface IDataBaseSettings
    {
        string ConnectionString { get; }
        string DatabaseName { get; }
        string CollectionName { get; }
    }    
}
