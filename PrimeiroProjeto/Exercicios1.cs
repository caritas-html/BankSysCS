namespace PrimeiroProjeto {
    internal class Exercicios1 {

        public int Number1 = int.Parse(Console.ReadLine());
        public int Number2 = int.Parse(Console.ReadLine());

        public void Sum() {
            int Result = Number1 + Number2;
            Console.WriteLine($"A soma de {Number1} + {Number2} é: {Result}");
        }
    }
}
