using Calculadora;
using Layout;

// repetir:
// Console.Write("informar o primeiro valor: ");
// if(!decimal.TryParse(Console.ReadLine(), out decimal valor1))
// {
//     Console.WriteLine("Valor inválido!");
//     goto repetir;
// }


// repetir_valor2:
// Console.Write("informar o segundo valor: ");
// if(!decimal.TryParse(Console.ReadLine(), out decimal valor2))
// {
//     Console.WriteLine("Valor inválido!");
//     goto repetir_valor2;
// }

Operacoes.RealizarAdicao(
    Operacoes.ObterValor(),
    Operacoes.ObterValor()
);