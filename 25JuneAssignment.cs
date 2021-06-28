using System;

namespace Assignment25jun
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Obj1 = new Program();
            Obj1.A1();

            Program Obj2 = new Program();
            Obj2.A2();

            Program Obj3 = new Program();
            Obj3.A3();

            Program Obj4 = new Program();
            Obj4.A4();

            Program Obj5 = new Program();
            Obj5.A5();

            //Program Obj6 = new Program();
            //Obj6.A6();

        }

        public void A1()
        {
            Console.WriteLine("Enter number 1 :");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2 :");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 3 :");
            int number3 = Convert.ToInt32(Console.ReadLine());

            int result = number1 * number2 * number3;
            Console.WriteLine(result);
        }

        public void A2()
        {
            Console.WriteLine("Enter number 1 :");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2 :");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result1 = number1 * number2;
            Console.WriteLine("{0} * {1} = {2}", number1, number2, result1);

            int result2 = number1 + number2;
            Console.WriteLine("{0} + {1} = {2}", number1, number2, result2);

            int result3 = number1 - number2;
            Console.WriteLine("{0} - {1} = {2}", number1, number2, result3);

            int result4 = number1 / number2;
            Console.WriteLine("{0} / {1} = {2}", number1, number2, result4);
        }

        public void A3()
        {
            Console.WriteLine("Enter number 1 :");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 2 :");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 3 :");
            int number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 4 :");
            int number4 = Convert.ToInt32(Console.ReadLine());

            int result = (number1 + number2 + number3 + number4) / 4;

            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
      number1, number2, number3, number4, result);

        }

        public void A4()
        {
            Console.WriteLine("Input 1st number:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input 2nd number:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Check if one is negative and one is positive:");

            if ((x < 0 && y > 0) || (x > 0 && y < 0) && (x != 0 && y != 0))
            {
                Console.WriteLine("true" + " " + "one number is -ve and one is +ve");

            }
            else
            {
                Console.WriteLine("false");

            }
        }

        public void A5()
        {
            Console.WriteLine("Input 1st number:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input 2nd number:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("if two values are equal return thrive the sum:");

            int result = (x + y);

            if (x == y)
            {
                Console.WriteLine((result) * (result) * (result));

            }
            else
            {
                Console.WriteLine(result + " " + "the two values are not equal");

            }
        }

        //public void A6()
        //{
        //    string firstword;
        //    Console.Write("Input a string : ");
        //    firstword = Console.ReadLine();

        //    if (firstword.Length == 5 && firstword.Equals("Hello"))
        //    {
        //        Console.WriteLine("true" + " " + "String starts with a specified word Hello");
        //    }
        //    else
        //    {
        //        Console.WriteLine(" string doesnt match word is" + " " + firstword);
        //    }
        }
    }
}
