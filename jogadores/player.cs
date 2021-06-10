using System;

namespace jogadores
{
    public class player
    {
        public string name;
        public int yob;
        public string country;
        public double height;
        public double weight;
        public int age;

        public void data() {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Qual o nome do jogador?");
            Console.ForegroundColor = ConsoleColor.White;
            name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Qual o ano de nascimento do jogador?");
            Console.ForegroundColor = ConsoleColor.White;
            yob = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Qual a nacionalidade do jogador?");
            Console.ForegroundColor = ConsoleColor.White;
            country = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Qual a altura do jogador? (cm)");
            Console.ForegroundColor = ConsoleColor.White;
            height = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Qual o peso do jogador? (kg)");
            Console.ForegroundColor = ConsoleColor.White;
            weight = double.Parse(Console.ReadLine());

            int year = DateTime.Now.Year;
            age = year - yob;
        }

        public void sdata(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($@"
            --------------------------------------------
               Nome do Jogador: {name}                
            --------------------------------------------
               Data de nascimento do Jogador: {yob}   
            --------------------------------------------
               Nacionalidade do Jogador: {country}    
            --------------------------------------------
               Altura do Jogador: {height}cm            
            --------------------------------------------
               Peso do Jogador: {weight}kg              
            --------------------------------------------
               Idade do Jogador: {age}                
            --------------------------------------------
            ");
        }
    }
}