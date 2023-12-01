namespace CarSale.Application.Utils;

public class PaginationParams
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; } = 10;
    public PaginationParams(int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
    }
    public int GetSkipCount()
    {
        return (PageNumber -1) * PageSize;
    }
}
