
using Escola.Domain.Model;

public class EnrollmentCreateDto
{
    public int CourseID { get; set; }
    public int StudentID { get; set; }
    public Grade? GradeStudent { get; set; }
}