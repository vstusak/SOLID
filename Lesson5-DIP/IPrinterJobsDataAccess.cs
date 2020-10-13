namespace Lesson5_DIP
{
    public interface IPrinterJobsDataAccess
    {
        SqlDataReader GetJobs(SqlParameterCollection parameters);
    }
    
    public class SqlParameterCollection
    {
    }

    public class SqlDataReader
    {
    }
}