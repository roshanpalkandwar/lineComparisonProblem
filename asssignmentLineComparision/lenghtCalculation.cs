﻿
namespace asssignmentLineComparision
{
    
    internal class lengthcalculation
    {
        public static void lenght()
        {
            Console.WriteLine("enter the first co-ordinate of x1");
            double x1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the first co-ordinate of y1");
            double y1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the second co-ordinate of x2 & y2");
            double x2=Convert.ToDouble(Console.ReadLine());
            double y2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the first co-ordinate of a1 & b1");
            double a1=Convert.ToDouble(Console.ReadLine());
            double b1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the second co-ordinate of a2 & b2");
            double a2=Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());

            double tem1 = Math.Pow((x2 - x1), 2);
            double tem2 = Math.Pow((y2 - y1), 2);
            double lenght1 = Math.Sqrt(tem1 + tem2);
            Console.WriteLine("the co-ordinate length1 is  "+lenght1);
            double tem3 = Math.Pow((a2 - a1), 2);
            double tem4 = Math.Pow((b2 - b1), 2);
            double lenght2 = Math.Sqrt(tem3 + tem4);
            Console.WriteLine("the co-ordinate length2 is  "+lenght2);

        } 
        
    }
        
              

        
    
 }