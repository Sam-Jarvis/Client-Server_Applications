using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CalculatorContract;

namespace service
{
    /*
     * This class runs as the service, implements the interface.
     */
    class CCalculator : ICalculator
    {
        public double add(double no1, double no2)
        {
            double result = no1 + no2;
            Console.WriteLine("Add {0}, {1}", no1, no2);
            Console.WriteLine("Result: " + result);
            return result;
        }

        public double subtract(double no1, double no2)
        {
            double result = no1 - no2;
            Console.WriteLine("Subtract {0}, {1}", no1, no2);
            Console.WriteLine("Result: " + result);
            return result;
        }

        public double multiply(double no1, double no2)
        {
            double result = no1 * no2;
            Console.WriteLine("Multiply {0}, {1}", no1, no2);
            Console.WriteLine("Result: " + result);
            return result;
        }

        public double divide(double no1, double no2)
        {
            double result = no1 / no2;
            Console.WriteLine("Divide {0}, {1}", no1, no2);
            Console.WriteLine("Result: " + result);
            return result;
        }
    }
}
