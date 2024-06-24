

using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance =1000.00 ;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine(" Simple ATM Program");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice : ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            // Check Balance
                            Console.WriteLine($"Your current balance is: Rs{balance}");
                            break;
                        case 2:
                            // Deposit Money
                            Console.Write("Enter the amount to deposit: ");
                            if (double.TryParse(Console.ReadLine(), out double depositAmount) && depositAmount > 0)
                            {
                                balance += depositAmount;
                                Console.WriteLine($"Rs{depositAmount} deposited successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount. Deposit failed.");
                            }
                            break;
                        case 3:
                            // Withdraw Money
                            Console.Write("Enter the amount to withdraw: ");
                            if (double.TryParse(Console.ReadLine(), out double withdrawAmount) && withdrawAmount > 0)
                            {
                                if (withdrawAmount <= balance)
                                {
                                    balance -= withdrawAmount;
                                    Console.WriteLine($"Rs{withdrawAmount} withdrawn successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient balance. Withdrawal failed.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount. Withdrawal failed.");
                            }
                            break;
                        case 4:
                            // Exit
                            exit = true;
                            Console.WriteLine(" Thank you!");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear(); // Clear the console for the next iteration
            }
        }
    }
}
