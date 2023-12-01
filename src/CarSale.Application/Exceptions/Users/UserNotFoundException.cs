namespace CarSale.Application.Exceptions;

public class UserNotFoundException : NotFoundException
{
    public UserNotFoundException()
    {
        TitleMessage = "User not found";
    }
}
