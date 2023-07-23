using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criando Variaveis");
        int idade;
        idade = 27;

        double salario;
        salario = 3000.10;

        int salarioInteiro;
        salarioInteiro = (int)salario;

        Console.WriteLine(" Valores maiores que 32b");
        long x;
        x = 2000000000000000000;

        Console.WriteLine("Para trabalhar com números menores, temos a variável do tipo short");
        short y;
        y = 15000;

        Console.WriteLine("float que, assim como o double, trabalha com números com vírgula, porém com uma precisão muito maior");
        float altura;
        altura = 1.628556f;

        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");
        char letra = 'a';
        letra = (char)65;
        Console.WriteLine(letra);

        Console.WriteLine("Tecle enter para fechar");
        Console.ReadLine();
    }

}