using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semana2_Primer_formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Gustavo Cerna";
            label2.Text = "Monica Campos";
            label3.Text = "Lorena Rodriguez";
            label4.Text = "Ivania Matas";
            label5.Text = "Fredy Campos";
            label6.Text = "Cristian Herrera";
       

        }
    }
}
