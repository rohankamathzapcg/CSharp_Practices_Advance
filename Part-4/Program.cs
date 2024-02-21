namespace Part4{

    public class Program
    {
        public static void Main(string[] args)
        {
            //Single Delegate
            // CalculateDelegate c1=new CalculateDelegate(DelegatesExample.addition);
            // CalculateDelegate c2=new CalculateDelegate(DelegatesExample.multiplication);

            // c1(100);
            // Console.WriteLine(DelegatesExample.getNumber());
            // c2(200);
            // Console.WriteLine(DelegatesExample.getNumber());
            
            //Multiple Delegate
            CalculateDelegate c1=new CalculateDelegate(DelegatesExample.addition);
            c1(100);
            c1=c1+new CalculateDelegate(DelegateExample.multiplication)
        }
    }
}