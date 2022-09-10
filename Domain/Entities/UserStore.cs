namespace Domain.Entities;

public class UserStore
{
    public long Id { get; set; }

    #region navigations
    public User User { get; set; }
    public long UserId { get; set; }
    public Store Store { get; set; }
    public int StoreId { get; set; }
    #endregion
}
