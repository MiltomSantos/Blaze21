using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09Correcao21
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sorteador = new Random();
            int pontos = 0;
            Console.WriteLine("Bem vindo ao jogo 21");
            Console.WriteLine("Seu objetivo é chegar próximo de 21 pontos");

            while (true)
            {

                Console.WriteLine($"Você tem {pontos} pontos");
                Console.WriteLine("Deseja continuar? 1 para sim e 2 para não");
                string opcao = Console.ReadLine();

                if (opcao == "2")
                {
                    Console.WriteLine("Fim de Jogo");
                    break;
                }

                int numero = sorteador.Next(1, 11);

                Console.WriteLine($"VocÊ tirou o número {numero}");

                pontos += numero;

                if (pontos>21)
                {
                    Console.WriteLine($"Você perdeu o jogo com {pontos} pontos e está devendo a sua casa para a Blaze");
                    Console.ReadLine();
                    break;
                }
            }
            Console.WriteLine($"Sua pontuação final foi de {pontos}");

            Console.ReadKey();
        }
    }
}
