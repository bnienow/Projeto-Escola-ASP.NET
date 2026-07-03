using Escola.Data.Context;
using Escola.Domain.Model;
using Microsoft.EntityFrameworkCore;

public class CourseRepository : Repository<Course>, ICourseRepository
{
    public CourseRepository(EscolaContext options) : base(options)
    {
        
    }

    public new async Task<IEnumerable<Course>> ObterTodos()
    {
        return await dbSet.Include(e => e.Enrollments).ToListAsync();
    }

    public new async Task<Course> ObterPorId(int id)
    {
        return await dbSet.Include(e => e.Enrollments).FirstOrDefaultAsync(c => c.CourseID == id);
    }
}