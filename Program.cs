// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static int CoinRead()
    {
        int soma, coin;
        soma = 0;

        do
        {
            Console.Write("Introduza um valor: ");
            coin = Convert.ToInt32(Console.ReadLine());

            if (coin != 10 && coin != 20 && coin != 50 && coin != 100 && coin != 200)
            {
                Console.WriteLine("ERROR!");
            }

            else 
            {
                soma += coin;
            }

        } while (soma < 40);
        return soma;
    }

    public static int CalcularTroco(int soma)
    {

        if (soma > 40)
            return soma - 40;
        
        return 0;
    }

    public static void Main(string[]args)
    {
        int soma, troco;

        soma = CoinRead();
        troco = CalcularTroco(soma);

        Console.WriteLine("Total: " + soma);
        Console.WriteLine("Troco: " + troco);

        int coin10, coin20, coin50, coin1, coin2;

        coin10 = troco / 10;
        Console.WriteLine("Moedas de 0.10€ : " + coin10);
        troco -= coin10* 10;

        coin20 = troco / 20;
        Console.WriteLine("Moedas de 0.20€ : " + coin20);
        troco -= coin20 * 20;

        coin50 = troco / 50;
        Console.WriteLine("Moedas de 0.50€ : " + coin50);
        troco -= coin50 * 50;

        coin1 = troco / 100;
        Console.WriteLine("Moedas de 1.00€ : " + coin1);
        troco -= coin1 * 100;

        coin2 = troco / 200;
        Console.WriteLine("Moedas de 2.00€ : " + coin2);
        troco -= coin2 * 200;
    }
}
