namespace Wkxvii.Abstractions.Dao;

public class DaoContextConnectionNotInitializedException : Exception
{
    public DaoContextConnectionNotInitializedException() : base("DaoContext Connection not initialized. Did you call DaoContext.Init()?") {}
}
