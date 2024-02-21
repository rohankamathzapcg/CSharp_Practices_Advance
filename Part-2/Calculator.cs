namespace Part2
{
    class Calculation
    {
        public void calculate(int num1, int num2)
        {
            try
            {
                int result = num1 / num2;
                Console.WriteLine(result);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("I will always execute");
            }


        }
    }
}