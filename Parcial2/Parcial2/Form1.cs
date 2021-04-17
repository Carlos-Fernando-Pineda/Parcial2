using Parcial2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    
    public partial class Form1 : Form
    {
        public string[,] ArregloDosDimensiones;
        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClasificar_Click(object sender, EventArgs e)
        {
            listBoxResultados.Items.Clear();
            string seccion = textBoxSeccion.Text;
            string[,] resultado;
            int acumulador = 0;

            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];

            foreach(string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                ArregloDosDimensiones[acumulador, 0] = datos[0];
                ArregloDosDimensiones[acumulador, 1] = datos[1];
                ArregloDosDimensiones[acumulador, 2] = datos[2];
                ArregloDosDimensiones[acumulador, 3] = datos[3];
                ArregloDosDimensiones[acumulador, 4] = datos[4];
                ArregloDosDimensiones[acumulador, 5] = datos[5];
                acumulador++;
            }
            ClsPromedios Clasificar = new ClsPromedios();
            resultado = Clasificar.Clasificar_Alumnos(ArregloDosDimensiones, seccion);
            for (int i=0; i<resultado.GetLength(0); i++)
            {
                listBoxResultados.Items.Add($"{resultado[i, 0]}-{resultado[i, 1]}");
            }
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Title = "Selecciona tu Archivo Plano";
            //ofd.InitialDirectory = @"C:\Users\carlo\OneDrive\Documentos\Universidad\Tercer Semestre\Programación I";
            //ofd.Filter = "Archivo plano (*.csv)|*.csv";

            //if (ofd.ShowDialog() = DialogResult.OK)
            {
                var archivo = @"C:\Users\carlo\OneDrive\Documentos\Universidad\Tercer Semestre\Programación I\archivoPlano.csv";
                String resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);// retorna arreglo
                textBoxContenido.Text = resultado;
            }
        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            textBoxParcial.Text = "3";
            textBoxSeccion.Text = "A";
            int contador = 0;
            int parcial = Convert.ToInt32(textBoxParcial.Text) + 1;
            string seccion = textBoxSeccion.Text;
            int promedio, acumulador;
            acumulador = 0;

            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int[] ordenParcial = new int[ArregloNotas.Length -1];
            foreach(string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                if (contador != 0)
                {
                    listBoxResultado.Items.Add(datos[1]);
                    acumulador = acumulador + Convert.ToInt32(datos[4]);
                    ordenParcial[contador-1] = Convert.ToInt32(datos[4]);
                }
                ArregloDosDimensiones[contador, 0] = datos[0];
                ArregloDosDimensiones[contador, 1] = datos[1];
                ArregloDosDimensiones[contador, 2] = datos[2];
                ArregloDosDimensiones[contador, 3] = datos[3];
                ArregloDosDimensiones[contador, 4] = datos[4];
                ArregloDosDimensiones[contador, 5] = datos[5];
                contador++;
            }
            ClsArreglos fncArreglos = new ClsArreglos(ordenParcial);
            ordenParcial = fncArreglos.MetodoBurbuja();
            int min = ordenParcial[0];
            int max = ordenParcial[ordenParcial.Length-1];
            promedio = acumulador / ArregloNotas.Length - 1;
            ClsPromedios Promedio = new ClsPromedios();
            int promedioMatriz = Promedio.promedios_por_parcial(ArregloDosDimensiones, parcial);
            int PromedioSeccion = Promedio.promedios_por_seccion(ArregloDosDimensiones, parcial, seccion);
            int PromedioGeneral = Promedio.promedios_general_seccion(ArregloDosDimensiones, parcial, seccion);
            MessageBox.Show($"Promedio es {promedio}\nmin={min}\nmax={max}\nPromedio Parcial={promedioMatriz}\nPromedio Seccion={PromedioSeccion}\nPromedio General de Seccion={PromedioGeneral}");
        }

        private void buttonSumatoria_Click(object sender, EventArgs e)
        {
            listBoxResultados.Items.Clear();
            string[,] resultado;
            int acumulador = 0;

            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            foreach(string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                ArregloDosDimensiones[acumulador, 0] = datos[0];
                ArregloDosDimensiones[acumulador, 1] = datos[1];
                ArregloDosDimensiones[acumulador, 2] = datos[2];
                ArregloDosDimensiones[acumulador, 3] = datos[3];
                ArregloDosDimensiones[acumulador, 4] = datos[4];
                ArregloDosDimensiones[acumulador, 5] = datos[5];
                acumulador++;
            }
            ClsPromedios Sumatoria = new ClsPromedios();
            resultado = Sumatoria.sumatoria_general_por_alumno(ArregloDosDimensiones);
            for (int i = 0; i< resultado.GetLength(0); i++)
            {
                listBoxResultados.Items.Add($"{resultado[i, 0]}-{resultado[i, 1]}");
            }
        }
    }
}
