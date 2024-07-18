namespace Salary.Employee;

public class Employee
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime CreatedAt { get; set; }
}

public class Salary
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    public decimal GrossAmount { get; set; }
    public decimal NetAmount { get; set; }
    public DateTime Date { get; set; }
}