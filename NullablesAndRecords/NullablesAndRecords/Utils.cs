

namespace NullablesAndRecords;

public static class Utils
{
    public static FormattedNameResponse FormatName(string firstName, string lastName)
    {
        var fullName = $"{lastName}, {firstName}";
        var response = new FormattedNameResponse()
        {
            FullName = fullName,
           NumberOfLetters = fullName.Length
        };
       
       
        return response;
    }
   
}

public record FormattedNameResponse
{
    public required string FullName { get; init; } = string.Empty;
    public required int NumberOfLetters { get; init; }
}

public record EmployeeSummaryResponseModel(int Id, string FirstName, string LastName, string Department);


public record Employee 
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

}
// Tuple Types - google that later. Pretty cool. 