using System;

namespace Desafio_02
{
    class Program
    {
        static void Main(string[] args)
        {

            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - STARTS...");

            string nome1 = "Ubuntu1 Silva";
            int idade1   = 33;
            double peso1 = 88.50;
            decimal altura1 = 1.65M;
            bool EhDev1  = true;

            string nome2 = "Ubuntu2 Santos";
            int idade2 = 26;
            double peso2 = 84.50;
            decimal altura2 = 2.10M;
            bool EhDev2 = true;

            string nome3 = "Ubuntu3 Silva";
            int idade3 = 85;
            double peso3 = 66.50;
            decimal altura3 = 1.40M;
            bool EhDev3 = false;


            //T1 - Somar a idade de todos Ubuntus
            int soma_das_idades = idade1 + idade2 + idade3;
            Console.WriteLine("A soma das idade é " + soma_das_idades);
            //T2 - Agrupar os nomes de todos Ubuntus
            Console.WriteLine("\nO nome agrupado de todos os Ubuntus : \n"+ nome1+ ", " + nome2+ ", " + nome3+ ". ");
            //T3 - Calcular Média dos IMC de todos Ubuntus
            double IMC1 = (peso1 / (double)(altura1*altura1));
            double IMC2 = (peso2 / (double)(altura2 * altura2));
            double IMC3 = (peso3 / (double)(altura3 * altura3));
            double media_imc = (IMC1 + IMC2 + IMC3) / 3;
            Console.WriteLine("\nA média dos IMC´s é:\n" + media_imc.ToString("F"));
            //T4 - Contar quantos Ubuntus sao Devs
            var array= new bool[3];
            array[0] = EhDev1;
            array[1] = EhDev2;
            array[2] = EhDev3;
            var sao_dev = 0;
            for(var i = 0; i < 3; i++)
            {
                if(array[i] == true)
                {
                    ++sao_dev;
                }
            }
            Console.WriteLine("\nSão Dev somente : " + sao_dev);
            //T5 - Exibir somente Ubuntu com nome Silva
           var arrayNome = new string[3];
            arrayNome[0] = nome1;
            arrayNome[1] = nome2;
            arrayNome[2] = nome3;

            
            for (var i = 0; i < 3; i++)
           {
                if (arrayNome[i].Contains("Silva"))
                {
                    Console.WriteLine("\nEste Ubunto tem o nome silva " + arrayNome[i]);
                }
            }


            //Imprime na tela
            Console.WriteLine("UBUNTU 002 - ENDS...");

            //PAUSA NA TELA (GAMBIARRA PERMITIDA PRA INICIANTES)
            Console.Read();
        }


    }
}
