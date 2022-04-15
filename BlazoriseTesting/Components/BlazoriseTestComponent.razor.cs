namespace BlazoriseTesting.Components;

public partial class BlazoriseTestComponent
{
    private string? MyColor { get; set; }

    private Task OnThemeColorChanged(string value)
    {
        if (Theme?.ColorOptions != null)
        {
            Theme.ColorOptions.Primary = value;
        }

        if (Theme?.BackgroundOptions != null)
        {
            Theme.BackgroundOptions.Primary = value;
        }

        Theme?.ThemeHasChanged();
        return Task.CompletedTask;
    }

    [CascadingParameter]
    private Theme Theme { get; set; }
}
