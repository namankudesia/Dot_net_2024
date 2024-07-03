using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC3
{
    class Test
    {
        static void Main(string[] args)
        {   //1st Program Main function
            Console.Write("Enter the number of IPL matches: ");
            int numMatches = Convert.ToInt32(Console.ReadLine());
            Cricket cricket = new Cricket();
            cricket.PointsCalculation(numMatches);
            Console.WriteLine();

            //2nd Program Main function
            Console.WriteLine("Enter dimensions for Box 1:");
            Console.Write("Length: ");
            double length1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Breadth: ");
            double breadth1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter dimensions for Box 2:");
            Console.Write("Length: ");
            double length2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Breadth: ");
            double breadth2 = Convert.ToDouble(Console.ReadLine());
            Box box1 = new Box(length1, breadth1);
            Box box2 = new Box(length2, breadth2);
            Box box3 = Box.AddBoxes(box1, box2);
            Console.WriteLine("\nResultant Box:");
            box3.DisplayDetails();

            Console.Read();
        }
    }
        //1st Program
        public class Cricket
        {
            private int[] scores;
            public void PointsCalculation(int no_of_matches)
            {
                scores = new int[no_of_matches];
                int sum = 0;
                for (int i = 0; i < no_of_matches; i++)
                {
                    Console.Write($"Enter points scored in match {i + 1}: ");
                    scores[i] = Convert.ToInt32(Console.ReadLine());
                    sum += scores[i];
                }
                double average = (double)sum / no_of_matches;
                Console.WriteLine($"\nTotal points scored: {sum}");
                Console.WriteLine($"Average points scored per match: {average:F2}");
            }
        }
        //2nd Program
        public class Box
        {
            public double Length { get; set; }
            public double Breadth { get; set; }
            public Box(double length, double breadth)
            {
                Length = length;
                Breadth = breadth;
            }
            public static Box AddBoxes(Box box1, Box box2)
            {
                double newLength = box1.Length + box2.Length;
                double newBreadth = box1.Breadth + box2.Breadth;
                return new Box(newLength, newBreadth);
            }
            public void DisplayDetails()
            {
                Console.WriteLine($"Box details - Length: {Length}, Breadth: {Breadth}");
            }
        }
    }


