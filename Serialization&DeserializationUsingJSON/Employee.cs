using System.Text.Json.Serialization;

public class Employee
{
    [JsonInclude]
    private string DeptId="Code001";
    public int Id { get; set; }
    [JsonPropertyName("FName")]
    public string FirstName { get; set; }
    [JsonPropertyName("LName")]
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    [JsonPropertyOrder(-1)]
    public DateTime DateOfBirth { get; set; }
    [JsonPropertyOrder(0)]
    public DateTime HireDate { get; set; }
    [JsonPropertyOrder(2)]
    public string JobTitle { get; set; }
    [JsonPropertyOrder(1)]
    public Department Department { get; set; }
    [JsonIgnore]
    public decimal Salary { get; set; }
}