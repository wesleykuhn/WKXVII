using System.Text;

namespace Wkxvii.Tools.JsonThemeToCS;

internal static class Extensions
{
    internal static void AppendCsCodeLine(this StringBuilder sb, in string code, int indentDepth = 1, bool semicolon = true)
    {
        for (int i = 0; i < indentDepth; i++)
            sb.Append("    ");

        sb.Append(code);

        if (semicolon)
            sb.AppendLine(";");
        else
            sb.AppendLine();
    }
}
