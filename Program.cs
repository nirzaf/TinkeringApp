using Bogus;
using TinkeringApp.Mappers;
using static System.Console;

WriteLine("Hello World!");

var employeeFaker = new Faker<Employee>
    {
        Locale = "en" 
    }.RuleFor(e => e.Id, f => f.IndexFaker)
    .RuleFor(e => e.FirstName, f => f.Person.FirstName)
    .RuleFor(e => e.LastName, f => f.Person.LastName)
    .RuleFor(e => e.Email, f => f.Person.Email)
    .RuleFor(e => e.PhoneNumber, f => f.Person.Phone)
    .RuleFor(e => e.DateOfBirth, f => f.Person.DateOfBirth)
    .RuleFor(e => e.Position, f => f.Name.JobTitle())
    .RuleFor(e => e.Salary, f => f.Random.Double(1000, 10000))
    .RuleFor(e => e.HireDate, f => f.Date.Past())
    .RuleFor(e => e.Location, f => f.Address.City());
    
Employee? employee = employeeFaker.Generate();

EmployeeDto employeeDto = EmployeeMapper.ToEmployeeDto(employee);

WriteLine($"Id: {employeeDto.Id}");
WriteLine($"FirstName: {employeeDto.FirstName}");
WriteLine($"LastName: {employeeDto.LastName}");
WriteLine($"Email: {employeeDto.Email}");
WriteLine($"PhoneNumber: {employeeDto.PhoneNumber}");
WriteLine($"DateOfBirth: {employeeDto.DateOfBirth}");
WriteLine($"Position: {employeeDto.Position}");
WriteLine($"Salary: {employeeDto.Salary}");
WriteLine($"HireDate: {employeeDto.HireDate}");
WriteLine($"Location: {employeeDto.Location}");

