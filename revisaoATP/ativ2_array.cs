using System;

namespace ATP_revisao2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] entrada = new float[3] { 0, 0, 0 };

            Console.WriteLine("O jogador vai andar para frente ou para trás? (f, t)");
            char escolha;
            bool invalido = true;
            do {
                escolha = char.Parse(Console.ReadLine());
                if (escolha == 'f' || escolha == 'F')
                {
                    entrada[1] = 1;
                    invalido = false;
                } else if (escolha == 't' || escolha == 'T')
                {
                    entrada[1] = -1;
                    invalido = false;
                } else
                {
                    Console.WriteLine("Valor errado. Por favor digite novamente.");
                    invalido = true;
                }
            } while (invalido);

            Console.WriteLine("Quantas casas o jogador deve andar? (valor positivo, sempre)");
            float casas; 
            do
            {
                casas = float.Parse(Console.ReadLine());
                if(casas < 0)
                {
                    Console.WriteLine("Só valores positivos! Por favor, digite novamente.");
                }

            } while (casas < 0);
            entrada[2] = casas;


            // posição, codigo de direção de movimento, velocidade
            //cod de movimento: +1 se o jogador estiver de movendo pra frente, -1 se o jogador estiver se movendo para trás
            Movimento(entrada);

            entrada = Movimento(entrada);

            Console.WriteLine("Vetor final:");

            Console.WriteLine("Posição: " + entrada[0]);
            Console.WriteLine("Olhando para: " + entrada[1]);
            Console.WriteLine("Velocidade atual: " + entrada[2]);

        }

        static float[] Movimento(float[] entrada)
        {

            //somar ou subtrair de acordo com a direção (vet[1])
            if(entrada[1] > 0)//somar
            {
                entrada[0] = entrada[0] + entrada[2];
            }
            else //subtrair
            {
                entrada[0] = entrada[0] - entrada[2];
            }

            entrada[2] = 0;
            return entrada;
        }

    }
}
