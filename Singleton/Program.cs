// The Logger class
public class Logger
{
    // Private static variable to hold the single instance of the class
    private static Logger _instance;

    // Private constructor to prevent instance creation
    private Logger() { }

    // Public static method to get the instance of the class
    public static Logger Instance
    {
        get
        {
            // If the instance is null, create a new instance
            if (_instance == null)
            {
                _instance = new Logger();
            }

            // Return the instance
            return _instance;
        }
    }

    // Public method to print messages
    public void LogMessage(string message)
    {
        Console.WriteLine(message);
    }
}

// The Main method
class Program
{
    static void Main(string[] args)
    {
        // Get the Logger instance and use it to print a message
        Logger.Instance.LogMessage("Singleton");
    }
}
