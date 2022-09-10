using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Role
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string Name { get; set; }
}
