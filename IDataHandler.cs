namespace BlazorApp1
{
    public interface IDataHandler<T>
    {
        Task<List<T>> LoadAsync();
        Task SaveAsync(T data);
    }


}
