using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls.Shapes;
using Wkxvii.Markup.ItemTemplate;
using Wkxvii.Samples.Model;

namespace Wkxvii.Samples.ContextDataTemplate;

internal static class UserListItemTemplate
{
    internal static ContextualDataTemplate<UserModel> Get => new(Create);

    private static Grid Create(UserModel user) =>
        new()
        {
            HeightRequest = 86,
            ColumnSpacing = 8,
            ColumnDefinitions = [new(GridLength.Auto), new(GridLength.Star)],
            RowDefinitions = [new(GridLength.Star), new(GridLength.Star)],
            Children =
            {
                new Border
                {
                    Padding = new(0),
                    StrokeShape = new RoundRectangle(){ CornerRadius = 16 },
                    Content = new Image()
                        .Fill()
                        .Aspect(Aspect.AspectFit)
                        .Source(new UriImageSource() { Uri = new(user.Picture) })
                }.Row(0).RowSpan(2).Column(0),

                new HorizontalStackLayout
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
                }.Row(0).Column(1),

                new Label()
                    .Row(1)
                    .Column(1)
                    .FontSize(18)
                    .TextColor(Colors.DimGray)
                    .CenterVertical()
                    .Text(user.Email),
            },
        };
}
