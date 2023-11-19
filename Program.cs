using System.Text.Json;
using Bogus;

Console.WriteLine("Enter your marks :");

// generate a fake model of employee using Bogus

var fakeEmployee = new Faker<Employee>()
    .RuleFor(e => e.FirstName, f => f.Name.FirstName())
    .RuleFor(e => e.LastName, f => f.Name.LastName())
    .RuleFor(e => e.Email, f => f.Internet.Email())
    .RuleFor(e => e.PhoneNumber, f => f.Phone.PhoneNumber())
    .RuleFor(e => e.DateOfBirth, f => f.Date.Past(50, DateTime.Now.AddYears(-18)))
    .RuleFor(e => e.Position, f => f.Name.JobTitle())
    .RuleFor(e => e.Salary, f => f.Random.Double(1000, 10000))
    .RuleFor(e => e.HireDate, f => f.Date.Past(10))
    .RuleFor(e => e.Location, f => f.Address.City()); 

// assign all fake employee to employee model

var employee  = fakeEmployee.Generate();

//map employee model to employee dto

var employeeDto = employee.MapWithEmployeeDto();

// print employee dto as Json object

var json = JsonSerializer.Serialize(employeeDto, new JsonSerializerOptions { WriteIndented = true });

Console.WriteLine(json);


    