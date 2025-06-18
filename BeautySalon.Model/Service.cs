using System.ComponentModel.DataAnnotations;

namespace BeautySalon.Model;

public class Service
{
    [Key] public int Id { get; set; }
    public string ServiceName { get; set; }
    public string ServiceImage { get; set; }
}