

namespace Domain.Entities;

public class Shareholder
{
    public int Id { get; set; }
    public long Amount { get; set; }

    #region navigations
    public Store Store { get; set; }
    public int StoreId { get; set; }
    #endregion
}


