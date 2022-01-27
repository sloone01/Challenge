namespace Challenge.Services
{
    public interface IService<T>
    {
        string GetUrl();
        Task<ServiceResponse> Delete(int Id);
        Task<ServiceResponse> Add(T Entity);
        Task<ServiceResponse> Update(T Entity);
        Task<List<T>?> Fetch();
    }
}
