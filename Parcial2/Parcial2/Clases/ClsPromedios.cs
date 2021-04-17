using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial2.Clases
{
    class ClsPromedios : InterfacePromedios
    {
        public string[,] Clasificar_Alumnos(string[,] matriz, string seccion)
        {
            int contador = 0, tamano = 0;
            
            for(int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                if(matriz[fila, 5] == seccion)
                {
                    tamano++;
                }
            }
            string[,] Matriz_Alumnos = new string[tamano, 2];
            for(int fila =1; fila<matriz.GetLength(0); fila++)
            {
                if(matriz[fila,5]== seccion)
                {
                    Matriz_Alumnos[contador, 0] = matriz[fila, 1];
                    Matriz_Alumnos[contador, 1] = matriz[fila, 5];
                    contador++;
                }
            }
            return Matriz_Alumnos;
        }

        public int promedios_general_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            int acumulador = 0;
            int promedio = 0;
            int totalFilas = matriz.GetLength(0);

            for (int fila =1; fila<matriz.GetLength(0); fila++)
            {
                if (matriz[fila, 5] == seccion)
                {
                    promedio += Convert.ToInt32(matriz[fila, 2]);
                    promedio += Convert.ToInt32(matriz[fila, 3]);
                    promedio += Convert.ToInt32(matriz[fila, 4]);
                    acumulador++;
                }
            }
            promedio /= (acumulador * 3);
            return promedio;
        }

        public int promedios_por_parcial(string[,] matriz, int columna_parcial)
        {
            int acumulador = 0;
            int promedio;
            int totalFilas = matriz.GetLength(0);

            for (int fila = 1; fila < matriz.GetLength(0); fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna_parcial]);
            }
            promedio = acumulador / matriz.GetLength(0) - 1;
            return promedio;
        }

        public int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            int promedio = 0;
            int acumulador = 0;
            int totalFilas = matriz.GetLength(0);

            for (int fila = 1; fila<matriz.GetLength(0); fila++)
            {
                if (matriz[fila, 5] == seccion)
                {
                    promedio += Convert.ToInt32(matriz[fila, columna_parcial]);
                    acumulador++;
                }
            }
            promedio /= acumulador;
            return promedio;
        }

        public string[,] sumatoria_general_por_alumno(string[,] matriz)
        {
            int sumatoria_general = 0;
            string[,] sumatoria_alumnos = new string[matriz.GetLength(0) - 1, 2];

            for(int fila=1; fila<matriz.GetLength(0); fila++)
            {
                sumatoria_general = Convert.ToInt32(matriz[fila, 2]) + Convert.ToInt32(matriz[fila, 3]) + Convert.ToInt32(matriz[fila, 4]);
                sumatoria_alumnos[fila - 1, 0] = matriz[fila, 1];
                sumatoria_alumnos[fila - 1, 1] = Convert.ToString(sumatoria_general);
            }

            return sumatoria_alumnos;
        }
    }
}
