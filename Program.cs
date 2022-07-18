 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quad_form
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the coefficient of x^2");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the coefficient of x");
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the constant");
            double c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The equation {a}x^2 + {b}x + {c} = 0");

            double soln1;
            double soln2;
            double top = (b * b)- (4*a*c) ;
            double bottom = 2*a;

            if(a == 0)
            {
                Console.WriteLine("Linear solution");
                soln1= -c/b;
                Console.WriteLine($"X= {soln1}");
            }
            else if (top == 0)
            {
                Console.WriteLine("Repeated solution");
                soln1= -b/bottom;
                Console.WriteLine($"X= {soln1}(twice)");
            }
            else if (top >0)
            {
                soln1 =(-b + Math.Sqrt(top))/ bottom;
                soln2 = (-b - Math.Sqrt(top))/ bottom;
                Console.WriteLine($"x ={soln1} or {soln2} ");
            }
                 
            Console.ReadLine();


        }
    }
}

