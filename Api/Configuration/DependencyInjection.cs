using Escola.Data.Context;
using Escola.Domain.Model;
using Microsoft.EntityFrameworkCore;

public static class DependencyInjection {
    public static void AddServices(IServiceCollection services, IConfiguration configuration){
        services.AddDbContext<EscolaContext>(options =>
        options.UseMySql(
            configuration.GetConnectionString("DefaultConnection"),
            ServerVersion.AutoDetect(configuration.GetConnectionString("DefaultConnection"))
            )
        );
        services.AddScoped<IStudentRepository, StudentRepository>();
        services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();
        services.AddScoped<ICourseRepository, CourseRepository>();

        services.AddScoped<IStudentService, StudentService>();
        services.AddScoped<IEnrollmentService, EnrollmentService>();
        services.AddScoped<ICourseService, CourseService>();

        services.AddAutoMapper(typeof(AutoMapperConfig));
    }
}