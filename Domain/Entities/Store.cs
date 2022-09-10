using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Store
{
    public int Id { get; set; }
    [MaxLength(150)]
    public string? Name { get; set; }
    [MaxLength(255)]
    public string? Address { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    #region navigations
    public ICollection<Shareholder> Shareholders { get; set; }
    #endregion
}
