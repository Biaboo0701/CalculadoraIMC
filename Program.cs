using System;

namespace CalculatorIMC
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Clear();

            Console.WriteLine("Peso em KG:");
            float peso = float.Parse(Console.ReadLine());
    
            Console.WriteLine("Altura em Metro:");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = peso / (altura * altura);
            // Console.WriteLine($"O resultado do IMC é {resultado}");
            Console.WriteLine("O resultado do IMC é " + resultado.ToString("F2")); //Limitando a 2 decimais

            //Comparações de IMC --- Pedir sugestão para esse comentário
            if(resultado <= 18.49)
                Console.WriteLine("Você está abaixo do peso. Cuidado!!!");

            if(resultado >= 18.5 && resultado < 24.9)
                Console.WriteLine("Você está com peso normal. Parabéns!!!");
            
            if(resultado >= 25)
                Console.WriteLine("Você está acima do peso. Cuidado!!!");
        }
    }    
}