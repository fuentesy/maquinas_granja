using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MAQUINAS_GRANJA
{
    public partial class Fondo : Form
    {
        public Fondo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login t1 = new Login();
            t1.Show();

        }

        private void Fondo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Recuperar_Cuenta t3 = new Recuperar_Cuenta();
            t3.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();

            l1.Visible = true;
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Recuperar_Cuenta re1 = new Recuperar_Cuenta();
            re1.Show();


            re1.Visible = true;
            Visible = false;
        }
    }
}
