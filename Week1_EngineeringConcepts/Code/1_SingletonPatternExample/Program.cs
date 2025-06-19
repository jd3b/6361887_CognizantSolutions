using System;
public class Program
{
    public static void Main(string[] args)
    {
        Logger l1 = Logger.GetLogger();
        Logger l2 = Logger.GetLogger();
        Console.WriteLine(l1.GetHashCode());
        Console.WriteLine(l2.GetHashCode());
        l1.Msg("Message from l1");
        l2.Msg("Message from l2");
    }
}
