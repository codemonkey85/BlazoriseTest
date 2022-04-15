namespace BlazoriseTesting.Services;

public record TodoService(HttpClient HttpClient)
{
    public async Task<Todo[]?> GetTodosAsync() =>
        await HttpClient.GetFromJsonAsync<Todo[]>("https://jsonplaceholder.typicode.com/todos");

    public async Task<Todo?> GetTodoAsync(int id) =>
        await HttpClient.GetFromJsonAsync<Todo>($"https://jsonplaceholder.typicode.com/todos/{id}");
}
