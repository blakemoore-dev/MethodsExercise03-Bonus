using System;

namespace MethodsExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 9, y = 3;
            var z = new Random().Next(1, 100);

            Console.WriteLine(Add(x, y, 1, 123, 551, z));
            Console.WriteLine(Subtract(x, y, z));
            Console.WriteLine(Multiply(x, y, z));
            Console.WriteLine(Divide(x, y, z));
            Console.WriteLine(Modulus(x, y, z));
        }
        public static int Add(params int[] sum)
        {
            var result = 0;
            foreach (var s in sum)
                result += s;
            return result;
        }
        public static int Subtract(params int[] diff)
        {
            var result = 0;
            foreach (var d in diff)
                result -= d;
            return result;
        }
        public static int Multiply(params int[] multiples)
        {
            var result = 1;
            foreach (var m in multiples)
                result *= m;
            return result;
        }
        public static decimal Divide(params int[] divisors)
        {
            decimal result = divisors[0];
            for (var i = 1; i < divisors.Length; i++)
                result /= divisors[i];
            return result;
        }
        public static int Modulus(params int[] input)
        {
            var result = input[0];
            for (var i = 1; i < input.Length; i++)
                if (result != 0)
                    result %= input[i];
                else
                    return result;
            //Console.WriteLine(input[2]);
            return result;
        }
    }
}
