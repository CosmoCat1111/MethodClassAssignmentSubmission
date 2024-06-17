using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignmentSubmission
{
    class Program
    {
              static void Main()
            {
                MathOperations mathOps = new MathOperations();

                mathOps.PerformOperation(10, 5);
                //  method with two integers 
                mathOps.PerformOperation(num1: 7, num2: 3);
                // method showing number
                Console.WriteLine("Press any key to exit....");
                Console.ReadLine();
        }
    }
}

