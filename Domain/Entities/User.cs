using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class User
{
    public long Id { get; set; }
    [MaxLength(100)]
    public string UserName { get; set; }
    [MaxLength(200)]
    public string Password { get; set; }
}
