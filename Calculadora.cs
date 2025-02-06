namespace Calculadora
{
    class Operacoes
    {

        public static decimal ObterValor()
        {
        repetir:
            Console.Write("informar o valor: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                Console.WriteLine("Valor inválido!");
                goto repetir;
            }
            else
            {
                return valor;
            }
        }

        public static void RealizarAdicao( decimal var1, decimal var2)
        {
            Console.WriteLine($"A Soma dos valores {var1} e {var2} é {var1 + var2}");
        }

    }
}