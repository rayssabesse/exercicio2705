using System;

namespace elevador
{
    public class social
    {
        public static int people = 0;
        public static int cpeople;
        public static int cfloorp;
        public static void enterp()
        {
            if (cpeople < people)
            {
                cpeople++;
            }
            else
            {
                Console.WriteLine("O elevador está lotado. Por favor aguarde.");
            }
        }
        public static void leavep()
        {
            if (cpeople != 0)
            {
                cpeople--;
            }
            else
            {
                Console.WriteLine("Não há ninguém no elevador.");
            }
        }
        public static void up()
        {
            if (cfloorp < general.floor)
            {
                cfloorp++;
            }
            else
            {
                Console.WriteLine("O elevador já está no último andar.");
            }
        }
        public static void down(){
            if (cfloorp != 0) {
                cfloorp--;
            }
            else{
                Console.WriteLine("O elevador já está to térreo.");
            }
        }
    }
}