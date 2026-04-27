// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Welcome in Report builder!");
Console.WriteLine("Please choose type of report you want to create:");
Console.WriteLine("1. Simple Report");
Console.WriteLine("2. Full Report");
Console.WriteLine("3. Pretty Report");
Console.Write("Enter your choice: ");
string choice = Console.ReadLine();
ReportDto reportDtoResult = null;
switch (choice)
{
    case "1":
        Console.WriteLine("You chose Simple Report.");
        reportDtoResult = new ReportBuilder().AddDate().Build();
        break;
    case "2":
        Console.WriteLine("You chose Full Report.");
        reportDtoResult = new ReportBuilder().AddDate().AddGreeting().Build();
        break;
    case "3":
        Console.WriteLine("You chose Pretty Report.");
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;   
}


Console.WriteLine(reportDtoResult?.ToString());

public class ReportDto
{
    public string Header { get; set; }
    public string Body { get; set; }            
    public string Footer { get; set; }
    public override  string ToString()
    {
        return $"{Header}\n{Body}\n{Footer}";
    }
}

public class ReportBuilder
{
    private readonly ReportDto _reportDto = new ReportDto();
    public ReportBuilder AddDate()
    {
        _reportDto.Header = _reportDto.Header + DateTime.Now.ToString();
        return this;
    }
    public ReportBuilder AddGreeting()
    {
        _reportDto.Header = _reportDto.Header + " - Hello!";
        return this;
    }

    public ReportDto Build()
    {
        return _reportDto;
    }
}