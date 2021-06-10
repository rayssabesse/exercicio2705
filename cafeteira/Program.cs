using System;

namespace cafeteira
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta1;
            bool validade = true;
            Console.Clear();
            Console.WriteLine("Boa tarde, vai açúcar no café? Digite a quantidade em gramas");
            Console.WriteLine("Você pode apenas dar enter para um padrão de 10g de açúcar!");
            do {
            string resposta = (Console.ReadLine());
            if (int.TryParse(resposta, out resposta1) == true || string.IsNullOrEmpty(resposta) == true){
                cm m = new cm();
                if (string.IsNullOrEmpty(resposta) == true){
                    Console.WriteLine( m.fazercafe());
                    validade = true;
                    Console.WriteLine("pressione qualquer botão para encerrar a sessão");
                    Console.ReadKey();
                    Console.Clear();
                }
                else {
                    Console.WriteLine(m.fazercafe(resposta1));
                    Console.WriteLine("pressione qualquer botão para encerrar a sessão");
                    Console.ReadKey();
                    validade = true;
                    Console.Clear();
                }
            }
            else {
                Console.WriteLine("Entrada não reconhecida, tente novamente");
                validade = false;
            }
            } while (validade == false);
        }
    }
}
