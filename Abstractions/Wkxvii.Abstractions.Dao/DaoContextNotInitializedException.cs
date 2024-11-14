namespace Wkxvii.Abstractions.Dao;

public class DaoContextNotInitializedException : Exception
{
    public DaoContextNotInitializedException() : base("DaoContext not initialized. Did you call DaoContext.Init()?") {}
}
