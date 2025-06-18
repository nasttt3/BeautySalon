using System.ComponentModel.DataAnnotations;

namespace BeautySalon.Model;

public class Master
{
    [Key] public int Id { get; set; }
    public string MasterName { get; set; }
    public string MasterNumber { get; set; }
    public string Profession { get; set; }
    public string MasterImage { get; set; }
}