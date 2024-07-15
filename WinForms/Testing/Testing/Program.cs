internal class Program
{
    private static void Main(string[] args)
    {
        DateTime? date = DateTime.Now;
        if (date != null)
            Console.WriteLine(((DateTime)date).ToLongDateString());
        else
            Console.WriteLine(date);
    }
}
