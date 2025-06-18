using System.ComponentModel.DataAnnotations;

namespace BeautySalon.Model;

public class Client
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string RecordService { get; set; }
    public string RecordMaster { get; set; }
    public DateTime RecordOfDate { get; set; } = DateTime.Today;
    public DateTime RecordOfTime { get; set; } = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,09,00,00);
}