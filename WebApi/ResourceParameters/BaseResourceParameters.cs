using MyShop.WebApi.Data;

namespace MyShop.WebApi.ResourceParameters;

public class BaseResourceParameters
{
    private const int MaxPageSize = 20;
    public int PageNumber { get; set; } = 1;

    private int _pageSize = 10;

    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
    }

    public string? SearchQuery { get; set; }

    public string? Fields { get; set; }
}