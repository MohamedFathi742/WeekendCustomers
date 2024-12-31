namespace WeekendCustomers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Weekend Customers app ");
            double Customers = 0;
           if(! ReadNumber("Number Of Customers In Weekend  ", out Customers))return;

            Console.WriteLine($"The number of customers exceeding normal days = {(Customers * 10) / 100}");
            Console.ReadKey();
        }


      static bool ReadNumber(string field,out double number) {
            Console.WriteLine($"Please Enter {field}");
        number = 0;
            bool isConverted=double.TryParse(Console.ReadLine(),out number);
            if (!isConverted)
            {
                Console.WriteLine("Please Enter Valid Number");
                return false;
            }

            return true;
        
        }
    }
}
