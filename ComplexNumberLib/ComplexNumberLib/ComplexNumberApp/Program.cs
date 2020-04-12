using System;
using ComplexNumberLib;


namespace ComplexNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 4)
            {
                Console.Error.WriteLine("Error: Sorry, not enough arguments");
                Console.Error.WriteLine("Usage: ComplexNumberApp.exe a b c d");
            }
            else if (args.Length > 4)
            {
                Console.Error.Write("To much arguments: ");

                for (var i = 4; i < args.Length; i++)
                {
                    Console.Error.Write(args[i] + " ");
                }
                Console.Error.WriteLine("");
                Start(args);
            }
            else 
            {
                Start(args);
            }

        }

        static void Start(string[] args)
        {
            double index1 = 0;
            double index2 = 0;
            double index3 = 0;
            double index4 = 0;

            if (Double.TryParse(args[0], out index1) == false)
            {
                Console.Error.WriteLine("Argument {0} is not number", args[0]);
                Environment.Exit(0);
            }
            if (Double.TryParse(args[1], out index2) == false)
            {
                Console.Error.WriteLine("Argument {0} is not number", args[1]);
                Environment.Exit(0);
            }
            if (Double.TryParse(args[2], out index3) == false)
            {
                Console.Error.WriteLine("Argument {0} is not number", args[2]);
                Environment.Exit(0);
            }
            if (Double.TryParse(args[3], out index4) == false)
            {
                Console.Error.WriteLine("Argument {0} is not number", args[3]);
                Environment.Exit(0);
            }

            var x = new ComplexNumber(index1, index2);
            var y = new ComplexNumber(index3, index4);

            Console.WriteLine("x:");
            Console.WriteLine("Magnitude of x: " + x.GetMagnitude());
            Console.WriteLine("\t Geometric form:" + x.ToString(ComplexNumberFormat.GeometricForm));
            Console.WriteLine("\t Algebraic form:" + x.ToString(ComplexNumberFormat.AlgebraicForm));
            Console.WriteLine("\t Trigonometric form:" + x.ToString(ComplexNumberFormat.TrigonometricForm));

            Console.WriteLine("y:");
            Console.WriteLine("Magnitude of y: " + y.GetMagnitude());
            Console.WriteLine("\t Geometric form:" + y.ToString(ComplexNumberFormat.GeometricForm));
            Console.WriteLine("\t Algebraic form:" + y.ToString(ComplexNumberFormat.AlgebraicForm));
            Console.WriteLine("\t Trigonometric form:" + y.ToString(ComplexNumberFormat.TrigonometricForm));

            Console.WriteLine("x == y " + (x == y));
            Console.WriteLine("x != y " + (x != y));

            Console.WriteLine("x == ComplexNumber.Zero " + (x == ComplexNumber.Zero));
            Console.WriteLine("x == ComplexNumber.One " + (x == ComplexNumber.One));
            Console.WriteLine("x == ComplexNumber.ImaginaryOne " + (x == ComplexNumber.ImaginaryOne));

            Console.WriteLine("y == ComplexNumber.Zero " + (y == ComplexNumber.Zero));
            Console.WriteLine("y == ComplexNumber.One " + (y == ComplexNumber.One));
            Console.WriteLine("y == ComplexNumber.ImaginaryOne " + (y == ComplexNumber.ImaginaryOne));
            
            Console.WriteLine("x + y " + (x + y));
            Console.WriteLine("x - y " + (x - y));
            Console.WriteLine("x * y " + (x * y));
            Console.WriteLine("x / y " + (x / y));

        }
    }
}
