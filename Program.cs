using TinkeringApp;


 Console.WriteLine("Enter employee ID");
 var employeeId = Console.ReadLine();
 
Console.WriteLine("Enter employee name");
var employeeName = Console.ReadLine();
 
    var employee = new Employee
    {
        QId = employeeId,
        Name = employeeName
    };

   Console.WriteLine($"Employee ID: {employee.QId}");
 
 
 public class Employee
 {
        [ValidQId]
        public string? QId { get; set; }
        
        public string? Name { get; set; }
 }

 