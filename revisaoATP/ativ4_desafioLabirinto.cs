using System;

namespace ativ4_desafioLabirinto
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase ="No meio do caminho tinha uma pedra.";
            string fraseSemVogais = "N m d cmnh tnh m pdr.";
            Console.WriteLine("Sua frase é:");
            Console.ReadKey();
            Console.WriteLine(frase);
            Console.ReadKey();
            Console.WriteLine("Agora, um desafio!!!!");
            Console.ReadKey();
            Console.WriteLine("Digite a frase sem nenhuma vogal. Não esqueça das letras maiúsculas e do ponto final!");

            string entrada = Console.ReadLine();
            bool vogais = false;
            foreach (char c in entrada)
            {
                if ("aeiouAEIOU".Contains(c))
                {
                    vogais = true;
                    break;
                }
            }

            if (String.Equals(fraseSemVogais, entrada) && vogais == false)
            {
                Console.WriteLine("Você ganhou o desafio!!!!");
            }
            else
            {
                Console.WriteLine("Você perdeu.");
            }

        }
    }
}
