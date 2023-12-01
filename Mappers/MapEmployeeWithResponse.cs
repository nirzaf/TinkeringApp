
namespace TinkeringApp.Mappers;

public static class EmployeeMapper
{
    public static EmployeeDto ToEmployeeDto(Employee employee)
    {
        return new EmployeeDto
        {
            Id = employee.Id,
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            Email = employee.Email,
            PhoneNumber = employee.PhoneNumber,
            DateOfBirth = employee.DateOfBirth,
            Position = employee.Position,
            Salary = employee.Salary,
            HireDate = employee.HireDate,
            Location = employee.Location
        };
    }

    public static Employee ToEmployee(EmployeeDto employeeDto)
    {
        return new Employee
        {
            Id = employeeDto.Id,
            FirstName = employeeDto.FirstName,
            LastName = employeeDto.LastName,
            Email = employeeDto.Email,
            PhoneNumber = employeeDto.PhoneNumber,
            DateOfBirth = employeeDto.DateOfBirth,
            Position = employeeDto.Position,
            Salary = employeeDto.Salary,
            HireDate = employeeDto.HireDate,
            Location = employeeDto.Location
        };
    }
}