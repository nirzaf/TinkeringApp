using System.ComponentModel.DataAnnotations;

public class EmployeeModel
{
    [Key]
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Position { get; set; }
    public double Salary { get; set; }
    public DateTime HireDate { get; set; }
    public string? Location { get; set; }

    public EmployeeDto MapWithEmployeeDto()
    {
        return new EmployeeDto
        {
            Id = Id,
            FirstName = FirstName,
            LastName = LastName,
            Email = Email,
            PhoneNumber = PhoneNumber,
            DateOfBirth = DateOfBirth,
            Position = Position,
            Salary = Salary,
            HireDate = HireDate,
            Location = Location
        };
    }
}

public record EmployeeDto
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Position { get; set; }
    public double Salary { get; set; }
    public DateTime HireDate { get; set; }
    public string? Location { get; set; }
}