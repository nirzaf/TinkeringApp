// See https://aka.ms/new-console-template for more information

using TinkeringApp;

using static System.Console;


ExecutePython.ReadPythonData();
return;

var input = "This is the string contains all claims for the user.";
var encrypted = EncryptionHelper.Encrypt(input);
var decrypted = EncryptionHelper.Decrypt(encrypted);

WriteLine("Input: " + input);
WriteLine("Encrypted: " + encrypted);
WriteLine("Decryption Key: " + EncryptionHelper.key);
WriteLine("Decrypted: " + decrypted);

ReadLine();


/*
const string text = "null";

WriteLine(string.IsNullOrWhiteSpace(text) ? "Text is null or empty" : "Text is not null or empty");

return;

DateTime? input = null;
do
{
    WriteLine("Please enter your date of birth:");
    string? value = ReadLine();

    var trimmedInput = value?.Trim();

    if (!value.IsNullOrDefault() && TryParse(value, out DateTime output))
    {
        input = output;
    }
} while (input is null);

WriteLine("Your date of birth is: {0}", input);

WriteLine("Your age is: {0}", Now.Year - input.Value.Year);

ReadLine();

WriteLine("Hello, World!");
// var students = new Faker<Student>()
//     .RuleFor(s => s.Id, f => f.IndexFaker)
//     .RuleFor(s => s.FirstName, f => f.Name.FirstName())
//     .RuleFor(s => s.LastName, f => f.Name.LastName())
//     .RuleFor(s => s.DateOfBirth, null)
//     .RuleFor(s => s.Email, f => f.Internet.Email())
//     .RuleFor(s => s.Mobile, f => f.Phone.PhoneNumber())
//     .RuleFor(s => s.Address, f => f.Address.StreetAddress())
//     .RuleFor(s => s.City, f => f.Address.City())
//     .RuleFor(s => s.State, f => f.Address.State())
//     .RuleFor(s => s.ZipCode, f => f.Address.ZipCode())
//     .RuleFor(s => s.Country, f => f.Address.Country())
//     .Generate(10);

var s1 = new Student
{
    Id = 1,
    FirstName = "John",
    LastName = "Doe",
    DateOfBirth = null,
    Email = "abcd@gmail.com",
    Mobile = "1234567890",
    Address = "123 Main St",
    City = "New York",
    State = "NY",
    ZipCode = "12345",
    Country = "USA"
};

var cs = new CreateStudent();

var student = cs.GetCreateStudent(s1);

//print all properties of student to console

WriteLine(student.FirstName);
WriteLine(student.LastName);
WriteLine(student.DateOfBirth);
WriteLine(student.Email);
WriteLine(student.Mobile);
WriteLine(student.Address);
WriteLine(student.City);
WriteLine(student.State);
WriteLine(student.ZipCode);
WriteLine(student.Country);

ReadLine();
*/



//create a class of Students with 10 properties

//create a list of students