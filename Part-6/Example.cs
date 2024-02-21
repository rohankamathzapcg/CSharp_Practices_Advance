namespace Part6
{
    public delegate void printMessage(string message);

    class Example
    {
        public static void InvokeMethod()
        {
            printMessage printMessage=delegate(string message)
            {
                Console.WriteLine("Mesage: "+message);
            };

            printMessage("Rohan Kamath");
        }
    }
    
}