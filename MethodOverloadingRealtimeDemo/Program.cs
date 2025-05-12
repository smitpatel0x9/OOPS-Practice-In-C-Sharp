namespace MethodOverloadingRealtimeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string className = "Program";
            string methodName = "Main";
            string uniqueId = Guid.NewGuid().ToString();
            Logger.Log(className, methodName, "Message 1");
            Logger.Log(uniqueId,className, methodName, "Message 2");
            Logger.Log("Message 3");
            try
            {
                int num1 = 10, num2 = 0;
                int result = num1 / num2;
                Logger.Log(uniqueId, className, methodName, "Message 4");
            }
            catch(Exception ex)
            {
                Logger.Log(className, methodName, ex);
            }
        }
    }
    public class Logger
    {
        public static void Log(string className,string methodName,string message)
        {
            Console.WriteLine($"DateTime : {DateTime.Now} ClassName : {className} MethodName : {methodName} " +
                $"Message : {message}");
        }
        public static void Log(string uniqueId,string className,string methodName,string message)
        {
            Console.WriteLine($"DateTime : {DateTime.Now} Unique Id : {uniqueId} ClassName : {className}" + 
                $" MethodName : {methodName} Message : {message}");
        }
        public static void Log(string message)
        {
            Console.WriteLine($"DateTime : {DateTime.Now} Message : {message}");
        }
        public static void Log(string className,string methodName,Exception ex)
        {
            Console.WriteLine($"DateTime : {DateTime.Now} ClassName : {className} MethodName : {methodName} " +
                $"Exception Message : {ex.Message} StackTrace : {ex.StackTrace}");
        }
    }
}
