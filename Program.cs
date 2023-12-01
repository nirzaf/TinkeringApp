using Bogus;
using TinkeringApp.Mappers;

Console.WriteLine("Hello World!");

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

Console.WriteLine($"Id: {employeeDto.Id}");
Console.WriteLine($"FirstName: {employeeDto.FirstName}");
Console.WriteLine($"LastName: {employeeDto.LastName}");
Console.WriteLine($"Email: {employeeDto.Email}");
Console.WriteLine($"PhoneNumber: {employeeDto.PhoneNumber}");
Console.WriteLine($"DateOfBirth: {employeeDto.DateOfBirth}");
Console.WriteLine($"Position: {employeeDto.Position}");
Console.WriteLine($"Salary: {employeeDto.Salary}");
Console.WriteLine($"HireDate: {employeeDto.HireDate}");
Console.WriteLine($"Location: {employeeDto.Location}");

