using Escola.Domain.Model;

public class EnrollmentDto
{
    public int EnrollmentID { get; set; }
    public Grade? GradeStudent { get; set; }
    public string Course { get; set; }
    public int Credits { get; set; }

}