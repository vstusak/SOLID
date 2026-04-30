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
        reportDtoResult = new ReportBuilder().AddCurrentDate().Build();
        break;
    case "2":
        Console.WriteLine("You chose Full Report.");
        reportDtoResult = new ReportBuilder().AddCurrentDate().UpdateGreeting().Build();
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
    private string _date;
    private string _greeting = "Hello!";
    private string _address;
    private string _valediction;
    private string _signature;
    private string _stamp;

    public ReportBuilder AddCurrentDate()
    {
        _date = DateTime.Now.ToString();
        return this;
    }
    public ReportBuilder UpdateGreeting(string greeting ) //optional parameter with default value
    {
        _greeting = greeting;
        return this;
    }
    public ReportBuilder AddAddress(string address = "Brno") //optional parameter with default value
    {
        _address = address;
        return this;
    }

    //TODO: Finish all needed and test it + find bugs in the code and fix them

    public ReportDto Build()
    {
        return new ReportDto
        {
            Header = _date + _greeting + _address,
            Body = "",
            Footer = _valediction + _signature + _stamp
        };
    }
}