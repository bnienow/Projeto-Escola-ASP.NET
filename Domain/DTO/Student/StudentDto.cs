using Escola.Domain.Model;

public class StudentDto
{
    public string LastName { get; set; }
    public string FirstMidName { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public ICollection<EnrollmentDto> Enrollments { get; set; }
}