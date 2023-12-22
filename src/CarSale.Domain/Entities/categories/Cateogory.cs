namespace CarSale.Domain.Entities.categories;

public class Cateogory : Auditable
{

    public string Category_name { get; set; } = String.Empty;

    public string ImagePath { get; set; } = String.Empty;

}
