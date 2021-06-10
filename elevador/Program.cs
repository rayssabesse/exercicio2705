using System;

namespace elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            int start;
            int wd;
            int a = 1;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Qual o máximo de andares do prédio?");
            Console.ForegroundColor = ConsoleColor.White;
            general.floor = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Qual o máximo de pessoas no elevador social?");
            Console.ForegroundColor = ConsoleColor.White;
            social.people = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Qual o máximo de caixas no elevador de serviço?");
            Console.ForegroundColor = ConsoleColor.White;
            service.box = int.Parse(Console.ReadLine());

            general.initialize();

            while (a == 1)
            {


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Qual elevador deseja utilizar?");
                Console.WriteLine("1 = social / 2 = serviço");
                Console.ForegroundColor = ConsoleColor.White;
                start = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("1 = subir // 2 = descer // 3 = entrar // 4 = sair");
                Console.ForegroundColor = ConsoleColor.White;
                wd = int.Parse(Console.ReadLine());

                switch (start)
                {
                    case 1:
                        switch (wd)
                        {
                            case 1:
                                social.up();
                                general.initialize();
                                break;
                            case 2:
                                social.down();
                                general.initialize();
                                break;
                            case 3:
                                social.enterp();
                                general.initialize();
                                break;
                            case 4:
                                social.leavep();
                                general.initialize();
                                break;
                        }
                        break;
                    case 2:
                        switch (wd)
                        {
                            case 1:
                                service.up();
                                general.initialize();
                                break;
                            case 2:
                                service.down();
                                general.initialize();
                                break;
                            case 3:
                                service.enterb();
                                general.initialize();
                                break;
                            case 4:
                                service.leaveb();
                                general.initialize();
                                break;
                        }
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você deseja realizar outra função?");
                Console.WriteLine("1 = sim // 2 = não");
                Console.ForegroundColor = ConsoleColor.White;
                a = int.Parse(Console.ReadLine());
            }






        }
    }
}
