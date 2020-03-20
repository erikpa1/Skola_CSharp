using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumberLib
{

    public enum ComplexNumberFormat
    {
        AlgebraicForm,
        GeometricForm,
        TrigonometricForm
    }

    public class ComplexNumber
    {
        public static readonly ComplexNumber ImaginaryOne = new ComplexNumber(0, 1);
        public static readonly ComplexNumber One = new ComplexNumber(1, 0);
        public static readonly ComplexNumber Zero = new ComplexNumber(0, 0);

        private double _imaginary;
        private double _magnitude;
        private double _real;

        public ComplexNumber(double real)
        {
            _real = real;
            _imaginary = 0;
            _magnitude = _real;
        }
        public ComplexNumber(double real, double imaginary)
        {
            _real = real;
            _imaginary = imaginary;
            _magnitude = Math.Sqrt(Math.Pow(_real, 2) + Math.Pow(_imaginary, 2));
        }

        public string ToString(ComplexNumberFormat format)
        {
            if (format == ComplexNumberFormat.AlgebraicForm)
            {
                if (_imaginary < 0)
                {
                    return _real + " " + _imaginary + "i";
                }
                else
                {
                    return _real + " + " + _imaginary + "i";
                }
            }
            else if (format == ComplexNumberFormat.GeometricForm)
            {
                return ToString();
            }
            else if (format == ComplexNumberFormat.TrigonometricForm)
            {
                return _magnitude + " * (cos" + GetAngleString(_real) + " + " + GetAngleString(_imaginary) + "i)";  
            }

            return "Error";
        }

        private String GetAngleString(double b)
        {
            return Math.Asin(b/_magnitude).ToString("N4");
        }

        public override string ToString()
        {
            return "[" + _real + ";" + _imaginary + "]";
        }

        public bool Equals(ComplexNumber other)
        {
            if (other._imaginary == _imaginary && other._real == _real)
            {
                return true;
            }
            return false;
        }

        public bool Equals(double number)
        {
            if (_imaginary == 0)
            {
                if (number == _real)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public double GetMagnitude()
        {
            return _magnitude;
        }


        public static ComplexNumber Add(ComplexNumber left, ComplexNumber right)
        {
            return left + right;
        }

        public static ComplexNumber Substract(ComplexNumber left, ComplexNumber right)
        {
            return left - right;        
        }

        public static ComplexNumber Multiply(ComplexNumber left, ComplexNumber right)
        {
            return left * right;
        }

        public static ComplexNumber Divide(ComplexNumber left, ComplexNumber right)
        {
            return left / right;
        }

        public static ComplexNumber operator +(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber(left._real + right._real, left._imaginary + right._imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber(left._real - right._real, left._imaginary - right._imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber(left._real * right._real, left._imaginary * right._imaginary);
        }

        public static ComplexNumber operator /(ComplexNumber left, ComplexNumber right)
        {
            
            return new ComplexNumber((left._real * right._real + left._imaginary + right._imaginary) / (Math.Pow(right._real, 2) + Math.Pow(right._imaginary, 2)),
                (left._imaginary * right._real - left._real * right._imaginary) / (Math.Pow(right._real, 2) + Math.Pow(right._imaginary, 2)));
        }

        public static bool operator ==(ComplexNumber left, ComplexNumber right)
        {
            return left._real == right._real && left._imaginary == right._imaginary;
        }

        public static bool operator !=(ComplexNumber left, ComplexNumber right)
        {
            return !(left == right);
        }









    }
}
