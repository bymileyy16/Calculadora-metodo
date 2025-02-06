using Calculadora;
using Layout;

repetir_valor1:
Console.Write("Informe o primeiro valor: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal valor1))
{
    Console.WriteLine("valor invalido!");
    goto repetir_valor1;
}

repetir_valor2:
Console.Write("Informe o segundo valor: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal valor2))
{
    Console.WriteLine("valor invalido!");
    goto repetir_valor2;
}

Operacoes.RealizarAdicao(valor1, valor2); 
{
    Formatacao.Cor($"A soma dos valores é: {valor1+ valor2}", ConsoleColor.DarkMagenta);
}
