using System.ComponentModel.DataAnnotations;

namespace BeautySalon.Model;

public class FeedBack
{
    [Key] public int Id { get; set; }
    public int Rate { get; set; }
    public string Text { get; set; }
}