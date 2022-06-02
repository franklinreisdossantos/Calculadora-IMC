using System;
using System.Collections.Generic;
using System.Text;


namespace CalculadoraDeImc
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int i = 1;
            do
            {


                double altura, imc;
                int peso;
                string nome, situacao = "Você está magro(a)";

                Console.WriteLine("Qual o seu nome");
                nome = Console.ReadLine();

                Console.WriteLine("Qual o seu peso");
                peso = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual sua altura");
                altura = Convert.ToDouble(Console.ReadLine());

                imc = peso / (altura * altura);

                if (imc < 18.5)
                {
                    situacao = " abaixo do peso";
                    Console.WriteLine(situacao + imc);
                }
                else if (imc >= 18.6 && imc < 25.0)
                {
                    situacao = "Peso ideal";

                }
                else if (imc >= 25 && imc < 30.0)
                {
                    situacao = "Levemente acima do peso";

                }
                else if (imc >= 30.0 && imc < 35.0)
                {
                    situacao = "Obesidade grau 1";
                }
                else if (imc >= 35 && imc < 40.0)
                {
                    situacao = "Obesidade grau 2";
                }
                else
                {
                    situacao = "Obesidade Morbidade";
                }
                Console.WriteLine($"Olá" + nome + $"sua situacão é " + situacao);

                Console.WriteLine("Fazer um novo calculo digite se sim/1 ou 2 se não");
                i = int.Parse(Console.ReadLine());



                
            }
            while (i == 1);




        }
    }
}

           
          



        
    

