using Newtonsoft.Json;
using Wkxvii.Tools.JsonThemeToCS;

static char? MainMenu()
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("1. Paste JSON text.");
    Console.WriteLine("2. Select a file to extract.");
    var typed = Console.ReadKey();
    if (typed.KeyChar != '1' && typed.KeyChar != '2')
    {
        Console.Clear();
        Console.WriteLine("Invalid input.");
        Thread.Sleep(1500);
        return null;
    }

    return typed.KeyChar;
}

static Theme? HandleJsonPaste()
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

static Theme? HandleFileSelect()
{
    Console.Clear();
    Console.WriteLine("Paste JSON text:");

    var json = Console.ReadLine();
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

char? option = null;
while (option is null)
    option = MainMenu();

Theme? themeDeserialized = null;
while (themeDeserialized is null)
    themeDeserialized = option == '1'
        ? HandleJsonPaste()
        : HandleFileSelect();

var a = 10;
