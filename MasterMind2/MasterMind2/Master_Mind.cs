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

        private int dificultatGlobal = 0;
        public int _Dificultat { get { return dificultatGlobal; } set { dificultatGlobal = value; } }
        public int contadorBoles = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Master_Mind_Load(object sender, EventArgs e)
        {

            Organitzador.Constructor(4, this, _Dificultat);
 
        }


    }
}
