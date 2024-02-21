//Declaring a Delegate
delegate int CalculateDelegate(int num);

namespace Part4
{
    class DelegatesExample
    {
        static int number=100;
        public static int addition(int num)
        {
            number=number+num;
            return number;
        }

        public static int multiplication(int num)
        {
            number=number*num;
            return number;
        }

        public static int getNumber()
        {
            return number;
        }
    }
}