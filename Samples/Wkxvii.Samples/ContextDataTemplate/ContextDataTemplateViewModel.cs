using CommunityToolkit.Mvvm.ComponentModel;
using Wkxvii.Samples.Model;

namespace Wkxvii.Samples.ContextDataTemplate;

internal partial class ContextDataTemplateViewModel : ObservableObject
{
    [ObservableProperty]
    private bool isBusy;

    [ObservableProperty]
    private IReadOnlyList<UserModel> users;

    public ContextDataTemplateViewModel()
    {
        users = UserModel.GenMocks();
    }

    internal async Task ProcessUserClickedAsync(UserModel user)
    {
        if (IsBusy) return;

        IsBusy = true;

        await Task.Delay(500);

        if (MainThread.IsMainThread)
            await Application.Current!.MainPage!.DisplayAlert(
                "User Clicked and processed ",
                $"User {user.Name} clicked",
                "OK"
            );
        else
            await MainThread.InvokeOnMainThreadAsync(
                () =>
                    Application.Current!.MainPage!.DisplayAlert(
                        "User Clicked and processed ",
                        $"User {user.Name} clicked",
                        "OK"
                    )
            ).ConfigureAwait(false);

        IsBusy = false;
    }
}
