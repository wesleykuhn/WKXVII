using System.Text;

namespace Wkxvii.Tools.JsonThemeToCS;

internal static class MaterialColors
{
    internal static void PutMaterialColorsCsCode(in Theme theme, in StringBuilder sb)
    {
        sb.AppendLine("public static class MaterialColors");
        sb.AppendLine("{");

        // Light colors
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.primary), theme.schemes.light.primary));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.surfaceTint), theme.schemes.light.surfaceTint));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onPrimary), theme.schemes.light.onPrimary));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.primaryContainer), theme.schemes.light.primaryContainer));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onPrimaryContainer), theme.schemes.light.onPrimaryContainer));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.secondary), theme.schemes.light.secondary));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onSecondary), theme.schemes.light.onSecondary));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.secondaryContainer), theme.schemes.light.secondaryContainer));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onSecondaryContainer), theme.schemes.light.onSecondaryContainer));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.tertiary), theme.schemes.light.tertiary));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onTertiary), theme.schemes.light.onTertiary));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.tertiaryContainer), theme.schemes.light.tertiaryContainer));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onTertiaryContainer), theme.schemes.light.onTertiaryContainer));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.error), theme.schemes.light.error));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onError), theme.schemes.light.onError));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.errorContainer), theme.schemes.light.errorContainer));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onErrorContainer), theme.schemes.light.onErrorContainer));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.background), theme.schemes.light.background));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onBackground), theme.schemes.light.onBackground));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.surface), theme.schemes.light.surface));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onSurface), theme.schemes.light.onSurface));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.surfaceVariant), theme.schemes.light.surfaceVariant));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onSurfaceVariant), theme.schemes.light.onSurfaceVariant));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.outline), theme.schemes.light.outline));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.outlineVariant), theme.schemes.light.outlineVariant));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.shadow), theme.schemes.light.shadow));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.scrim), theme.schemes.light.scrim));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.inverseSurface), theme.schemes.light.inverseSurface));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.inverseOnSurface), theme.schemes.light.inverseOnSurface));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.inversePrimary), theme.schemes.light.inversePrimary));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.primaryFixed), theme.schemes.light.primaryFixed));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onPrimaryFixed), theme.schemes.light.onPrimaryFixed));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.primaryFixedDim), theme.schemes.light.primaryFixedDim));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onPrimaryFixedVariant), theme.schemes.light.onPrimaryFixedVariant));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.secondaryFixed), theme.schemes.light.secondaryFixed));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onSecondaryFixed), theme.schemes.light.onSecondaryFixed));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.secondaryFixedDim), theme.schemes.light.secondaryFixedDim));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onSecondaryFixedVariant), theme.schemes.light.onSecondaryFixedVariant));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.tertiaryFixed), theme.schemes.light.tertiaryFixed));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onTertiaryFixed), theme.schemes.light.onTertiaryFixed));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.tertiaryFixedDim), theme.schemes.light.tertiaryFixedDim));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.onTertiaryFixedVariant), theme.schemes.light.onTertiaryFixedVariant));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.surfaceDim), theme.schemes.light.surfaceDim));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.surfaceBright), theme.schemes.light.surfaceBright));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.surfaceContainerLowest), theme.schemes.light.surfaceContainerLowest));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.surfaceContainerLow), theme.schemes.light.surfaceContainerLow));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.surfaceContainer), theme.schemes.light.surfaceContainer));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.surfaceContainerHigh), theme.schemes.light.surfaceContainerHigh));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.light.surfaceContainerHighest), theme.schemes.light.surfaceContainerHighest));
        sb.AppendLine();
        // Dark colors
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.primary), theme.schemes.dark.primary, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.surfaceTint), theme.schemes.dark.surfaceTint, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onPrimary), theme.schemes.dark.onPrimary, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.primaryContainer), theme.schemes.dark.primaryContainer, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onPrimaryContainer), theme.schemes.dark.onPrimaryContainer, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.secondary), theme.schemes.dark.secondary, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onSecondary), theme.schemes.dark.onSecondary, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.secondaryContainer), theme.schemes.dark.secondaryContainer, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onSecondaryContainer), theme.schemes.dark.onSecondaryContainer, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.tertiary), theme.schemes.dark.tertiary, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onTertiary), theme.schemes.dark.onTertiary, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.tertiaryContainer), theme.schemes.dark.tertiaryContainer, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onTertiaryContainer), theme.schemes.dark.onTertiaryContainer, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.error), theme.schemes.dark.error, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onError), theme.schemes.dark.onError, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.errorContainer), theme.schemes.dark.errorContainer, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onErrorContainer), theme.schemes.dark.onErrorContainer, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.background), theme.schemes.dark.background, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onBackground), theme.schemes.dark.onBackground, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.surface), theme.schemes.dark.surface, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onSurface), theme.schemes.dark.onSurface, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.surfaceVariant), theme.schemes.dark.surfaceVariant, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onSurfaceVariant), theme.schemes.dark.onSurfaceVariant, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.outline), theme.schemes.dark.outline, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.outlineVariant), theme.schemes.dark.outlineVariant, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.shadow), theme.schemes.dark.shadow, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.scrim), theme.schemes.dark.scrim, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.inverseSurface), theme.schemes.dark.inverseSurface, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.inverseOnSurface), theme.schemes.dark.inverseOnSurface, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.inversePrimary), theme.schemes.dark.inversePrimary, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.primaryFixed), theme.schemes.dark.primaryFixed, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onPrimaryFixed), theme.schemes.dark.onPrimaryFixed, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.primaryFixedDim), theme.schemes.dark.primaryFixedDim, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onPrimaryFixedVariant), theme.schemes.dark.onPrimaryFixedVariant, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.secondaryFixed), theme.schemes.dark.secondaryFixed, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onSecondaryFixed), theme.schemes.dark.onSecondaryFixed, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.secondaryFixedDim), theme.schemes.dark.secondaryFixedDim, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onSecondaryFixedVariant), theme.schemes.dark.onSecondaryFixedVariant, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.tertiaryFixed), theme.schemes.dark.tertiaryFixed, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onTertiaryFixed), theme.schemes.dark.onTertiaryFixed, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.tertiaryFixedDim), theme.schemes.dark.tertiaryFixedDim, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.onTertiaryFixedVariant), theme.schemes.dark.onTertiaryFixedVariant, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.surfaceDim), theme.schemes.dark.surfaceDim, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.surfaceBright), theme.schemes.dark.surfaceBright, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.surfaceContainerLowest), theme.schemes.dark.surfaceContainerLowest, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.surfaceContainerLow), theme.schemes.dark.surfaceContainerLow, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.surfaceContainer), theme.schemes.dark.surfaceContainer, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.surfaceContainerHigh), theme.schemes.dark.surfaceContainerHigh, true));
        sb.AppendCsCodeLine(GenLineOfCode(nameof(theme.schemes.dark.surfaceContainerHighest), theme.schemes.dark.surfaceContainerHighest, true));

        sb.AppendLine("}");
    }

    private static string GenLineOfCode(string nameofProperty, in string value, bool isDark = false)
    {
        nameofProperty = char.ToUpper(nameofProperty[0]) + nameofProperty[1..];
        if (isDark)
            nameofProperty += "Dark";
        else
            nameofProperty += "Light";

        var colorUint = $"0xFF{value[1..]}";
        return $"public static Color {nameofProperty} = Color.FromUint({colorUint})";
    }
}
