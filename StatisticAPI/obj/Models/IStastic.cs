namespace StasticAPI.Models
{
    public interface IStastic
    {
          double media(double[] valores);
          double maximo(double[] valores);
          double minimo(double[] valores);

          double mediana(double[] valores);

        double moda(double[] valores);
    }
}