using System.Text;

namespace Wkxvii.Tools.JsonThemeToCS;

internal static class MaterialColorScheme
{
    internal static void PutMaterialColorSchemeCsCode(in Theme theme, in StringBuilder sb, bool jumpLine = true)
    {
        sb.AppendLine("public static class MaterialColorScheme");
        sb.AppendLine("{");

        PutProperty(nameof(theme.schemes.light.primary), sb);
        PutProperty(nameof(theme.schemes.light.surfaceTint), sb);
        PutProperty(nameof(theme.schemes.light.onPrimary), sb);
        PutProperty(nameof(theme.schemes.light.primaryContainer), sb);
        PutProperty(nameof(theme.schemes.light.onPrimaryContainer), sb);
        PutProperty(nameof(theme.schemes.light.secondary), sb);
        PutProperty(nameof(theme.schemes.light.onSecondary), sb);
        PutProperty(nameof(theme.schemes.light.secondaryContainer), sb);
        PutProperty(nameof(theme.schemes.light.onSecondaryContainer), sb);
        PutProperty(nameof(theme.schemes.light.tertiary), sb);
        PutProperty(nameof(theme.schemes.light.onTertiary), sb);
        PutProperty(nameof(theme.schemes.light.tertiaryContainer), sb);
        PutProperty(nameof(theme.schemes.light.onTertiaryContainer), sb);
        PutProperty(nameof(theme.schemes.light.error), sb);
        PutProperty(nameof(theme.schemes.light.onError), sb);
        PutProperty(nameof(theme.schemes.light.errorContainer), sb);
        PutProperty(nameof(theme.schemes.light.onErrorContainer), sb);
        PutProperty(nameof(theme.schemes.light.background), sb);
        PutProperty(nameof(theme.schemes.light.onBackground), sb);
        PutProperty(nameof(theme.schemes.light.surface), sb);
        PutProperty(nameof(theme.schemes.light.onSurface), sb);
        PutProperty(nameof(theme.schemes.light.surfaceVariant), sb);
        PutProperty(nameof(theme.schemes.light.onSurfaceVariant), sb);
        PutProperty(nameof(theme.schemes.light.outline), sb);
        PutProperty(nameof(theme.schemes.light.outlineVariant), sb);
        PutProperty(nameof(theme.schemes.light.shadow), sb);
        PutProperty(nameof(theme.schemes.light.scrim), sb);
        PutProperty(nameof(theme.schemes.light.inverseSurface), sb);
        PutProperty(nameof(theme.schemes.light.inverseOnSurface), sb);
        PutProperty(nameof(theme.schemes.light.inversePrimary), sb);
        PutProperty(nameof(theme.schemes.light.primaryFixed), sb);
        PutProperty(nameof(theme.schemes.light.onPrimaryFixed), sb);
        PutProperty(nameof(theme.schemes.light.primaryFixedDim), sb);
        PutProperty(nameof(theme.schemes.light.onPrimaryFixedVariant), sb);
        PutProperty(nameof(theme.schemes.light.secondaryFixed), sb);
        PutProperty(nameof(theme.schemes.light.onSecondaryFixed), sb);
        PutProperty(nameof(theme.schemes.light.secondaryFixedDim), sb);
        PutProperty(nameof(theme.schemes.light.onSecondaryFixedVariant), sb);
        PutProperty(nameof(theme.schemes.light.tertiaryFixed), sb);
        PutProperty(nameof(theme.schemes.light.onTertiaryFixed), sb);
        PutProperty(nameof(theme.schemes.light.tertiaryFixedDim), sb);
        PutProperty(nameof(theme.schemes.light.onTertiaryFixedVariant), sb);
        PutProperty(nameof(theme.schemes.light.surfaceDim), sb);
        PutProperty(nameof(theme.schemes.light.surfaceBright), sb);
        PutProperty(nameof(theme.schemes.light.surfaceContainerLowest), sb);
        PutProperty(nameof(theme.schemes.light.surfaceContainerLow), sb);
        PutProperty(nameof(theme.schemes.light.surfaceContainer), sb);
        PutProperty(nameof(theme.schemes.light.surfaceContainerHigh), sb);
        PutProperty(nameof(theme.schemes.light.surfaceContainerHighest), sb);

        sb.AppendCsCodeLine($"private static bool IsDarkMode() => Application.Current!.UserAppTheme == AppTheme.Dark");

        sb.AppendLine("}");
    }

    private static void PutProperty(string nameofProperty, in StringBuilder sb)
    {
        nameofProperty = char.ToUpper(nameofProperty[0]) + nameofProperty[1..];

        sb.AppendCsCodeLine($"public static Color {nameofProperty} => IsDarkMode()", semicolon: false);
        sb.AppendCsCodeLine($"? MaterialColors.{nameofProperty}Dark", indentDepth: 2, semicolon: false);
        sb.AppendCsCodeLine($": MaterialColors.{nameofProperty}Light", indentDepth: 2);
        sb.AppendLine();
    }
}
