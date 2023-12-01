namespace CarSale.Application.Exceptions;

public class CarNotFoundException : NotFoundException
{
    public CarNotFoundException()
    {
        this.TitleMessage = "Car not found.";
    }


}
