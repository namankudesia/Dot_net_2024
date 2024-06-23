using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Third_Week_
{
    
        public class Saledetails
        {
            private int SalesNo;
            private int ProductNo;
            private double Price;
            private DateTime DateOfSale;
            private int Qty;
            private double TotalAmount;
            public Saledetails(int salesNo, int productNo, double price, int qty, DateTime dateOfSale)
            {
                this.SalesNo = salesNo;
                this.ProductNo = productNo;
                this.Price = price;
                this.Qty = qty;
                this.DateOfSale = dateOfSale;
                Sales();
            }
            private void Sales()
            {
                TotalAmount = Qty * Price;
            }
            public void ShowData()
            {
                Console.WriteLine("\nSale Details:");
                Console.WriteLine($"Sales No: {SalesNo}");
                Console.WriteLine($"Product No: {ProductNo}");
                Console.WriteLine($"Price: {Price:C}");
                Console.WriteLine($"Quantity: {Qty}");
                Console.WriteLine($"Date of Sale: {DateOfSale.ToShortDateString()}");
                Console.WriteLine($"Total Amount: {TotalAmount:C}");
            }
        }
    }

