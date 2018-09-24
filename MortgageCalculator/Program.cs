// Shamoil Soni Proj1 IT330
using System;

namespace MortgageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";

            Console.WriteLine("Enter \"q\" to quit");
            Console.WriteLine();

            while (userInput != "q")
            {
                // Initialize the userOutput and prompt user to enter the principleAmount 
                string userOutput = null;
                Console.Write("Enter the principal amount: ");
                userInput = Console.ReadLine();

                // Validate and convert the principleAmount to double
                if (Double.TryParse(userInput, out double principalAmount) && principalAmount >= 1)
                {
                    while (userOutput == null)
                    {
                        //If the principleAmount is valid then prompt user for the number of years
                        Console.Write("Enter the number of years: ");
                        userInput = Console.ReadLine();

                        // Validate and convert the numOfYears to double
                        if (Double.TryParse(userInput, out double numOfYears) && numOfYears >= 1)
                        {
                            while (userOutput == null)
                            {
                                //If the numOfYears is valid then prompt user for the interest rate
                                Console.Write("Enter the interest rate: ");
                                userInput = Console.ReadLine();

                                // Validate and convert the interestRate to double
                                if (Double.TryParse(userInput, out double interestRate) && interestRate >= 0.1)
                                {
                                    // Calculate the mortgage monthly payments
                                    double rateOfInterest = interestRate / 1200.0;
                                    double numOfPayments = -(numOfYears * 12.0);

                                    userOutput = (rateOfInterest * principalAmount / (1 - Math.Pow(1 + rateOfInterest, numOfPayments))).ToString();

                                    Console.WriteLine();
                                    Console.WriteLine($"Your monthly mortgage payment is {userOutput}");
                                    Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
