using StatisticAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace StatisticAPI.Controllers
{
    [ApiController]
    [Route("[controller")]

    public class StatisticController  : ControllerBase
    {
        [HttpGet]
        [Route("Mediana")]
        
        public ActionResult<double> Mediana(string v)
        {
            
            Calculos estatistica = new Calculos();

            string[] valorestring = v.Split(",");
            double[] valores = new double[valorestring.Length];

           for (var i = 0; i < valores.Length; i++)
           {
              valores[i]=double.Parse(valorestring[i]);            
           }
            
             double valor = estatistica.Calmediana(valores);
            
            return  valor;
        }

         [HttpGet]
        [Route("Media")]
        
        public ActionResult<double> Media(string v)
        {
            
            Calculos estatistica = new Calculos();

            string[] valorestring = v.Split(",");
            double[] valores = new double[valorestring.Length];

           for (var i = 0; i < valores.Length; i++)
           {
              valores[i]=double.Parse(valorestring[i]);            
           }
            
             double valor = estatistica.Calmedia(valores);
            
            return  valor;
        }

         [HttpGet]
        [Route("Desvio")]
        
        public ActionResult<double> Desvio(string v)
        {
            
            Calculos estatistica = new Calculos();

            string[] valorestring = v.Split(",");
            double[] valores = new double[valorestring.Length];

           for (var i = 0; i < valores.Length; i++)
           {
              valores[i]=double.Parse(valorestring[i]);            
           }
            
             double valor = estatistica.Caldesvio(valores);
            
            return  valor;
        }

         [HttpGet]
        [Route("Moda")]
        
        public ActionResult<double> Moda(string v)
        {
            
            Calculos estatistica = new Calculos();

            string[] valorestring = v.Split(",");
            double[] valores = new double[valorestring.Length];

           for (var i = 0; i < valores.Length; i++)
           {
              valores[i]=double.Parse(valorestring[i]);            
           }
            
             double valor = estatistica.Calmoda(valores);
            
            return  valor;
        }

         [HttpGet]
        [Route("MaioreMenor")]
        
        public ActionResult<double> MaioreMenor(string v)
        {
            
            Calculos estatistica = new Calculos();

            string[] valorestring = v.Split(",");
            double[] valores = new double[valorestring.Length];

           for (var i = 0; i < valores.Length; i++)
           {
              valores[i]=double.Parse(valorestring[i]);            
           }
            
             double valor = estatistica.Calmaioremenor(valores);
            
            return  valor;
        }
    }
}