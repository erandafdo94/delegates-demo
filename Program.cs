using System;

public delegate void CallbackDelegate(string message);

public class Program
{
    public static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static void ProcessMessage(string message, CallbackDelegate callback)
    {
        // Processing message...
        callback(message);
    }

    public static void Main()
    {
        CallbackDelegate callback = new CallbackDelegate(ShowMessage);
        ProcessMessage("Hello, Delegate!", callback);
    }
}
