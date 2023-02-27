public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }
}

public class CreateStudent
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }

    public CreateStudent GetCreateStudent(Student student)
    {
        var createStudent = new CreateStudent
        {
            Id = student.Id,
            FirstName = student.FirstName,
            LastName = student.LastName,
            DateOfBirth = student.DateOfBirth.ToString(),
            Email = student.Email,
            Mobile = student.Mobile,
            Address = student.Address,
            City = student.City,
            State = student.State,
            ZipCode = student.ZipCode,
            Country = student.Country
        };
        return createStudent;
    }
}

public static class Utility
{
    public static bool IsNotNullOrEmpty<T>(this IEnumerable<T>? enumerable)
    {
        return enumerable is not null || enumerable!.Any();
    }
}