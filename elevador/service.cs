using System;

namespace elevador
{
    public class service
    {
        public static int box = 0;
        public static int cbox;
        public static int cfloorb;
        public static void enterb()
        {
            if (cbox < box)
            {
                cbox++;
            }
            else
            {
                Console.WriteLine("O elevador está lotado. Por favor aguarde.");
            }
        }
        public static void leaveb()
        {
            if (cbox != 0)
            {
                cbox--;
            }
            else
            {
                Console.WriteLine("Não existe nenhuma caixa no elevador.");
            }
        }
        public static void up()
        {
            if (cfloorb < general.floor)
            {
                cfloorb++;
            }
            else
            {
                Console.WriteLine("O elevador já está no último andar.");
            }
        }
        public static void down()
        {
            if (cfloorb != 0)
            {
                cfloorb--;
            }
            else
            {
                Console.WriteLine("O elevador está no térreo.");
            }
        }
    }
}