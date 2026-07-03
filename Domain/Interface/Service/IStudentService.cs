using Escola.Domain.Model;

public interface IStudentService
{
    Task<IEnumerable<Student>> ObterTodos();
    Task<Student> ObterPorId(int id);
    Task Adicionar (Student student);
    Task Atualizar (Student student);
    Task Remover (Student student);
    Task<IEnumerable<Student>> Reprovados();
}