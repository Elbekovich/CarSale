using System.Net;

namespace CarSale.Application.Exceptions;

public class ExpiredException :ClientException
{
    public override HttpStatusCode StatusCode { get; } = HttpStatusCode.Gone;
    public override string TitleMessage { get; protected set; } = string.Empty;
}
