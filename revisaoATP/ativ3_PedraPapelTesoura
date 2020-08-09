using System;

namespace ATP_revisao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao pedra, papel ou tesoura!!");
            Console.ReadKey();

            string player1;
            string player2; //computador

            Random rnd = new Random();
            int rand = rnd.Next(1, 3);
            switch (rand)
            {
                case 1:
                    player2 = "pedra";
                    break;
                case 2:
                    player2 = "papel";
                    break;
                default:
                    player2 = "tesoura";
                    break;
            }

            Console.WriteLine("Player 1: pedra, papel ou tesoura? (escreva em minúsculo)" );
            player1 = Console.ReadLine();


            Console.WriteLine("Player 1 escolheu: " + player1);
            Console.WriteLine("Player 2 escolheu: " + player2);

            switch (player1)
            {
                    case "pedra": 
                            switch(player2)
                        {
                        case "pedra": Console.WriteLine("Empate!");
                                break;

                        case "papel":
                            Console.WriteLine("Vitória do Player 2!");
                            break;

                        case "tesoura":
                            Console.WriteLine("Vitória do Player 1!");
                            break;
                    }
                    break;

                case "papel":
                    switch (player2)
                    {
                        case "papel":
                            Console.WriteLine("Empate!");
                            break;

                        case "tesoura":
                            Console.WriteLine("Vitória do Player 2!");
                            break;

                        case "pedra":
                            Console.WriteLine("Vitória do Player 1!");
                            break;
                    }
                    break;

                case "tesoura":
                    switch (player2)
                    {
                        case "tesoura":
                            Console.WriteLine("Empate!");
                            break;

                        case "pedra":
                            Console.WriteLine("Vitória do Player 2!");
                            break;

                        case "papel":
                            Console.WriteLine("Vitória do Player 1!");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Não escolheu nenhuma das 3 jogadas possíveis, perdeu de WO!!!");
                    break;

            }
        }
    }
}
