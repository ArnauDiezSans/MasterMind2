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
    public partial class Master_Mind : Form
    {
        public Master_Mind()
        {
            InitializeComponent();
        }
        // atributo para guardar la dificultad
        private int dificultatGlobal = 0;
        public int _Dificultat { get { return dificultatGlobal; } set { dificultatGlobal = value; } }
        // atributo para poner nombres distintos a cada bola, luego se añaden en el nombre
        public int contadorBoles = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Master_Mind_Load(object sender, EventArgs e)
        {
            // llamamos al constructor organizador
            Organitzador.Constructor(4, this, _Dificultat);
 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PictureBox bola; 
            for (int x = 5; x < 9; x++)
            {
                bola = (System.Windows.Forms.PictureBox)panel3.Controls["bola" + Convert.ToString(x)]; //agafem cada botó
                bola.Visible = true; // treiem lo text
                bola.Update(); // actualitzem
            }
        }
    }
}
