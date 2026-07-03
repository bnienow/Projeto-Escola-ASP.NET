using Escola.Domain.Model;

public interface IEnrollmentService
{
    Task<IEnumerable<Enrollment>> ObterTodos();
    Task<Enrollment> ObterPorId(int id);
    Task Adicionar(Enrollment enrollment);
    Task Atualizar(Enrollment enrollment);
    Task Remover(Enrollment enrollment);
}