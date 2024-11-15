namespace Wkxvii.Markup.ItemTemplate;

public class ContextualItemTemplate<ContextItemType> : ContentView
{
    private readonly Func<ContextItemType, View> _creationFunction;
    public ContextualItemTemplate(Func<ContextItemType, View> creationFunction)
    {
        _creationFunction = creationFunction ?? throw new ArgumentNullException(nameof(creationFunction));
        BindingContextChanged += OnCreate;
    }

    private void OnCreate(object? sender, EventArgs e)
    {
        if (BindingContext is not ContextItemType context) return;
        Content = _creationFunction(context);
    }
}
