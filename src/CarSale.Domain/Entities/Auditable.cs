namespace CarSale.Domain.Entities;

public abstract class Auditable : BaseEntity
{
    public DateTime Created_at { get; set; }

    public DateTime Updated_at { get;}

}
