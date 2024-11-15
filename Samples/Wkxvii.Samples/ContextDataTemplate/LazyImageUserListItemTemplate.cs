using AsyncAwaitBestPractices;
using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls.Shapes;
using Wkxvii.Markup.ItemTemplate;
using Wkxvii.Samples.Model;

namespace Wkxvii.Samples.ContextDataTemplate;

[Obsolete("Do not use this or anything related to it. It was just an experiment!")]
internal class LazyImageUserListItemTemplate
{
    internal static ContextualDataTemplate<UserModel> Get => new(Create);

    private static Template Create(UserModel user) => new Template().Create(user);

    private class Template : Grid
    {
        private Image? _pictureImage;
        private Border? _pictureBorder;

        internal Template Create(UserModel user)
        {
            _pictureImage = new Image()
                .Fill()
                .Aspect(Aspect.AspectFit)
                .IsVisible(false);

            _pictureBorder = new Border()
            {
                Padding = new(0),
                StrokeShape = new RoundRectangle() { CornerRadius = 16 },
                Content = new ActivityIndicator() { IsRunning = true }.Center(),
            }.RowSpan(2);

            var statusAndNameContainer = new HorizontalStackLayout
            {
                Spacing = 4,
                Children =
                {
                    new Label()
                        .FontSize(32)
                        .CenterVertical()
                        .Text("•")
                        .TextColor(user.Active ? Colors.ForestGreen : Colors.Crimson),
                    new Label().FontSize(24).CenterVertical().Text(user.Name),
                },
            }.Row(0).Column(1);

            var emailLabel = new Label()
                .Row(1)
                .Column(1)
                .FontSize(18)
                .TextColor(Colors.DimGray)
                .CenterVertical()
                .Text(user.Email);

            ColumnSpacing = 8;
            ColumnDefinitions = [new(GridLength.Auto), new(GridLength.Star)];
            RowDefinitions = [new(GridLength.Star), new(GridLength.Star)];
            HeightRequest = 86;

            this.Add(_pictureBorder);
            this.Add(statusAndNameContainer, column: 1);
            this.Add(emailLabel, column: 1, row: 1);

            ResolveImageAsync(user.Picture).SafeFireAndForget();

            return this;
        }

        private async Task ResolveImageAsync(string? picture)
        {
            ImageSource? imageSource = null;

            if (!string.IsNullOrEmpty(picture))
                imageSource = ImageSource.FromUri(new Uri(picture));

            if (ImageSource.IsNullOrEmpty(imageSource))
            {
                imageSource = new FontImageSource()
                {
                    Glyph = "?",
                    Size = 64,
                };
            }

            await MainThread.InvokeOnMainThreadAsync(() =>
            {
                if (_pictureImage is not null)
                {
                    _pictureImage.Source = imageSource;
                    _pictureImage.IsVisible = true;
                }

                if (_pictureBorder is not null)
                    _pictureBorder.Content = _pictureImage;
            }).ConfigureAwait(false);
        }
    }
}
