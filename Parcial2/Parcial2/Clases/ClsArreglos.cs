using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial2.Clases
{
    class ClsArreglos
    {
        private int[] ArregloTemporal;
        private string[] ArregloTemporalCadena;
        private int[] datos;
        private int i, j, datoTemporal;
        private int tamanoArreglo = 0;

        public int GetTamañoArreglo()
        {
            return datos.Length;
        }

        public ClsArreglos(int[] arreglo)
        {
            datos = arreglo;
            tamanoArreglo = datos.Length; // numero de datos
        }

        /// <summary>
        /// Burbuja
        /// intercambiar cada pareja consecutiva no ordenada
        /// </summary>
        /// <returns></returns>

        public int[] MetodoBurbuja()
        {
            ArregloTemporal = datos;
            for(i=0; i < tamanoArreglo - 1; i++)
            {
                for (j = i + 1; j < tamanoArreglo; j++)
                {
                    if (ArregloTemporal[i] > ArregloTemporal[j])
                    {
                        datoTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datoTemporal;
                    }
                }
            }
            return ArregloTemporal;
        }
        public string[] MetodoBurbujaCadena()
        {
            ArregloTemporal = datos;
            string datoTemporalCadena;
            for (i = 0; i < tamanoArreglo - 1; i++)
            {
                for (j = i + 1; j < tamanoArreglo; j++)
                {
                    if (ArregloTemporalCadena[i].CompareTo(ArregloTemporalCadena[j])>0)
                    {
                        datoTemporalCadena = ArregloTemporalCadena[i];
                        ArregloTemporalCadena[i] = ArregloTemporalCadena[j];
                        ArregloTemporalCadena[j] = datoTemporalCadena;
                    }
                }
            }
            return ArregloTemporalCadena;
            
        }
    }
}
