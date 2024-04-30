namespace calculaFrete
{
    internal class Program
    {

        static double calculaValor(double distancia, double valorKm, double valorDuzen, double valorMil)
        {
            double percKm = valorKm;
            double percDuzen = valorDuzen;
            double percMil = valorMil;

            double valor = distancia * percKm;

            if (distancia >= 200)
            {
                valor += distancia / 200 * percDuzen;
            }

            if (distancia >= 1000)
            {
                valor += distancia / 1000 * percMil;
            }
            return valor;
        }

        static double calculaPeso(double valorAtual, double peso, double valorCincoKg, double valorVinteCincoKg)
        {
            double valor = valorAtual;

            if (peso >= 5 && peso < 25)
            {
                Console.WriteLine("teste");
                valor = valorAtual * valorCincoKg;
            }

            if (peso >= 25 && peso < 75)
            {
                valor = valorAtual * valorVinteCincoKg;
            }

            return valor;
        }

        static double calculaFrete(
            double distancia, double valorKm, double valorDuzentosKm, double valorMilKm,
            double peso, double valorCincoKg, double valorVinteCincoKg )
        {
            double valorFrete = calculaValor(distancia, valorKm, valorDuzentosKm, valorMilKm);
            double valor = calculaPeso(valorFrete, peso, valorCincoKg, valorVinteCincoKg);

            return valor;
        }

        static void Main(string[] args)
        {

            double valorKm = 0.1, valorDuzentosKm = 1, valorMilKm = 10;

            double multiCincoKg = 5,  multiVinteCincoKg = 3;

            double distancia, peso;

            Console.WriteLine("Qual e a distancia do frete? ");
            distancia =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual e o peso da encomenda? ");
            peso = Convert.ToDouble(Console.ReadLine());

            double valorFinal = calculaFrete(distancia, valorKm, valorDuzentosKm, valorMilKm, peso, multiCincoKg, multiVinteCincoKg);
            
            
            Console.WriteLine("Valor final do frete: " + valorFinal);
        }
    }
}
