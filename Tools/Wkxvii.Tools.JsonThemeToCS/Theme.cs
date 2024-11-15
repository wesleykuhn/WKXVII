namespace Wkxvii.Tools.JsonThemeToCS;

public class Theme
{
    public string description { get; set; }
    public string seed { get; set; }
    public Corecolors coreColors { get; set; }
    public object[] extendedColors { get; set; }
    public Schemes schemes { get; set; }
}

public class Corecolors
{
    public string primary { get; set; }
}

public class Schemes
{
    public Light light { get; set; }
    public Dark dark { get; set; }
}

public class Light
{
    public string primary { get; set; }
    public string surfaceTint { get; set; }
    public string onPrimary { get; set; }
    public string primaryContainer { get; set; }
    public string onPrimaryContainer { get; set; }
    public string secondary { get; set; }
    public string onSecondary { get; set; }
    public string secondaryContainer { get; set; }
    public string onSecondaryContainer { get; set; }
    public string tertiary { get; set; }
    public string onTertiary { get; set; }
    public string tertiaryContainer { get; set; }
    public string onTertiaryContainer { get; set; }
    public string error { get; set; }
    public string onError { get; set; }
    public string errorContainer { get; set; }
    public string onErrorContainer { get; set; }
    public string background { get; set; }
    public string onBackground { get; set; }
    public string surface { get; set; }
    public string onSurface { get; set; }
    public string surfaceVariant { get; set; }
    public string onSurfaceVariant { get; set; }
    public string outline { get; set; }
    public string outlineVariant { get; set; }
    public string shadow { get; set; }
    public string scrim { get; set; }
    public string inverseSurface { get; set; }
    public string inverseOnSurface { get; set; }
    public string inversePrimary { get; set; }
    public string primaryFixed { get; set; }
    public string onPrimaryFixed { get; set; }
    public string primaryFixedDim { get; set; }
    public string onPrimaryFixedVariant { get; set; }
    public string secondaryFixed { get; set; }
    public string onSecondaryFixed { get; set; }
    public string secondaryFixedDim { get; set; }
    public string onSecondaryFixedVariant { get; set; }
    public string tertiaryFixed { get; set; }
    public string onTertiaryFixed { get; set; }
    public string tertiaryFixedDim { get; set; }
    public string onTertiaryFixedVariant { get; set; }
    public string surfaceDim { get; set; }
    public string surfaceBright { get; set; }
    public string surfaceContainerLowest { get; set; }
    public string surfaceContainerLow { get; set; }
    public string surfaceContainer { get; set; }
    public string surfaceContainerHigh { get; set; }
    public string surfaceContainerHighest { get; set; }
}

public class Dark
{
    public string primary { get; set; }
    public string surfaceTint { get; set; }
    public string onPrimary { get; set; }
    public string primaryContainer { get; set; }
    public string onPrimaryContainer { get; set; }
    public string secondary { get; set; }
    public string onSecondary { get; set; }
    public string secondaryContainer { get; set; }
    public string onSecondaryContainer { get; set; }
    public string tertiary { get; set; }
    public string onTertiary { get; set; }
    public string tertiaryContainer { get; set; }
    public string onTertiaryContainer { get; set; }
    public string error { get; set; }
    public string onError { get; set; }
    public string errorContainer { get; set; }
    public string onErrorContainer { get; set; }
    public string background { get; set; }
    public string onBackground { get; set; }
    public string surface { get; set; }
    public string onSurface { get; set; }
    public string surfaceVariant { get; set; }
    public string onSurfaceVariant { get; set; }
    public string outline { get; set; }
    public string outlineVariant { get; set; }
    public string shadow { get; set; }
    public string scrim { get; set; }
    public string inverseSurface { get; set; }
    public string inverseOnSurface { get; set; }
    public string inversePrimary { get; set; }
    public string primaryFixed { get; set; }
    public string onPrimaryFixed { get; set; }
    public string primaryFixedDim { get; set; }
    public string onPrimaryFixedVariant { get; set; }
    public string secondaryFixed { get; set; }
    public string onSecondaryFixed { get; set; }
    public string secondaryFixedDim { get; set; }
    public string onSecondaryFixedVariant { get; set; }
    public string tertiaryFixed { get; set; }
    public string onTertiaryFixed { get; set; }
    public string tertiaryFixedDim { get; set; }
    public string onTertiaryFixedVariant { get; set; }
    public string surfaceDim { get; set; }
    public string surfaceBright { get; set; }
    public string surfaceContainerLowest { get; set; }
    public string surfaceContainerLow { get; set; }
    public string surfaceContainer { get; set; }
    public string surfaceContainerHigh { get; set; }
    public string surfaceContainerHighest { get; set; }
}
