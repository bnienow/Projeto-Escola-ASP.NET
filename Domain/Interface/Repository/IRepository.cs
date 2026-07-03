public interface IRepository<T>
{
    Task<IEnumerable<T>> ObterTodos();
    Task<T> ObterPorId(int id);
    Task Adicionar(T t);
    Task Atualizar(T t);
    Task Remover(T t);
}