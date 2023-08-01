

namespace NullablesAndRecords;

public class Customer
{
    private readonly decimal _creditLimit;
    private readonly string _accountRepName;

    private readonly string? _address = "1515 Maple";
    public Customer()
    {
        _accountRepName = "Karl";
    }


    public string GetInfo()
    {
        // ?. is "Null Traversal", aka "The Elvis Operator"
        // ?? The null coalescing operator - which takes to operands and returns the first non-null value, or null
        return (_address?.ToUpper() ?? " NO KNOWN ADDRESS ") + " Lives here";
    }
    public int Id { get; set; }
    public string? Name { get; set; }

    public DateTime Birthday { get; set; }

    //public List<string> Friends { get; set; } = new();
    public List<string> Friends { get; set; } = new List<string>();
}
