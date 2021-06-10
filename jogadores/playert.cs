using System;

namespace jogadores
{
    public class defense : player
    {
        public void retire()
        {
            if (age <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você ainda não pode se aposentar. A idade média para se aponsentar é de 40 anos.");
                Console.WriteLine($@"Ainda faltam {40 - age} anos para você se aposentar.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($@"Você tem {age} anos. Você já pode se aposentar.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }

    public class midfield : player
    {
        public void retire()
        {
            if (age <= 35)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você ainda não pode se aposentar. A idade média para se aponsentar é de 35 anos.");
                Console.WriteLine($@"Ainda faltam {35 - age} anos para você se aposentar.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($@"Você tem {age} anos. Você já pode se aposentar.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }

    public class attack : player
    {
        public void retire(){
            if (age <= 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você ainda não pode se aposentar. A idade média para se aponsentar é de 30 anos.");
                Console.WriteLine($@"Ainda faltam {30 - age} anos para você se aposentar.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($@"Você tem {age} anos. Você já pode se aposentar.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}