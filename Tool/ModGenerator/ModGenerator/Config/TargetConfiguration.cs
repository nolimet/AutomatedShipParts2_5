namespace ModGenerator.Config;

public class TargetConfiguration(string baseGamePath, string[] vanillaParts, string baseModPath, Dictionary<long, string> targetComponents)
{
    public readonly string BaseGamePath = baseGamePath;
    public readonly string[] VanillaParts = vanillaParts;

    public readonly string BaseModPath = baseModPath;
    public readonly Dictionary<long, string> TargetComponents = targetComponents;
}
