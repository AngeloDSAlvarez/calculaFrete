namespace calculaFrete
{
    public class CalculadorDeFrete
    {

        private double calculaValor(double distancia, double valorKm, double valorDuzen, double valorMil)
        {
            

            double valor = distancia * valorKm;

            if (distancia >= 200)
            {
                valor += ((int)(distancia / 200)) * valorDuzen;
            }

            if (distancia >= 1000)
            {
                valor += ((int)(distancia / 1000)) * valorMil;
            }
            return valor;
        }

        private double calculaPeso(double valorAtual, double peso, double valorCincoKg, double valorVinteCincoKg)
        {
            double valor = valorAtual;

            if (peso >= 5 && peso <= 25)
            {
                valor = valorAtual * valorCincoKg;
            }

            if (peso > 25 && peso <= 75)
            {
                valor = valorAtual * valorVinteCincoKg;
            }

            return valor;
        }

        public double CalcularFrete(
            double distancia, double peso)
        {
            double valorKm = 0.1, valorDuzentosKm = 1, valorMilKm = 10;

            double valorCincoKg = 5, valorVinteCincoKg = 3;

            double valorFrete = calculaValor(distancia, valorKm, valorDuzentosKm, valorMilKm);
            double valor = calculaPeso(valorFrete, peso, valorCincoKg, valorVinteCincoKg);

            return valor;
        }

        
    }
}
