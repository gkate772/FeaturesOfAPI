using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.Json.Serialization;

//Employee emp = new Employee
//{
//    Id = 1,
//    FirstName = "Rohit",
//    LastName = null,
//    Email = "rohit@example.com",
//    PhoneNumber = "9876543210",
//    DateOfBirth = new DateTime(1998, 10, 24),
//    HireDate = DateTime.Now,
//    JobTitle = "Software Engineer",
//    Department = Department.Marketing,
//    Salary = 75000
//};

//List<Employee> employees = new List<Employee>
//{
//    new Employee { Id = 1, FirstName = "Rohit" },
//    new Employee { Id = 2, FirstName = "Ganesh" },
//    new Employee { Id = 3, FirstName = "Amit" },
//    new Employee { Id = 4, FirstName = "Suresh" },
//    new Employee { Id = 5, FirstName = "Rakesh" },
//    new Employee { Id = 6, FirstName = "Vikas" },
//    new Employee { Id = 7, FirstName = "Pooja" },
//    new Employee { Id = 8, FirstName = "Neha" },
//    new Employee { Id = 9, FirstName = "Anita" },
//    new Employee { Id = 10, FirstName = "Kiran" }
//};


//var options = new JsonSerializerOptions
//{
//    WriteIndented = true,
//    PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseUpper,
//    PropertyNameCaseInsensitive = true,
//    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
//};

//options.Converters.Add(new JsonStringEnumConverter());

//options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;



//string jsonString = JsonSerializer.Serialize(emp, options);

//string jsonListString = JsonSerializer.Serialize(employees, options);

//Console.WriteLine("Serialized JSON:\n" + jsonString);
//Console.WriteLine("Serialized JSON:\n" + jsonListString);

string jsonString = @"
[
  {
    ""DATE_OF_BIRTH"": ""0001-01-01T00:00:00"",
    ""ID"": 1,
    ""FName"": ""Rohit"",
    ""HIRE_DATE"": ""0001-01-01T00:00:00"",
    ""DEPT_ID"": ""Code001"",
    ""DEPARTMENT"": ""IT""
  },
  {
    ""DATE_OF_BIRTH"": ""0001-01-01T00:00:00"",
    ""ID"": 2,
    ""FName"": ""Ganesh"",
    ""HIRE_DATE"": ""0001-01-01T00:00:00"",
    ""DEPT_ID"": ""Code001"",
    ""DEPARTMENT"": ""Finance""
  }
]";

var options = new JsonSerializerOptions
{
    WriteIndented = true,
    PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseUpper,
    PropertyNameCaseInsensitive = true,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
};

options.Converters.Add(new JsonStringEnumConverter());


List<Employee> employees = JsonSerializer.Deserialize<List<Employee>>(jsonString,options);

foreach (var emp in employees)
{
    Console.WriteLine($"ID: {emp.Id}, First Name: {emp.FirstName}");
}


