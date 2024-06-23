using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Third_Week_
{
    class Accounts
    {
        private int accountNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;

        public Accounts(int accountNo, string customerName, string accountType, char transactionType, double amount)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.transactionType = transactionType;
            this.amount = amount;
            this.balance = 0;
        }

        public void UpdateBalance()
        {
            if (transactionType == 'D')
            {
                Credit(amount);
            }
            else if (transactionType == 'W')
            {
                Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid transaction type.");
            }
        }

        private void Credit(double amount)
        {
            balance += amount;
        }

        private void Debit(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance. Withdrawal not processed.");
            }
        }

        public void ShowData()
        {
            Console.WriteLine("\nAccount Details:");
            Console.WriteLine("Account No: " + accountNo);
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Account Type: " + accountType);
            Console.WriteLine("Transaction Type: " + transactionType);
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Balance: " + balance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account No:");
            int accountNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name:");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter Account Type:");
            string accountType = Console.ReadLine();
            Console.WriteLine("Enter Transaction Type (D for Deposit, W for Withdrawal):");
            char transactionType = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine("Enter Amount:");
            double amount = Convert.ToDouble(Console.ReadLine());
            Accounts acc = new Accounts(accountNo, customerName, accountType, transactionType, amount);
            acc.UpdateBalance();
            acc.ShowData();


            Console.WriteLine("Welcome to Student Result Checker");
            Console.Write("Enter Roll No: ");
            int rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Class: ");
            string className = Console.ReadLine();
            Console.Write("Enter Semester: ");
            string semester = Console.ReadLine();
            Console.Write("Enter Branch: ");
            string branch = Console.ReadLine();
            Student student = new Student(rollNo, name, className, semester, branch);
            student.GetMarks();
            student.DisplayResult();




            Console.WriteLine("Welcome to Sale Details Program");
            Console.Write("Enter Sales No: ");
            int salesNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Product No: ");
            int productNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Price per unit: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Date of Sale (MM/dd/yyyy): ");
            DateTime dateOfSale = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);
            Saledetails sale = new Saledetails(salesNo, productNo, price, qty, dateOfSale);
            sale.ShowData();




            Console.WriteLine("Welcome to Customer Details Program");
            Console.Write("Enter Customer ID: ");
            int customerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            string name1 = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter City: ");
            string city = Console.ReadLine();
            Customer customer = new Customer(customerId, name1, age, phone, city);
            customer.DisplayCustomer();
            Console.WriteLine("\nDeleting customer object...");
            customer = null;
            GC.Collect();
            Console.WriteLine("\nEnd of Program");




            Console.Read();



        }
    }
}


