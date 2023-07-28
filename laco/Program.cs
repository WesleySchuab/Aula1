using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

        /*double investimento = 1000;

         int mes = 1;
         while (mes <= 12)
         {
             investimento = investimento + investimento * 0.005;
             Console.WriteLine("No mês " + mes + " você tem R$" + investimento);

             mes = mes + 1;
         }

         Console.WriteLine( "Usando laço For");
         for (int mes = 1; mes <= 12; mes++)
         {
             investimento *= 1.005;
             Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
         }   
        */
        Console.WriteLine("Executando o projeto 12 - Investindo a Longo prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }

            fatorRendimento += 0.001;
        }

        Console.WriteLine("Depois de 5 anos você terá R$ " + investimento);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}