using System;

namespace Forca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = {"CANETA", "CAVALO", "BANANA", "SOFA", "MARCELO", "JABUTICABA", "PARALELEPIPEDO"};
            string palavra = palavras[(new Random()).Next(palavras.Length - 1)];

            char[] palavraDividida = palavra.ToCharArray();
            char[] palavraAdivinhada = new char[palavraDividida.Length];
            bool descobriuOuDesistiu = false;
            int numeroTentativas = 6;
            int pontuacao = 0;

            while(!descobriuOuDesistiu && numeroTentativas > 0)
            {
                Console.WriteLine("######################################\n");
                string palavraExibir = "";
                foreach(char iChar in palavraAdivinhada)
                {
                    int asciiNumber = (int) iChar;
                    if(asciiNumber == 0)
                    {
                        palavraExibir = palavraExibir + "_ ";
                    } else
                    {
                        palavraExibir = palavraExibir + (iChar + " ");
                    }
                } //foreach

                desenharBoneco(numeroTentativas);
                Console.WriteLine("Palavra: " + palavraExibir);
                Console.WriteLine("Você ainda tem " + numeroTentativas + " tentativas");
                Console.WriteLine("Escolha uma letra ou aperte 0 para desistir: ");
                string letraUsuario = Console.ReadLine();

                if(letraUsuario.Equals("0"))
                {
                    Console.WriteLine("hahahaha burro");
                    descobriuOuDesistiu = true;
                }

                letraUsuario = letraUsuario.ToUpper();
                char[] dummyArray = new char[palavraAdivinhada.Length];
                if(LetraExisteNoArray(palavraAdivinhada, letraUsuario[0], ref dummyArray))
                {
                    Console.WriteLine("Você já escolheu essa letra");
                } else
                {
                    Console.WriteLine("Você escolheu a letra " + letraUsuario[0]);
                    
                    if(LetraExisteNoArray(palavraDividida, letraUsuario[0], ref palavraAdivinhada))
                    {
                        pontuacao = pontuacao + 5;
                        Console.WriteLine("+5 pontos");
                    } else
                    {
                        numeroTentativas = numeroTentativas - 1;
                        pontuacao = pontuacao - 1;
                        Console.WriteLine("-1 ponto");
                    }

                    string palavraJuntada = new string(palavraAdivinhada);
                    if (palavraJuntada.Equals(palavra))
                    {
                        Console.WriteLine("Parabéns você acertou!!!! Sua Pontuação é: " + pontuacao);
                        descobriuOuDesistiu = true;
                    }
                }
            } //while

            if(numeroTentativas == 0)
            {
                desenharBoneco(numeroTentativas);
                Console.WriteLine("Seu número de tentativas se esgotou");
            }
        }

        static bool LetraExisteNoArray(char[] array, char encontrar, ref char[] arrayToComplete)
        {
            bool encontrou = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (encontrar.Equals(array[i]))
                {
                    if(arrayToComplete != null)
                    {
                        arrayToComplete[i] = array[i];
                    }
                    if(!encontrou) encontrou = true;
                }
            }

            return encontrou;
        }

        static void desenharBoneco(int numeroTentativa)
        {
            string[] partes = {" \\", "/", "\\\n", "|", "/", " 0 \n"};
            if(numeroTentativa < 6)
            {
                for(int i = partes.Length - 1; i >= numeroTentativa; i--)
                {
                    Console.Write(partes[i]);
                }
            }
            Console.WriteLine();
        }
    }
}