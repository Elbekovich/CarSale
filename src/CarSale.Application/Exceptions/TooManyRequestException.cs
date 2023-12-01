using System.Net;

namespace CarSale.Application.Exceptions;

public class TooManyRequestException : ClientException
{
    public override HttpStatusCode StatusCode { get; } = HttpStatusCode.TooManyRequests;
    public override string TitleMessage { get; protected set; } = string.Empty;
}
