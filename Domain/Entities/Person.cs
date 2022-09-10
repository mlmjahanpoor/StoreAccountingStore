

using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Person
{
    public long Id { get; set; }
    [MaxLength(100)]
    public string? Name { get; set; }

    #region navigations
    public Store Store { get; set; }
    public int StoreId { get; set; }

    public ICollection<Purchase> Purchases { get; set; }
    #endregion
}

public class Purchase
{
    public long Id { get; set; }
    #region navigations
    public Person Person { get; set; }
    public long PersonId { get; set; }
    public Product Product { get; set; }
    public long ProductId { get; set; } 
    #endregion
}
