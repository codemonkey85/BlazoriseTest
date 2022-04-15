namespace BlazoriseTesting.Components;

public partial class BlazoriseTestComponent
{
    [CascadingParameter]
    private Theme Theme { get; set; }

    private string? MyColor { get; set; }

    private Todo[] todos = Array.Empty<Todo>();

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

    protected override async Task OnInitializedAsync() =>
        todos = (await TodoService.GetTodosAsync())?.Take(10)?.ToArray() ?? Array.Empty<Todo>();
}
