using System.Text;
using Wkxvii.Tools.JsonThemeToCS;

static char? MainMenu()
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("1. Paste JSON text.");
    Console.WriteLine("2. Put JSON file full path.");
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

static string ThemeToCsCode(in Theme theme)
{
    StringBuilder sb = new();
    MaterialColors.PutMaterialColorsCsCode(theme, sb);
    sb.AppendLine();
    sb.AppendLine("---------------------------------------------------------------------------");
    sb.AppendLine();
    MaterialColorScheme.PutMaterialColorSchemeCsCode(theme, sb);
    return sb.ToString();
}

char? option = null;
while (option is null)
    option = MainMenu();

Theme? theme = null;
while (theme is null)
    theme = option == '1'
        ? JsonResolvers.ResolveJsonPaste()
        : JsonResolvers.ResolveFileSelect();

Console.Clear();

try
{
    var csCode = ThemeToCsCode(theme);
    Console.WriteLine(csCode);
}
catch (Exception)
{
    Console.WriteLine("Error while building the CS code!");
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
