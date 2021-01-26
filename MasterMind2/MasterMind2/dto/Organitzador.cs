using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public class Organitzador
    {
        //dificultades - 0:sin inicializar, 1:principiante, 2:medio, 3:avanzado
        private int casellesTotals = 4;

        public int _CasellesTotals { get { return casellesTotals; } set { casellesTotals = value; } }


        public static int Iniciar(bool principiante, bool medio, bool avanzado)
        {

            int dificultat = 0;

            if (principiante)
            {
                dificultat = 4;
            }
            else if (medio)
            {
                dificultat = 5;
            }
            else if (avanzado)
            {
                dificultat = 6;
            }
            else
            {
                MessageBox.Show("Has d'escollir una dificultat per poder iniciar...");
                return dificultat;
            }
            return dificultat;
        }

        public static void Constructor(int casellesTotals, Master_Mind MM, int dificultat)
        {
            // Método contructor que llama a los diferentes metodos que ejecuta el programa para funcionar

            //ATRIBUTOS
            // array de colores disponibles
            Color[] colors = new Color[] { Color.Red, Color.Yellow, Color.Green, Color.Blue, Color.Orange, Color.Pink };
            
            // generamos un array de colores disponibles
            PictureBox[] colorsDisponibles = Methods.printar_colors_disponibles(dificultat, colors, MM);
            // printamos los colores disponibles
            for (int i = 0; i < colorsDisponibles.Length; i++) // recorremos el array de objetos
            {
                MM.panel4.Controls.Add(colorsDisponibles[i]);
            }

            // generamos un array de bolas secretas
            PictureBox[] bolesSecretes = Methods.crear_solucion(dificultat, colors, MM);
            // printamos los colores secretos
            for (int i = 0; i < 4; i++) // recorremos el array de objetos
            {
                MM.panel3.Controls.Add(bolesSecretes[i]);              
            }

            // generamos un array de bolas vacias
            Methods.crear_linea_bola(4, colors,MM, 0, bolesSecretes);
        }


        public static void enviar_Click(System.Windows.Forms.Button sender, EventArgs e, PictureBox[] bolasNuevas, int numero, Color[] colors, Master_Mind MM, PictureBox[] solucio)
        {
            if (bolasNuevas[0].BackColor!=Color.White&& bolasNuevas[1].BackColor != Color.White && bolasNuevas[2].BackColor != Color.White && bolasNuevas[3].BackColor != Color.White)
            {
                Methods.crear_linea_bola(4, colors, MM, numero + 1, solucio);
                sender.Visible= false;
                Methods.CheckResults(bolasNuevas, solucio, MM, numero);
            }
            
        }

        public static void copiarColor_Click(object sender, EventArgs e, PictureBox pinzell, Master_Mind MM)
        {
            MM.pictureBox1.BackColor = pinzell.BackColor;
        }
        public static void pegarColor_Click(object sender, EventArgs e, PictureBox pinzell, Master_Mind MM)
        {
            pinzell.BackColor = MM.pictureBox1.BackColor;
        }

        public static void bola_Click(object sender, EventArgs e)
        {
            PictureBox box = sender as PictureBox;

            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = box.BackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                box.BackColor = MyDialog.Color;
            }
        }





    }
}