using System;

namespace ATP_revisão1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma sequência. Para terminar, digite -1.");
            Console.WriteLine("Digite o primeiro valor:");
            int entrada = int.Parse(Console.ReadLine());
            int prox;
            int sequencia = 1;
            int maiorSequencia = 0;

            while (entrada != -1)
            {
                Console.WriteLine("Digite o próximo valor:");
                prox = int.Parse(Console.ReadLine());

                if(prox > entrada)
                {
                    sequencia++;
                }
                else
                {
                    if(sequencia > maiorSequencia)
                    {
                        maiorSequencia = sequencia;
                    }
                    sequencia = 1;
                }

                entrada = prox;

            }

            Console.WriteLine("A maior sequencia de numeros crescentes digitada foi de " + maiorSequencia + '.');
        }
    }
}
