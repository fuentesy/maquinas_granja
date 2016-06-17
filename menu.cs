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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void dvfdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void ccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regional c1 = new Regional();
            c1.Show();


            //c1.Visible = true;
            //Visible = false;




        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

       
        private void tMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento m4 = new Mantenimiento();
            m4.Show();

           
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maquinas m1 = new Maquinas();
            m1.Show();

           
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores p7 = new Proveedores();
            p7.Show();

            
        }

        private void rDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void tipoMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dMToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void reginalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Centro a1 = new Centro();
            a1.Show();

          
            


        }

        private void maquinaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Area ar2 = new Area();
            ar2.Show();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fondo lo1 = new Fondo();
            lo1.Show();

            lo1.Visible = true;
            Visible = false;
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rol r1 = new Rol();
            r1.Show();

           
        }

        private void horasMaquinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Horas_maquina h2 = new Horas_maquina();
            h2.Show();

           
        }

        private void revisionDiariaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void combustibleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            combustible c3 = new combustible();
            c3.Show();

           
        }

        private void tipoDeCombustibleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tipoDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipo_mantenimiento t5 = new Tipo_mantenimiento();
            t5.Show();

        }

        private void detalleDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalle_matenimiento d6 = new Detalle_matenimiento();
            d6.Show();

          
        }

        private void facturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Factura f7 = new Factura();
            f7.Show();
           
        }

        private void detalleDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
