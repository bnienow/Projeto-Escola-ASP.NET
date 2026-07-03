using Microsoft.EntityFrameworkCore;
using Escola.Domain.Model;

namespace Escola.Data.Context;

public class EscolaContext : DbContext
{
    public EscolaContext (DbContextOptions<EscolaContext> options) : base(options){
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Course> Courses { get; set; }

}