namespace HRAdministationAPI;

public interface IEmployees
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    decimal Salary { get; set; }
}