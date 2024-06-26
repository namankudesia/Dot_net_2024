using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC2
{
    class Program
    {
        static void Main(string[] args)
        {   //Program 1 main function
            Console.WriteLine("Enter student name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student ID:");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student grade:");
            double grade = Convert.ToDouble(Console.ReadLine());
            Ugraduate undergrad = new Ugraduate
            {
                SName = name,
                SId = studentId,
                G = grade
            };
            Graduate grad = new Graduate
            {
                SName = name,
                SId = studentId,
                G = grade
            };
            bool undergradPassed = undergrad.IsPassed(grade);
            bool gradPassed = grad.IsPassed(grade);
            Console.WriteLine("\nUndergraduate:");
            Console.WriteLine($"Name: {undergrad.SName}");
            Console.WriteLine($"Student ID: {undergrad.SId}");
            Console.WriteLine($"Grade: {undergrad.G}");
            Console.WriteLine($"Passed: {undergradPassed}");
            Console.WriteLine("\nGraduate:");
            Console.WriteLine($"Name: {grad.SName}");
            Console.WriteLine($"Student ID: {grad.SId}");
            Console.WriteLine($"Grade: {grad.G}");
            Console.WriteLine($"Passed: {gradPassed}");
            Console.WriteLine("------------Program 1 Ends Here-------- -");
            //Program 2 main function
            Products[] products = new Products[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for Product {i + 1}:");

                Console.Write("Product ID: ");
                int productId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                products[i] = new Products(productId, productName, price);
            }
            Array.Sort(products, (p1, p2) => p1.PPrice.CompareTo(p2.PPrice));
            Console.WriteLine("\nSorted Products based on Price:");
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.PId}, Name: {product.PName}, Price: {product.PPrice}");
            }
            Console.WriteLine("------------Program 2 Ends Here-------- -");

            //Program 3 main function
            try
            {
                Console.WriteLine("Enter a number:");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                PNumber(inputNumber);
            }
            catch (NegativeNoException ex)
            {
                Console.WriteLine($"Exception occurred: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Input is not in correct format: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            Console.WriteLine("------------Program 3 Ends Here-------- -");
            Console.ReadLine();
        }
           //Program 1
        public abstract class Students
        {
            public string SName { get; set; }
            public int SId { get; set; }
            public double G { get; set; }
            public abstract bool IsPassed(double g);
        }
        public class Ugraduate : Students
        {
            public override bool IsPassed(double g)
            {
                return g > 70.0;
            }
        }
        public class Graduate : Students
        {
            public override bool IsPassed(double g)
            {
                return g > 80.0;
            }
        }
        //Program 2
        public class Products
        {
            public int PId { get; set; }
            public string PName { get; set; }
            public double PPrice { get; set; }
            public Products(int id, string name, double price)
            {
                PId = id;
                PName = name;
                PPrice = price;
            }
        }
        //Program 3
        public class NegativeNoException : Exception
        {
            public NegativeNoException()
            {
            }
            public NegativeNoException(string message)
                : base(message)
            {
            }
            public NegativeNoException(string message, Exception innerException)
                : base(message, innerException)
            {
            }
        }
        public static void PNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeNoException("Number cannot be negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is valid.");
            }
        }
    }
}
