namespace Uniza.CSharp.Generics.Tools
{
    public class Swapper
    {
        //public static void Swap(ref int number1, ref int number2)
        //{
        //    var temp = number1;
        //    number1 = number2;
        //    number2 = temp;
        //}

        //public static void Swap(ref double number1, ref double number2)
        //{
        //    var temp = number1;
        //    number1 = number2;
        //    number2 = temp;
        //}

        //public static void Swap(ref string str1, ref string str2)
        //{
        //    var temp = str1;
        //    str1 = str2;
        //    str2 = temp;
        //}

        public static void Swap<T>(ref T str1, ref T str2)
        {
            var temp = str1;
            str1 = str2;
            str2 = temp;
        }
    }
}
