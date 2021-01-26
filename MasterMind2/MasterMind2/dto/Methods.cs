using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MasterMind
{
    class Methods
    {
        // ATRIBUTOS
        // inicializamos objeto form Master Mind
        Master_Mind masterMind = new Master_Mind();
        Organitzador organitzador = new Organitzador();
        // array de colores posibles
        Color[] colors = new Color[] { Color.Red, Color.Yellow, Color.Green, Color.Blue, Color.Orange, Color.Pink };
        // número máximo de casillas disponibles en cada juego, en este caso es constante 4

        
        // variables globales para las bolas
        const int bolaAmple = 26;
        const int bolaAltura = 26;
        const int bolaMarginTop = 12;
        const int bolaMarginLeft = 12;
        const int bolaMarginRight = 12;
        const int bolaMarginBottom = 12;

        public static PictureBox[] printar_colors_disponibles(int numeroColores, Color[] colors, Master_Mind MM)
        {
            // Crearem un vector de boles de colors disponibles
            PictureBox[] bolascolores = new PictureBox[numeroColores];
            // Per cada posició li asignem una bola de color
            for (int i = 0; i < bolascolores.Length; i++)
            {
                bolascolores[i] = crear_bola(colors[i],i, MM);
            }
            bolascolores[0].Click += (sender, EventArgs) => { Organitzador.copiarColor_Click(sender, EventArgs, bolascolores[0], MM); };
            bolascolores[1].Click += (sender, EventArgs) => { Organitzador.copiarColor_Click(sender, EventArgs, bolascolores[1], MM); };
            bolascolores[2].Click += (sender, EventArgs) => { Organitzador.copiarColor_Click(sender, EventArgs, bolascolores[2], MM); };
            bolascolores[3].Click += (sender, EventArgs) => { Organitzador.copiarColor_Click(sender, EventArgs, bolascolores[3], MM); };
            if (numeroColores==5)
            {
                bolascolores[4].Click += (sender, EventArgs) => { Organitzador.copiarColor_Click(sender, EventArgs, bolascolores[4], MM); };
            }
            if (numeroColores == 6)
            {
                bolascolores[5].Click += (sender, EventArgs) => { Organitzador.copiarColor_Click(sender, EventArgs, bolascolores[5], MM); };
            }
            

            return bolascolores;
        }

        public static PictureBox[] crear_solucion(int casillasTotales, Color[] colors, Master_Mind MM)
        {
            // Crearem un generador d'aleatoris
            Random r = new Random();

            // Crearem un vector de boles de colors com a solucions
            PictureBox[] bolassolucion = new PictureBox[casillasTotales];

            // Per cada posició li asignem una bola de color
            for (int i = 0; i < bolassolucion.Length; i++)
            {
                bolassolucion[i] = crear_bola(colors[r.Next(0, casillasTotales)],i, MM);
                //bolassolucion[i].Hide();
            }
            return bolassolucion;

        }

        public static void crear_linea_bola(int casillasTotales, Color[] colors, Master_Mind MM, int offset, PictureBox[] solucio)
        {
            // método para generar cuatro bolas vacias para que el jugador pueda seleccionar el color
            // y enviar el contenido a revisar

            
            PictureBox[] bolasVacias = new PictureBox[casillasTotales];

            for (int i = 0; i < casillasTotales; i++)
            {
                bolasVacias[i] = crear_bola(Color.White,i, MM);
                bolasVacias[i].Location = new Point(bolasVacias[i].Location.X-30, bolasVacias[i].Location.Y + (offset * 43));
            }
            bolasVacias[0].Click += (sender, EventArgs) => { Organitzador.pegarColor_Click(sender, EventArgs, bolasVacias[0], MM); };
            bolasVacias[1].Click += (sender, EventArgs) => { Organitzador.pegarColor_Click(sender, EventArgs, bolasVacias[1], MM); };
            bolasVacias[2].Click += (sender, EventArgs) => { Organitzador.pegarColor_Click(sender, EventArgs, bolasVacias[2], MM); };
            bolasVacias[3].Click += (sender, EventArgs) => { Organitzador.pegarColor_Click(sender, EventArgs, bolasVacias[3], MM); };
            for (int i = 0; i < casillasTotales; i++) // recorremos el array de objetos
            {
                MM.panel1.Controls.Add(bolasVacias[i]);
            }

            Button enviar = new Button();
            enviar.Text = "Enviar";
            enviar.Location = new System.Drawing.Point(212, 50);
            enviar.Location= new Point(enviar.Location.X,enviar.Location.Y+ (offset*43));
            MM.panel1.Controls.Add(enviar);
            enviar.Click += (sender, EventArgs) => { Organitzador.enviar_Click(enviar, EventArgs, bolasVacias, offset, colors, MM, solucio); };
        }

        public static PictureBox crear_bola(Color color, int repeticio, Master_Mind MM)
        {
            // método per crear una bola con el color pasado por parámetro

            PictureBox bola = new PictureBox();

            bola.Width = 26;
            bola.Height = 26;
            bola.BorderStyle = BorderStyle.FixedSingle;
            bola.Margin = new System.Windows.Forms.Padding(bolaMarginLeft, bolaMarginTop, bolaMarginRight, bolaMarginBottom);
            bola.BackColor = color;
            bola.Left = 300;
            bola.Location = new System.Drawing.Point(70 + (43 * repeticio), 50);
            bola.Name = "bola"+Convert.ToString(MM.contadorBoles);
            bola.TabIndex = 0;
            bola.TabStop = false;
            bola.Show();
            MM.contadorBoles++;


            return bola;
        }

        public static void CheckResults(PictureBox[] linea, PictureBox[] solucio, Master_Mind MM, int offset)
        {
            //Creo las variables de cantidad de negras y blancas, ademas de un array de bolas para dar de resultado
            int negras = 0;
            int blancas = 0;
            int guanyar = 0;
            int[] posicionsNegres = new int[4] { 0,0,0,0};
            PictureBox[] resultat = new PictureBox[solucio.Length];

            if (offset == 9)
            {
                MessageBox.Show("GAME OVER");
                Application.Exit();
            }
            for (int i = 0; i < linea.Length; i++)
            {
                if (linea[i].BackColor == solucio[i].BackColor)
                {
                    negras++;
                    posicionsNegres[i] = 1;
                }
                else
                {
                    for (int x = 0; x < linea.Length; x++)
                    {
                        if ((linea[x].BackColor == solucio[x].BackColor) && (posicionsNegres[x] == 0))
                        {
                            blancas++;
                        }
                    }
                }
            }
            
            for (int i = 0; i < linea.Length; i++)
            {
                if (negras > 0)
                {
                    resultat[i] = crear_bola(Color.Black, i, MM);
                    resultat[i].Location = new Point(resultat[i].Location.X - 30, resultat[i].Location.Y + (offset * 43));                
                    negras--;
                    guanyar++;
                }
                else if (blancas > 0)
                {
                    resultat[i] = crear_bola(Color.White, i, MM);
                    resultat[i].Location = new Point(resultat[i].Location.X - 30, resultat[i].Location.Y + (offset * 43));
                    blancas--;
                }
                else
                {
                    resultat[i] = crear_bola(Color.Gray, i, MM);
                    resultat[i].Location = new Point(resultat[i].Location.X - 30, resultat[i].Location.Y + (offset * 43));
                }
            }
            for (int i = 0; i < resultat.Length; i++) // recorremos el array de objetos
            {

                MM.panel2.Controls.Add(resultat[i]);
            }

            if (guanyar == 4)
            {
                MessageBox.Show("Enhorabona! Has Guanyat");
            }
            else
            {
                guanyar = 0;
            }


        }
        // retorna un PictureBox[casillasTotales] ple amb el resultat de blanques i negres de la linea que li pasem
    }
}