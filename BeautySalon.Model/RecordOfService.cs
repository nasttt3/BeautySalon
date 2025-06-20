using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautySalon.Model;

public class RecordOfService
{
    [Key] public int Id { get; set; }
    public int ClientId { get; set; }
    [ForeignKey("ClientId")] public Client Client { get; set; }
    public int ServiceId { get; set; }
    [ForeignKey("ServiceId")] public Service Service { get; set; }
    public int MasterId { get; set; }
    [ForeignKey("MasterId")] public Master Master { get; set; }
}