using Escola.Domain.Model;

public class CourseService : ICourseService
{
    protected readonly ICourseRepository repo;
    public CourseService(ICourseRepository repository)
    {
        repo = repository;
    }

    public async Task<IEnumerable<Course>> ObterTodos()
    {
        return await repo.ObterTodos();
    }

    public async Task<Course> ObterPorId(int id)
    {
        return await repo.ObterPorId(id);
    }

    public async Task Adicionar(Course course)
    {
        await repo.Adicionar(course);
    }

    public async Task Atualizar(Course course)
    {
        await repo.Atualizar(course);
    }

    public async Task Remover(Course course)
    {
        await repo.Remover(course);
    }
}