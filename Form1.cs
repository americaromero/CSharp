using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaListas2;

namespace PruebaDeLista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Lista Lista1 = new Lista("");
            bool b = true;
            char c = '%';
            int i = 45;
            string s = "Hola";
            Lista1.InsertarAlFrente(b);
            Lista1.InsertarAlFrente(c);
            Lista1.InsertarAlFrente(i);
            Lista1.InsertarAlFrente(s);
            txtCuadro.Text = Lista1.ImprimirLista(); 

        }
    }
}
