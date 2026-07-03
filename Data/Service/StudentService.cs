using Escola.Domain.Model;
public class StudentService : IStudentService
{
    protected readonly IStudentRepository repo;
    public StudentService (IStudentRepository _repository)
    {
        repo = _repository;
    }

    public async Task<IEnumerable<Student>> ObterTodos()
    {
        return await repo.ObterTodos();
    }

    public async Task<Student> ObterPorId(int id)
    {
        return await repo.ObterPorId(id);
    }

    public async Task Adicionar(Student student)
    {
        await repo.Adicionar(student);
    }

    public async Task Atualizar(Student student)
    {
        await repo.Atualizar(student);
    }

    public async Task Remover(Student student)
    {
        await repo.Remover(student);
    }

    public async Task<IEnumerable<Student>> Reprovados()
    {
        var students = await repo.ObterTodos();
        return students.Where(p => p.Enrollments.Any(e => e.GradeStudent == Grade.F));
    }
}