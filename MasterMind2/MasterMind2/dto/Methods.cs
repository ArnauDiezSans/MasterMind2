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
                bolascolores[i].Location = new System.Drawing.Point(35-8*(bolascolores.Length-4) + (43 * i), 50);
            }
            // asignamos los las bolas con todos sus eventos de onclick para la paleta
            bolascolores[0].Click += (sender, EventArgs) => { Organitzador.copiarColor_Click(sender, EventArgs, bolascolores[0], MM); };
            bolascolores[1].Click += (sender, EventArgs) => { Organitzador.copiarColor_Click(sender, EventArgs, bolascolores[1], MM); };
            bolascolores[2].Click += (sender, EventArgs) => { Organitzador.copiarColor_Click(sender, EventArgs, bolascolores[2], MM); };
            bolascolores[3].Click += (sender, EventArgs) => { Organitzador.copiarColor_Click(sender, EventArgs, bolascolores[3], MM); };
            if (numeroColores==5) // si son 5 colores añade el evento para el 5º color
            {
                bolascolores[4].Click += (sender, EventArgs) => { Organitzador.copiarColor_Click(sender, EventArgs, bolascolores[4], MM); };
            }
            if (numeroColores == 6) // si son 6 colores añade el evento para el 5º y 6º color
            {
                bolascolores[4].Click += (sender, EventArgs) => { Organitzador.copiarColor_Click(sender, EventArgs, bolascolores[4], MM); };
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
            }
            return bolassolucion;

        }

        public static void crear_linea_bola(int casillasTotales, Color[] colors, Master_Mind MM, int offset, PictureBox[] solucio)
        {
            // método para generar cuatro bolas vacias para que el jugador pueda seleccionar el color
            // y enviar el contenido a revisar

            // generamos un array de bolas vacias
            PictureBox[] bolasVacias = new PictureBox[casillasTotales];

            // recorremos el array y la llenamos usando el método
            for (int i = 0; i < casillasTotales; i++)
            {
                // añadimos la bola en cada posición con una localización diferente para que se espacien horizontalmente
                bolasVacias[i] = crear_bola(Color.White,i, MM);
                bolasVacias[i].Location = new Point(bolasVacias[i].Location.X-30, bolasVacias[i].Location.Y + (offset * 43));
            }
            // añadimos el evento onclick para poder pintarlas
            bolasVacias[0].Click += (sender, EventArgs) => { Organitzador.pegarColor_Click(sender, EventArgs, bolasVacias[0], MM); };
            bolasVacias[1].Click += (sender, EventArgs) => { Organitzador.pegarColor_Click(sender, EventArgs, bolasVacias[1], MM); };
            bolasVacias[2].Click += (sender, EventArgs) => { Organitzador.pegarColor_Click(sender, EventArgs, bolasVacias[2], MM); };
            bolasVacias[3].Click += (sender, EventArgs) => { Organitzador.pegarColor_Click(sender, EventArgs, bolasVacias[3], MM); };
            for (int i = 0; i < casillasTotales; i++) // recorremos el array de objetos
            {
                // añadimos las bolas y las printamos en el panel 1
                MM.panel1.Controls.Add(bolasVacias[i]);
            }

            // generamos un nuevo boton enviar
            Button enviar = new Button();
            enviar.Text = "Enviar";
            enviar.Location = new System.Drawing.Point(212, 50);
            enviar.Location= new Point(enviar.Location.X,enviar.Location.Y+ (offset*43));
            MM.panel1.Controls.Add(enviar); // lo asignamos al panel junto con los botones
            // añadimos el evento onclick para poder enviar a ejecutar las comprobaciones
            enviar.Click += (sender, EventArgs) => { Organitzador.enviar_Click(enviar, EventArgs, bolasVacias, offset, colors, MM, solucio); };
        }

        public static PictureBox crear_bola(Color color, int repeticio, Master_Mind MM)
        {
            // método per crear una bola con el color pasado por parámetro
            
            PictureBox bola = new PictureBox();

            bola.Width = bolaAmple;
            bola.Height = bolaAltura;
            bola.BorderStyle = BorderStyle.FixedSingle;
            bola.Margin = new System.Windows.Forms.Padding(bolaMarginLeft, bolaMarginTop, bolaMarginRight, bolaMarginBottom);
            bola.BackColor = color;
            bola.Left = 300;
            bola.Location = new System.Drawing.Point(70 + (43 * repeticio), 50);
            bola.Name = "bola"+Convert.ToString(MM.contadorBoles); // asignamos el nombre con un contador para poner nombres diferentes
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

            // recorremos el array de la solución comparándolo con el array pasado
            for (int i = 0; i < linea.Length; i++)
            {
                if (linea[i].BackColor == solucio[i].BackColor) // si coincide
                {
                    negras++; // sumamos una a las negras 
                    posicionsNegres[i] = 1; // guardamos la posición
                }
                else // si no es del mismo color
                {
                    for (int x = 0; x < linea.Length; x++) // recorremos el array y lo comprobamos con el color
                    {
                        if ((linea[i].BackColor == solucio[x].BackColor) && (posicionsNegres[x] == 0)) // si coincice el color pero no la posicion
                        {
                            blancas++; // sumamos blancas
                        }
                    }
                }
            }
            
            // recorremos el array anterior
            for (int i = 0; i < linea.Length; i++)
            {
                if (negras > 0) // printamos las negras
                {
                    resultat[i] = crear_bola(Color.Black, i, MM);
                    resultat[i].Location = new Point(resultat[i].Location.X - 30, resultat[i].Location.Y + (offset * 43));                
                    negras--;
                    guanyar++;
                }
                else if (blancas > 0) // printamos las blancas
                {
                    resultat[i] = crear_bola(Color.White, i, MM);
                    resultat[i].Location = new Point(resultat[i].Location.X - 30, resultat[i].Location.Y + (offset * 43));
                    blancas--;
                }
                else // printamos las grises
                {
                    resultat[i] = crear_bola(Color.Gray, i, MM);
                    resultat[i].Location = new Point(resultat[i].Location.X - 30, resultat[i].Location.Y + (offset * 43));
                }
            }
            // añadimos el array al panel de resultados
            for (int i = 0; i < resultat.Length; i++) // recorremos el array de objetos
            {

                MM.panel2.Controls.Add(resultat[i]);
            }

            // si coinciden las 4 bolas negras, has ganado
            if (guanyar == 4)
            {
                MessageBox.Show("Enhorabona! Has Guanyat");
            }
            else // si no reseteamos el contador para la siguiente entrada
            {
                guanyar = 0;
            }
            
            // comprobamos y printamos los intentos
            MM.label3.Text = ("Intentos Restantes: " + (9 - offset));
            if (offset == 9) // si ha llegado a 10 intentos, terminamos el juego
            {
                MessageBox.Show("GAME OVER");
                Application.Exit();
            }


        }
        // retorna un PictureBox[casillasTotales] ple amb el resultat de blanques i negres de la linea que li pasem
    }
}
