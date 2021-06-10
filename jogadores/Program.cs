using System;

namespace jogadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Qual tipo de jogador você é?");
            Console.WriteLine("(d = Defesa; m = Meio de Campo; a= Ataque)");
            Console.ForegroundColor = ConsoleColor.White;
            string playerty = Console.ReadLine();

            switch(playerty) {
                case "d":
                defense dp = new defense();
                dp.data();
                dp.sdata();
                dp.retire();
                break;

                case "m":
                midfield mp = new midfield();
                mp.data();
                mp.sdata();
                mp.retire();
                break;

                case "a":
                attack ap = new attack();
                ap.data();
                ap.sdata();
                ap.retire();
                break;
            }

        }
    }
}
