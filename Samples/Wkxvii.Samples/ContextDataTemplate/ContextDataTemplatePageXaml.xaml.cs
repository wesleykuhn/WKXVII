namespace Wkxvii.Samples.ContextDataTemplate;

public partial class ContextDataTemplatePageXaml : ContentPage
{
    public ContextDataTemplatePageXaml()
    {
        InitializeComponent();

        this.BindingContext = new ContextDataTemplateViewModel();
    }
}