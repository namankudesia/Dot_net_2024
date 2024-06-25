using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Third_Week_
{
    class Program
    {
        private string FirstName;
        private string LastName;
        public Program(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public static void Display(Program person)
        {
            string upperFirstName = person.FirstName.ToUpper();
            string upperLastName = person.LastName.ToUpper();
            Console.WriteLine(upperFirstName);
            Console.WriteLine(upperLastName);
        }
        public class LetterCounter
        {
            public static int CountOccurrences(string inputString, char letter)
            {
                inputString = inputString.ToUpper();

                int count = 0;
                foreach (char c in inputString)
                {
                    if (char.ToUpper(c) == char.ToUpper(letter))
                    {
                        count++;
                    }
                }
                return count;
            }
            public class InsufficientBalanceException : Exception        //Checked Exceptions(ArgumentException, InsufficientBalanceException)
            {                                                           //Unchecked Exceptions(FormatException, OverflowException)
                public InsufficientBalanceException() : base("Insufficient balance in the account.")
                {
                }
            }
            public class BankingTransaction
            {
                private decimal balance;
                public BankingTransaction(decimal initialBalance)
                {
                    balance = initialBalance;
                }
                public void Deposit(decimal amount)
                {
                    if (amount <= 0)
                    {
                        throw new ArgumentException("Deposit amount must be positive.");
                    }

                    balance += amount;
                    Console.WriteLine($"Deposited: {amount}. New balance: {balance}");
                }
                public void Withdraw(decimal amount)
                {
                    if (amount <= 0)
                    {
                        throw new ArgumentException("Withdrawal amount must be positive.");
                    }

                    if (amount > balance)
                    {
                        throw new InsufficientBalanceException();
                    }

                    balance -= amount;
                    Console.WriteLine($"Withdrawn: {amount}. New balance: {balance}");
                }
                public void GetBalance()
                {
                    Console.WriteLine($"Current balance: {balance}");
                }
                public class Scholarship
                {
                    public decimal Merit(int marks, decimal fees)
                    {
                        decimal scholarshipAmount = 0;

                        if (marks >= 70 && marks <= 80)
                        {
                            scholarshipAmount = 0.2m * fees;
                        }
                        else if (marks > 80 && marks <= 90)
                        {
                            scholarshipAmount = 0.3m * fees;
                        }
                        else if (marks > 90)
                        {
                            scholarshipAmount = 0.5m * fees;
                        }

                        return scholarshipAmount;
                    }
                    public class Doctor
                    {
                        private int regnNo;
                        private string name;
                        private decimal feesCharged;

                        public int RegnNo
                        {
                            get { return regnNo; }
                            set { regnNo = value; }
                        }
                        public string Name
                        {
                            get { return name; }
                            set { name = value; }
                        }
                        public decimal FeesCharged
                        {
                            get { return feesCharged; }
                            set { feesCharged = value; }
                        }
                        public void DisplayDoctorDetails()
                        {
                            Console.WriteLine($"Doctor Registration Number: {RegnNo}");
                            Console.WriteLine($"Doctor Name: {Name}");
                            Console.WriteLine($"Fees Charged: {FeesCharged}");
                        }
                        public void DisplayDoctor1Details()
                        {
                            Console.WriteLine($"Doctor Registration Number: {RegnNo}");
                            Console.WriteLine($"Doctor Name: {Name}");
                            Console.WriteLine($"Fees Charged: {FeesCharged}");
                        }
                        public static void Main(string[] args)
                        {
                            Console.Write("Enter First Name: ");
                            string firstName = Console.ReadLine();
                            Console.Write("Enter Last Name: ");
                            string lastName = Console.ReadLine();
                            Program person = new Program(firstName, lastName);
                            Display(person);
                            Console.Write("Enter a string: ");
                            string inputString = Console.ReadLine();
                            Console.Write("Enter a letter to count: ");
                            char letter = Console.ReadLine()[0]; 
                            int occurrences = CountOccurrences(inputString, letter);
                            Console.WriteLine($"Number of occurrences of '{letter}' in the string: {occurrences}");
                            Console.Write("Enter initial balance: ");
                            decimal initialBalance = Convert.ToDecimal(Console.ReadLine());
                            BankingTransaction account = new BankingTransaction(initialBalance);

                            try
                            {
                                Console.Write("Enter deposit amount: ");
                                decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                                account.Deposit(depositAmount);

                                Console.Write("Enter withdrawal amount: ");
                                decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
                                account.Withdraw(withdrawalAmount);

                                Console.Write("Enter withdrawal amount (again): ");
                                withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
                                account.Withdraw(withdrawalAmount); 
                            }
                            catch (InsufficientBalanceException ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Error: Please enter a valid numeric amount.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Unexpected error: {ex.Message}");
                            }
                            Scholarship scholarship = new Scholarship();
                            Console.Write("Enter marks (0-100): ");
                            int marks = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter fees amount: ");
                            decimal fees = Convert.ToDecimal(Console.ReadLine());
                            decimal scholarshipAmount = scholarship.Merit(marks, fees);
                            Console.WriteLine($"Scholarship amount: {scholarshipAmount}");
                            Doctor doctor = new Doctor();
                            Console.Write("Enter Doctor Registration Number: ");
                            doctor.RegnNo = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Doctor Name: ");
                            doctor.Name = Console.ReadLine();
                            Console.Write("Enter Fees Charged: ");
                            doctor.FeesCharged = Convert.ToDecimal(Console.ReadLine());
                            Console.WriteLine("\nDoctor Details:");
                            doctor.DisplayDoctor1Details();
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
