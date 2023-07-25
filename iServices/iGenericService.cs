namespace APICrud.iServices
{
    public interface iGenericService<T>
    {
        List<T> GetAll();

        T Get(int id);

        List<T> Insert(T item);

        List<T> Delete(int id);


    }
}
