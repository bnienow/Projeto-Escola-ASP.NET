using Escola.Domain.Model;

public interface ICourseService
{
    Task<IEnumerable<Course>> ObterTodos();
    Task<Course> ObterPorId(int id);
    Task Adicionar(Course course);
    Task Atualizar(Course course);
    Task Remover(Course course);
}