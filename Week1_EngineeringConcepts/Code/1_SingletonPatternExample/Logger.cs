using System;
public class Logger
{
    private static Logger instance;
    private Logger()
    {
        Console.WriteLine("Initialized Logger");
    }

    public static Logger GetLogger()
    {
        if (instance == null)
        {
            instance = new Logger();
        }
        return instance;
    }

    public void Msg(string msg)
    {
        Console.WriteLine("Log: " + msg);
    }
}
