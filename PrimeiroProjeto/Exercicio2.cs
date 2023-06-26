using System.Globalization;

namespace PrimeiroProjeto {
    internal static class Exercicio2 {
        public static void OutPut() {

            double EntryPoint = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;

            double Result = Math.Pow(EntryPoint, 2.00) * pi;

            Console.WriteLine(Result);

            Console.WriteLine($"A área de uma esfera perfeita de raio {EntryPoint} é {Result}");
        }
    }
}
