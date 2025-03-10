namespace FinanceTracker.Application.Common.Pagination;

public sealed record PaginatedResponse<T>
{
    public required ICollection<T> Items { get; set; }
    public int PageSize { get; set; }
    public int PageNumber { get; set; }
    public int TotalPages { get; set; }
    public int TotalItemsCount { get; set; }

    public PaginatedResponse(ICollection<T> items, int pageNumber, int pageSize, int totalItemsCount)
    {
        Items = items;
        PageSize = pageSize;
        PageNumber = pageNumber;
        TotalPages = (int)Math.Ceiling(totalItemsCount / (double)pageSize);
        TotalItemsCount = totalItemsCount;
    }
}