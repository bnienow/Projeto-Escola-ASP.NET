using Escola.Domain.Model;

public class EnrollmentService : IEnrollmentService
{
    protected readonly IEnrollmentRepository repo;
    public EnrollmentService(IEnrollmentRepository _repository)
    {
        repo = _repository;
    }

    public async Task<IEnumerable<Enrollment>> ObterTodos()
    {
        return await repo.ObterTodos();
    }

    public async Task<Enrollment> ObterPorId(int id)
    {
        return await repo.ObterPorId(id);
    }

    public async Task Adicionar(Enrollment enrollment)
    {
        await repo.Adicionar(enrollment);
    }

    public async Task Atualizar(Enrollment enrollment)
    {
        await repo.Atualizar(enrollment);
    }

    public async Task Remover(Enrollment enrollment)
    {
        await repo.Remover(enrollment);
    }
}