namespace HRAdministationAPI;

public class EmployeesBase : IEmployees
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public virtual decimal Salary { get; set; }
}