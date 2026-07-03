using Escola.Data.Context;
using Escola.Domain.Model;
using Microsoft.EntityFrameworkCore;

public class EnrollmentRepository : Repository<Enrollment>, IEnrollmentRepository{
    public EnrollmentRepository(EscolaContext options) : base(options)
    {

    }
    public new async Task<IEnumerable<Enrollment>> ObterTodos()
    {
        return await dbSet.Include(s => s.Student).Include(c => c.Course).OrderBy(e => e.EnrollmentID).ToListAsync();
    }

    public new async Task<Enrollment> ObterPorId(int id)
    {
        return await dbSet.Include(s => s.Student).Include(c => c.Course).FirstOrDefaultAsync(e => e.EnrollmentID == id);
    }
}