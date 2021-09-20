using System;

namespace Baldesamo_Franco_module1_4_5_TRY2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("OrderForm from SweetBox ");

            //userinfo list
            string[] userInfo = new string[15];
            int[] userNumints = new int[5];
            long[] phoneNum = new long[2];
            double[] itemPrice = new double[1];
            long[] Itemquant = new long[1];

            //firstname input
            Console.Write("\nEnter firstname: ");

            //this will validate the length of names inputted
            userInfo[0] = Console.ReadLine();

            bool a = Checkvalid(userInfo[0]);

            while (a == false)
            {
                Console.Write("Enter firstname: ");
                userInfo[0] = Console.ReadLine();
                a = Checkvalid(userInfo[0]);
            }

            //Lastname input
            Console.Write("Enter Lastname: ");

            //Lastname validation
            userInfo[1] = Console.ReadLine();

            bool b = Checkvalid(userInfo[1]);

            while (b == false)
            {
                Console.Write("Enter Lastname: ");
                userInfo[1] = Console.ReadLine();
                b = Checkvalid(userInfo[1]);
            }
            Console.Write("Enter Email: ");

            //email validation
            userInfo[7] = Console.ReadLine();

            bool g = Emailvalidate(userInfo[7]);

            while (g == false)
            {
                Console.Write("Enter Email: ");
                userInfo[7] = Console.ReadLine();
                g = Emailvalidate(userInfo[7]);
            }

            Console.Write("Enter Country: ");
            //country validate
            userInfo[2] = Console.ReadLine();

            bool c = Countvalidate(userInfo[2]);

            while (c == false)
            {
                Console.Write("Enter Country: ");
                userInfo[2] = Console.ReadLine();
                c = Countvalidate(userInfo[2]);
            }

            Console.Write("Enter City: ");
            //city validate
            userInfo[3] = Console.ReadLine();

            bool d = Cityvalidate(userInfo[3]);

            while (d == false)
            {
                Console.Write("Enter City: ");
                userInfo[3] = Console.ReadLine();
                d = Cityvalidate(userInfo[3]);
            }
            Console.Write("Enter Province: ");
            //province validate
            userInfo[4] = Console.ReadLine();
            bool e = Cityvalidate(userInfo[4]);

            while (e == false)
            {
                Console.Write("Enter Province: ");
                userInfo[4] = Console.ReadLine();
                e = Cityvalidate(userInfo[4]);
            }

            Console.Write("Enter Street Address: ");

            //street validate
            userInfo[5] = Console.ReadLine();

            bool f = Cityvalidate(userInfo[5]);

            while (f == false)
            {
                Console.Write("Enter Street Address: ");
                userInfo[5] = Console.ReadLine();
                f = Streetvalidate(userInfo[5]);
            }

            Console.Write("Zip Code: ");
            //zipcode validate
            userInfo[8] = Console.ReadLine();

            bool h = Zipvalid(userInfo[8]);

            while (h == false)
            {
                Console.Write("Zip Code: ");
                //zipcode validate
                userInfo[8] = Console.ReadLine();

                h = Zipvalid(userInfo[8]);
            }
            userNumints[1] = Int32.Parse(userInfo[8]);

            Console.Write("Enter Telephone: ");
            //Telphone validate
            userInfo[9] = Console.ReadLine();
            bool I = Telvalid(userInfo[9]);

            while (I == false)
            {
                Console.Write("Enter Telephone: ");

                userInfo[9] = Console.ReadLine();

                I = Telvalid(userInfo[9]);
            }
            phoneNum[0] = Int64.Parse(userInfo[9]);

            Console.Write("Item code: ");

            //item code validate
            userInfo[10] = Console.ReadLine();

            bool j = Itemvalid(userInfo[10]);

            while (j == false)
            {
                Console.Write("Item code: ");

                userInfo[10] = Console.ReadLine();

                j = Itemvalid(userInfo[10]);
            }
            userNumints[2] = Int32.Parse(userInfo[10]);

            Console.Write("Item Id: ");
            userInfo[11] = Console.ReadLine();
            bool L = Itemidvalid(userInfo[11]);
            while (L == false)
            {
                Console.Write("Item code: ");

                userInfo[10] = Console.ReadLine();

                j = Itemidvalid(userInfo[11]);
            }
            userNumints[4] = Int32.Parse(userInfo[11]);

            Console.Write("Enter item Quantity: ");

            //Item quantity validate
            userInfo[11] = Console.ReadLine();

            bool K = Itemquantyvalid(userInfo[11]);

            while (K == false)
            {
                Console.Write("Enter item Quantity: ");

                userInfo[11] = Console.ReadLine();

                K = Itemquantyvalid(userInfo[11]);
            }
            phoneNum[1] = Int64.Parse(userInfo[11]);

            Console.Write("Item price: ");
            //item price
            itemPrice[0] = double.Parse(Console.ReadLine());

            //computation
            double total = phoneNum[1] * itemPrice[0];
            //main output
            Console.WriteLine("Here your order form: ");
            Console.WriteLine("----------------------");
            Console.WriteLine("Item id: " + userNumints[4]);
            Console.WriteLine("Item Number: ");
            Console.WriteLine("Last Name: " + userInfo[1]);
            Console.WriteLine("First Name: " + userInfo[0]);
            Console.WriteLine("Email Address :" + userInfo[7]);
            Console.WriteLine("Telephone number: " + phoneNum[0]);
            Console.WriteLine("Street Address " + userInfo[5]);
            Console.WriteLine("City: " + userInfo[3]);
            Console.WriteLine("State/Province " + userInfo[4]);
            Console.WriteLine("ZIP code: " + userNumints[1]);
            Console.WriteLine("Country: " + userInfo[2]);
            Console.WriteLine("Item code: " + userNumints[2]);
            Console.WriteLine("Item quantity: " + phoneNum[1]);
            Console.WriteLine("Item price: " + itemPrice[0]);
            Console.WriteLine("Total price: " + total);
        }

        //input valid check
        public static bool Itemprice(string a)
        {
            if (a.Length <= 30 && a.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Itemidvalid(string a)
        {
            if (a.Length <= 30 && a.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Checkvalid(string a)
        {
            if (a.Length <= 30 && a.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Itemquantyvalid(string a)
        {
            if (a.Length >= 1 && a.Length <= 1000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Zipvalid(string a)
        {
            if (a.Length == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Itemvalid(string a)
        {
            if (a.Length == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Telvalid(string a)
        {
            if (a.Length < 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Emailvalidate(string a)
        {
            if (a.Length == 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Countvalidate(string a)
        {
            if (a.Length >= 10 && a.Length <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Cityvalidate(string a)
        {
            if (a.Length >= 1 && a.Length <= 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Streetvalidate(string a)
        {
            if (a.Length >= 1 && a.Length <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}