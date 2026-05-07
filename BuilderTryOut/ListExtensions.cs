public static class ListExtensions
{
    public static string StringJoin(this List<string> list, string separator)
    {
        return string.Join(separator, list);
    }
}