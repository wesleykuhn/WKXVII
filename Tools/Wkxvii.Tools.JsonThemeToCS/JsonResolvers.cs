using Newtonsoft.Json;

namespace Wkxvii.Tools.JsonThemeToCS;

internal static class JsonResolvers
{
    internal static Theme? ResolveJsonPaste()
    {
        Console.Clear();
        Console.WriteLine("Paste JSON text (Double press on ENTER after paste):");

        string json = string.Empty;
        string line = string.Empty;
        while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
            json += line;

        if (string.IsNullOrWhiteSpace(json))
        {
            Console.Clear();
            Console.WriteLine("Invalid input.");
            Thread.Sleep(1500);
            return null;
        }

        var theme = JsonConvert.DeserializeObject<Theme>(json);
        if (theme is null)
        {
            Console.Clear();
            Console.WriteLine("Invalid JSON.");
            Thread.Sleep(1500);
            return null;
        }

        return theme;
    }

    internal static Theme? ResolveFileSelect()
    {
        Console.Clear();
        Console.WriteLine("Insert the JSON file full path:");

        try
        {
            var path = Console.ReadLine();
            if (!File.Exists(path))
                throw new Exception("Invalid path.");

            var json = File.ReadAllText(path);
            var theme = JsonConvert.DeserializeObject<Theme>(json) ?? throw new InvalidDataException();
            return theme;
        }
        catch (Exception)
        {
            Console.Clear();
            Console.WriteLine("Invalid path, access to file was denied or corrupted file.");
            Thread.Sleep(1500);
            return null;
        }
    }
}
