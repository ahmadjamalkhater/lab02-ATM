namespace ATMBank
{
    public class Program
    {
        //write code here.
        public static decimal Balance;
        public static string Tracker = "";
        static void Main(string[] args)
        {
            try
            {
                UserInterFace();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(Tracker);
            }

        }

        public static decimal ViewBalance()
        {
            if (Balance < 1)
            {
                return 0;
            }


            return Balance;
        }

        public static decimal WithDraw(decimal Draw)
        {
            if (Draw > Balance)
            {
                Console.WriteLine("Cannot withDraw More Than the Balance");
                return -1;
            }
            else if (Draw < 0)
            {
                Console.WriteLine("cannot Draw Money from in negative! ");
                return -1;
            }

            Balance = Balance - Draw;
            return Balance;

        }

        public static decimal Deposit(decimal deposit)
        {
            if (deposit > 0)
            {
                Balance = Balance + deposit;
                return Balance;
            }
            else return -1;
        }
        public static void UserInterFace()
        {
            Console.WriteLine("Welcome to Our  ATM Bank ^_^");
            Console.WriteLine($"Your Balance is  {ViewBalance()} ");
            bool IsTrue = true;
            while (IsTrue)
            {
                try
                {

                    Console.WriteLine("Please enter The Transaction : \n 1 : View Balance \t 2 : WithDraw \t 3 : Deposit \t  4 : Exit the Atm ");

                    int transaction = Convert.ToInt32(Console.ReadLine());

                    if (transaction == 1)
                    {
                        Console.WriteLine($"Your Balance : {ViewBalance()} ");

                    }
                    else if (transaction == 2)
                    {
                        Console.WriteLine($"Enter A value to Draw from the ${ViewBalance()}  ");
                        decimal Draw = Convert.ToDecimal(Console.ReadLine());
                        WithDraw(Draw);
                        Console.WriteLine($"Now Your Balance is : {ViewBalance()} ");
                        Tracker += $"You Draw {Draw} From your Balance\n";
                    }
                    else if (transaction == 3)
                    {
                        Console.WriteLine($"Enter A value to Deposit Value to Your Balance : ${ViewBalance()} ... ");
                        decimal deposit = Convert.ToDecimal(Console.ReadLine());
                        Deposit(deposit);
                        Console.WriteLine($"Now Your Balance is : {ViewBalance()} ");
                        Tracker += $"You Deposit {deposit} in your Balance\n";
                    }
                    else if (transaction == 4)
                    {
                        IsTrue = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input Try Again please ^_^");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong input data Type please make sure it is number ^_^");
                }
            }



        }


    }
}