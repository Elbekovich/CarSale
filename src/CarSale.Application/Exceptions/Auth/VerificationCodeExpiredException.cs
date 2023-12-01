namespace CarSale.Application.Exceptions;

public class VerificationCodeExpiredException : ExpiredException
{
    public VerificationCodeExpiredException()
    {
        TitleMessage = "Verification code is expired!";
    }
}
