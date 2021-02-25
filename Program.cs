using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {


            var answer = 4;
            //var response = "";

            var response = (answer < 9) ? "is less than nine " : "greater tam equal to nine";
            Console.WriteLine($" {answer} {response}");

















        }
    }
}
