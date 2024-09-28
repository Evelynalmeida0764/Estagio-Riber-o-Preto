using estagio_riberão_preto;
using System.Collections.Generic;

Console.WriteLine("Selecine uma opção:");
Console.WriteLine("1) Exercicio 1");
Console.WriteLine("2) Exercicio 2");
Console.WriteLine("0) Sair");
var resposta = Int32.Parse(Console.ReadLine());
switch (resposta)
{
    case 1:
        var fibonacci = new SequenciaFibonacci();
        Console.WriteLine("Qual o numero? ");
        var n = Int32.Parse(Console.ReadLine());
        Console.Clear();
        var sequencia = fibonacci.Calcular(n);
        foreach (var item in sequencia)
        {
            Console.WriteLine(item);
        }
        if (sequencia.Contains(n))
        {
            Console.WriteLine("O numero digitado esta na sequencia de Fibonacci");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("O numero digitado não esta na sequencia de Fibonacci");
            Console.ReadLine();
        }
        Console.ReadLine();
        break;

    case 2:
        var contadorDeLetra = new ContadorDeLetra();
        Console.WriteLine("Qual a frase? ");
        var frase = Console.ReadLine();
        Console.Clear();
        var quantidade = contadorDeLetra.Contar(frase);
        if (quantidade != 0)
        {
            Console.WriteLine("A letra 'A' aparece "+ quantidade + " vez(es) na frase digitada");
        }
        else
        {
            Console.WriteLine("Não existem letras 'A' na frase digitada");
        }
        break;

    case 0:
        Console.WriteLine("Voce escolheu sair.");
        Console.ReadLine();
        break;
}





