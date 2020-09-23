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
 
            //.Collect user input number and divide by 25 / return divisable value to console
            Console.WriteLine("Let's try division,... Please Input a whole number to be divided by 25 : ");
            int userInputDivision = Convert.ToInt32(Console.ReadLine());
            string divBy25 = Convert.ToString(userInputDivision / 25);
            string userInAndOutDivisionNumber = Convert.ToString(userInputDivision);
            Console.WriteLine(userInAndOutDivisionNumber + "  /  25 =  " + divBy25);

            //collect user input divide by 12.5 / return divisable value to console
            Console.WriteLine("Let's try division again. This time we will divide by the decimal value of 12.5\nPlease Input a whole number: ");
            int userInputDivByFloat = Convert.ToInt32(Console.ReadLine());
            string divByFloat = Convert.ToString(userInputDivByFloat / 12.5F);
            string userInAndOutDivByFloatNumber = Convert.ToString(userInputDivByFloat);
            Console.WriteLine(userInAndOutDivByFloatNumber + "  /  12.5 =  " + divByFloat);

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
