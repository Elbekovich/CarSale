namespace CarSale.Application.Exceptions;

public class CategoryNotFoundException : NotFoundException
{
    public CategoryNotFoundException()
    {
        this.TitleMessage = "Category not found.";
    }
}
