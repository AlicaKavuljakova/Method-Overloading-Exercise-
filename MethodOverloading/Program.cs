using System.Net.NetworkInformation;
using System;

namespace MethodOverloading
{
    public class Program
    {
        //----Exercise 1-----------
        public static int Add(int x, int y)
        {// Create a method named Add, that accepts two integers and returns the sum of those two integers
return x + y;
        }
        public static decimal Add(decimal a, decimal b)
        { //Now create an overload of the Add method to account for being able to add two decimals together
return a + b;   
        }
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool isTrue)
        { //Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
            int sum = x + y;
            var message = "";
            // Option1----------------
            /* 
             if (isTrue==true && sum==1)
             {
                  message= $"1 dollar";
                 }
              else if(isTrue==true && sum>1)
             {
                   message= $"{sum} dollars ";
               }
               else if(isTrue==true && sum<1)
             {
                 message=$"{sum} dollars";
             }
             else
             {
                 message =sum.ToString();
             }return message;
            */
            //Option2------
            if (isTrue && sum==1)
            {
                message = "1 dollar";
            }
            else if (isTrue && sum!=1)
            {
                message = $"{sum} dollars";
            }
            else {
                message = sum.ToString();
            }return message;
        }
//If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
//You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”
        static void Main(string[] args)
        {
            var x = 29;
            var y = 55;

            var answer = Add(x, y);

            var a = 32.0m;
            var b = 45.0m;

            var decimalAnswer = Add(a, b);

            var thirdAnswer = Add(0, 0, true);

            Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(thirdAnswer);
        }
    }
}
