namespace Wkxvii.Markup.ItemTemplate;

public class ContextualDataTemplate<ContextItemType>(Func<ContextItemType, View> loadTemplateFunction) : DataTemplate(() => LoadContextualTemplate(loadTemplateFunction))
{
    private static ContextualItemTemplate<ContextItemType> LoadContextualTemplate(Func<ContextItemType, View> loadTemplateFunction)
    {
        ArgumentNullException.ThrowIfNull(loadTemplateFunction);

        return new ContextualItemTemplate<ContextItemType>(loadTemplateFunction);
    }
}
