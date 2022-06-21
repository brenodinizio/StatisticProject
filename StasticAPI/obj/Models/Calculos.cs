using System.Runtime.dll;

namespace StasticAPI.obj.Models
{
    public class Calculos : IStastic 
    {
       public double Calmaioremenor(double[] valores)
        {
            int numElementos = valores.Length;
            int indiceMaior;
            int indiceMenor;

                for( int i = 0; i < numElementos; i++ )
            {             
                if( i == 0 )
                {
                    menor = valores[0];
                    maior = valores[0];
                }
            
                if( valores[i] < menor )
                {
            
                    menor = valores[i];
                    indiceMenor = i;
            
                }
                else if( valores[i] > maior )
                {
                    maior = valores[i];
                    indiceMaior = i;
                }
        }
        }

        public double Calmedia(double[] valores)
        {
            double soma = 0;
            foreach (var item in valores)
            {
                soma += item;
                
            }
            double media= soma / valores.Length;  

            return media;         
        }

        public double Calmediana(double[] valores)
        {
            double troca;
           for (var i = 0; i < valores.Length; i++)
           {
              for (var x = i+1; x < valores.Length; x++)
              {
                    if (valores[i]>valores[x]) {
                        troca = valores[i];
                        valores[i]=valores[x];
                        valores[x]=troca;
                    }                
              }
            
           }
            int metade = valores.Length/2;
            if (valores.Length %  2 == 0)
           {            
             return (valores[metade -1]+valores[metade ])/2;
           }
            else 
           {
            
             return valores[metade];
           }

        }

        public double Calmoda(double[] valores)
        {
                for (int i = 0; i < valores.Length; i++)
                {
                    for (int x = i+1; x < valores.Length; x++)
                    {
                       if (valores[i] > valores[x])
                       {
                        aux = valores[i];
                        valores[i] = valores[x];
                        valores[x] = aux;
                       }
                    }
                }

        int tamanho = valores.Length; 
        int conta = 0;  
        for(i=0;i<tamanho;i++)
        {
        for(j=i+1;j<tamanho;j++)
        {
        	
			if(v[i]==v[j])
            {
				cont[i]++;
					if(cont[i]>conta)
                    {
						conta=cont[i];
						moda=i;
					}
			}
        	
        }
        cont[i]=0;
    }

    return 0;
}
      }

      public double Caldesvio()
      {
        Calculos media = new Media();
        valor = media.Calmedia(v);
        int tamanho = valores.Length; 
        double variancia = valor/ tamanho;

        double desvio = Math.Sqrt(variancia);

      }
   }
