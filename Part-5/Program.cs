namespace Part5
{
    class Program
    {
        public static void Main(string[] args)
        {
            EventsExample events=new EventsExample();
            events.event_OddNumber+=new EventsExample.delegate_OddNumber(EventMessage);

            static void EventMessage()
            {
                Console.WriteLine("Event Executed: Odd Number");
                
            }
        }
    }
}