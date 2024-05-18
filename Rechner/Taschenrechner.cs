using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tr
{
    public class Taschenrechner
    {
        //declaring important variables 
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Angle { get; set; }
        public short Operation { get; set; }

       
        //Constructor
        public Taschenrechner() 
        {
            //making all the variables be empty 
            Num1 = 0;
            Num2 = 0;
            Operation = 0;
            Angle = 0;
        }
        

        //arithmetic operations
        public double Add(double x, double y) { return x + y;}

        public double Sub(double x, double y) { return x - y; }

        public double Mul(double x, double y) { return x * y; }

        public double Div(double x, double y) { return x / y; }

        // Special operations
        public double Exp(double x, double exp) { return Math.Pow(x, exp);}
        

        public double SquareRoot(double x) {  return Math.Sqrt(x);}

        public double Logarithm(double x, double baseValue) {   return Math.Log(x, baseValue); }

        public double Factorial(double x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                double result = 1;
                for (int i = 1; i <= x; i++)
                {
                    result *= i;
                }
                return result;
            }
        }
        

        public double DegreesToRadians(double angle)
        {
            return angle * Math.PI / 180.0;
        }

        public double Sine(double angle)
        {
            double angleRadians = DegreesToRadians(angle);
            return Math.Sin(angleRadians);
        }

        public double Cosine(double angle)
        {
            double angleRadians = DegreesToRadians(angle);
            return Math.Cos(angleRadians);
        }

        public double Tangent(double angle)
        {
            double angleRadians = DegreesToRadians(angle);
            return Math.Tan(angleRadians);
        }
    }
}
