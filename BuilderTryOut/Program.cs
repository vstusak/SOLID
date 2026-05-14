// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Welcome in Report builder!");
Console.WriteLine("Please choose type of report you want to create:");
Console.WriteLine("1. Simple Report");
Console.WriteLine("2. Full Report");
Console.WriteLine("3. Pretty Report");
Console.Write("Enter your choice: ");
string choice = Console.ReadLine();
ReportDto reportDtoResult = null;
var unHealthyChildren = new List<string>() { "Honza", "Pepa" };
var healthyChildren = new List<string>() { "Linda", "Mara" };
switch (choice)
{
    case "1":
        Console.WriteLine("You chose Simple Report.");
        reportDtoResult = new ReportBuilder()
            .AddCurrentDate()
            .AddUnHealthyChildren(unHealthyChildren)
            .Build();
        break;
    case "2":
        Console.WriteLine("You chose Full Report.");
        reportDtoResult = new ReportBuilder()
            .AddCurrentDate()
            .UpdateGreeting()
            .AddUnHealthyChildren(unHealthyChildren)
            .AddHealthyChildren(healthyChildren)
            .Build();
        break;
    case "3":
        Console.WriteLine("You chose Pretty Report.");
        reportDtoResult = new PrettyReportBuilder()
            .AddCurrentDate()
            .UpdateGreeting()
            .AddUnHealthyChildren(unHealthyChildren)
            .AddHealthyChildren(healthyChildren)
            .Build();
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

public class PrettyReportBuilder : ReportBuilder
{
    public PrettyReportBuilder()
    {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Magenta;
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
    private List<string> _healthyChildrenList = new List<string>();
    private List<string> _unHealthyChildrenList = new List<string>();

    public ReportBuilder AddCurrentDate()
    {
        _date = DateTime.Now.ToString();
        return this;
    }
    public ReportBuilder UpdateGreeting(string greeting = "Hello") //optional parameter with default value
    {
        _greeting = greeting;
        return this;
    }
    public ReportBuilder AddAddress(string address = "Brno") //optional parameter with default value
    {
        _address = address;
        return this;
    }
    public ReportBuilder AddHealthyChildren(List<string> healthyChildrenList)
    {
        _healthyChildrenList = healthyChildrenList;
        return this;
    }
    public ReportBuilder AddUnHealthyChildren(List<string> unHealthyChildrenList)
    {
        _unHealthyChildrenList = unHealthyChildrenList;
        return this;
    }
    public ReportDto Build()
    {
        return new ReportDto
        {
            Header = _date+" " + _greeting + Environment.NewLine+ _address,
            Body = "UnHealthy children: "+_unHealthyChildrenList.StringJoin(", ") +Environment.NewLine+ "Healthy children: " + _healthyChildrenList.StringJoin(", "),//extension method in ListExtensions class
            //Body = ListExtensions.StringJoin(_unHealthyChildrenList," ") + ListExtensions.StringJoin(_healthyChildrenList, " "); public static method in ListExtensions class
            Footer = _valediction + _signature + _stamp
        };
    }
}