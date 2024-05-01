﻿namespace calculaFrete
{
    internal class Program
    {

        static double calculaValor(double distancia, double valorKm, double valorDuzen, double valorMil)
        {
            

            double valor = distancia * valorKm;

            if (distancia >= 200)
            {
                valor += (distancia / 200) * valorDuzen;
            }

            if (distancia >= 1000)
            {
                valor += ((int)(distancia / 1000)) * valorMil;
            }
            return valor;
        }

        static double calculaPeso(double valorAtual, double peso, double valorCincoKg, double valorVinteCincoKg)
        {
            double valor = valorAtual;

            if (peso >= 5 && peso < 25)
            {
                valor = valorAtual * valorCincoKg;
            }

            if (peso >= 25 && peso < 75)
            {
                valor = valorAtual * valorVinteCincoKg;
            }

            return valor;
        }

        static double calculaFrete(
            double distancia, double peso)
        {
            double valorKm = 0.1, valorDuzentosKm = 1, valorMilKm = 10;

            double valorCincoKg = 5, valorVinteCincoKg = 3;

            double valorFrete = calculaValor(distancia, valorKm, valorDuzentosKm, valorMilKm);
            double valor = calculaPeso(valorFrete, peso, valorCincoKg, valorVinteCincoKg);

            return valor;
        }

        static void Main(string[] args)
        {

            

            double distancia, peso;

            Console.WriteLine("Qual e a distancia do frete? ");
            distancia =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual e o peso da encomenda? ");
            peso = Convert.ToDouble(Console.ReadLine());

            double valorFinal = calculaFrete(distancia, peso);
            
            
            Console.WriteLine("Valor final do frete: " + valorFinal);
        }
    }
}
