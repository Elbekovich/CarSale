namespace CarSale.Application.Exceptions;

public class UserAlreadyExistException : AlreadyExistsException
{
    public UserAlreadyExistException()
    {
        TitleMessage = "This phone is already registered";
    }
}
