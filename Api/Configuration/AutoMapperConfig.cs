using AutoMapper;
using Escola.Domain.Model;

public class AutoMapperConfig : Profile
{
    public AutoMapperConfig()
    {
        CreateMap<Student, StudentCreateDto>().ReverseMap();
        CreateMap<Course, CourseCreateDto>().ReverseMap();
        CreateMap<Enrollment, EnrollmentCreateDto>().ReverseMap();

        CreateMap<Enrollment, EnrollmentDto>().ForMember(dest => dest.Course, opt => opt.MapFrom(org => org.Course.Title)).ForMember(dest => dest.Credits, opt
        => opt.MapFrom(org => org.Course.Credits));
        CreateMap<Student, StudentDto>().ReverseMap();
        CreateMap<Course, CourseDto>().ReverseMap();

    }
}