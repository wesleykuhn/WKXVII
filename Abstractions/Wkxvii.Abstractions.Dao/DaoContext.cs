using SQLite;

namespace Wkxvii.Abstractions.Dao;

public class DaoContext
{
    public SQLiteAsyncConnection? Connection { get; internal set; }

    public required string DatabaseFilename;

    private readonly Queue<Type> _tablesToValidate = [];
    public string DatabaseFileDirectory => CombineDbDirectory(DatabaseFilename);

    #region [ Static ]

    public static DaoContext? Instance { get; internal set; }

    public static void Init(in string dbFilename)
    {
        Instance = new()
        {
            DatabaseFilename = dbFilename,
            Connection = new(CombineDbDirectory(dbFilename)),
        };
    }

    private static string CombineDbDirectory(in string dbFilename) =>
        Path.Combine(FileSystem.Current.AppDataDirectory, dbFilename);

    public static void AddTableForValidation(in Type tableType)
    {
        if (Instance is null)
            throw new DaoContextNotInitializedException();

        Instance._tablesToValidate.Enqueue(tableType);
    }

    public static void AddTablesForValidation(in IEnumerable<Type> tablesTypes)
    {
        foreach (var item in tablesTypes)
            AddTableForValidation(item);
    }

    public static void ValidateTables()
    {
        if (Instance is null)
            throw new DaoContextNotInitializedException();

        if (Instance.Connection is null)
            Instance.Connection = new(Instance.DatabaseFileDirectory);

        while (Instance._tablesToValidate.Count > 0)
            Instance.Connection.GetConnection().CreateTable(Instance._tablesToValidate.Dequeue());

        Instance._tablesToValidate.Clear();
    }

    #endregion
}
