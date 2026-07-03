using Escola.Data.Context;
using Microsoft.EntityFrameworkCore;

public class StudentRepository : Repository<Student>, IStudentRepository {
    public StudentRepository(EscolaContext options) : base(options){

    }

    public new async Task<IEnumerable<Student>> ObterTodos()
    {
        return await dbSet.Include(s => s.Enrollments).ThenInclude(c => c.Course).ToListAsync();
    }

    public new async Task<Student> ObterPorId(int id)
    {
        return await dbSet.Include(s => s.Enrollments).FirstOrDefaultAsync(s => s.StudentID == id);
    }
}