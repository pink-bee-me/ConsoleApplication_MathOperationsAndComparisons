using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_MathOperationsAndComparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Math Operations And Comparisons Console \nWe've Been Waiting For You!...but NOT in a creepy way.");
                Console.ReadLine();

            //Collect user input number and multiply by 50 /  return product value to console
            Console.WriteLine("This is where we take a whole number ( of your choice) and return that number multiplied by 50.\nSounds like fun! Right???\nPlease input your number: ");
            int userInputProduct= Convert.ToInt32(Console.ReadLine());
            string multBy50 = Convert.ToString(userInputProduct * 50);
            string userInAndOutProductNumber = Convert.ToString(userInputProduct);
            Console.WriteLine(userInAndOutProductNumber+ "  *  50 =  " + multBy50);
 
            //.Collect user input number and adds 25 / return total value to console
            Console.WriteLine("Let's try Addition. You give me a number, then I will add 25 to it, and give you back the total!\nPlease Input a whole number : ");
            int userInputAdd= Convert.ToInt32(Console.ReadLine());
            string add25 = Convert.ToString(userInputAdd + 25);
            string userInAndOutAddNumber = Convert.ToString(userInputAdd);
            Console.WriteLine(userInAndOutAddNumber + " +  25 = " + add25);
              

            //collect user input divide by 12.5 / return divisable value to console
            Console.WriteLine("Let's try division. This time we will divide by the decimal value of 12.5\nPlease Input a number: ");
           int userInputDivByDecimal = Convert.ToInt32(Console.ReadLine());
           double divByDecimal= userInputDivByDecimal / 12.5;
           string answerDivByDecimal = Convert.ToString(divByDecimal);
           string userInAndOutDivByDecimalNumber = Convert.ToString(userInputDivByDecimal);
           Console.WriteLine(userInAndOutDivByDecimalNumber + "  /  12.5 =  " + divByDecimal);

            //collect user input and check if input is greater than 50 / return  true or false to the console
            Console.WriteLine("Let's try a comparison,...Is your number greater than 50? Let's check! \nPlease Input a number : ");
            int userInputComparison = Convert.ToInt32(Console.ReadLine());
            bool greaterThan50 = userInputComparison > 50;
            string userInAndOutComparisonNumber = Convert.ToString(userInputComparison);
            Console.WriteLine(userInAndOutComparisonNumber + "  >  50 =  " + greaterThan50);
            Console.ReadLine();

        }
    }
}
