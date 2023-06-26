namespace PrimeiroProjeto {
    internal static class Exercicio3 {
        public static void Output() {

            int entryPoint1 = int.Parse(Console.ReadLine());
            int entryPoint2 = int.Parse(Console.ReadLine());
            int entryPoint3 = int.Parse(Console.ReadLine());
            int entryPoint4 = int.Parse(Console.ReadLine());


            int difference = entryPoint1 * entryPoint2 - entryPoint3 * entryPoint4;

            Console.WriteLine($"diferenca: {difference}");

        }
    }
}
