using AsyncAwaitBestPractices;
using CommunityToolkit.Maui.Markup;
using Wkxvii.Samples.Model;

namespace Wkxvii.Samples.ContextDataTemplate;

internal class ContextDataTemplatePage : ContentPage
{
    public ContextDataTemplatePage()
    {
        this.BindingContext = new ContextDataTemplateViewModel();

        Content = new CollectionView() { ItemsLayout = new LinearItemsLayout(ItemsLayoutOrientation.Vertical) { ItemSpacing = 4 } }
            .ItemTemplate(ClickableUserListItemTemplate.Get(OnUserCliked))
            .Bind(CollectionView.ItemsSourceProperty, path: nameof(ContextDataTemplateViewModel.Users));
    }

    private void OnUserCliked(UserModel user)
    {
        if (BindingContext is ContextDataTemplateViewModel vm)
            vm.ProcessUserClickedAsync(user).SafeFireAndForget();
    }
}
