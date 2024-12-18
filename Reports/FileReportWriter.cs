using Reports;

internal class FileReportWriter
{
    public FileReportWriter()
    {
    }

    public void SaveFile(Report report)
    {
        File.WriteAllText(@"C:\temp.txt",report.ToString());
    }
}