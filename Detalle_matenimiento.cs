using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
namespace MAQUINAS_GRANJA
{
    public partial class Detalle_matenimiento : Form
    {
        Conexion conexion = new Conexion();

        public Detalle_matenimiento()
        {
            InitializeComponent();
            conexion.llenarDataGridViewDetalleMantenmiento(dataGridViewdetalle);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtfecha.Text = dateTimefecha.Text;
            string dt = txtfecha.Text;
            DateTime myDatetime = DateTime.Parse(dt);
            string dia = Convert.ToString(myDatetime.Day);
            string mes = Convert.ToString(myDatetime.Month);
            string ano = Convert.ToString(myDatetime.Year);
            txtfecha.Text = ano +"/"+ mes +"/"+ dia;
        }

        private void Detalle_matenimiento_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir_coneccion();

                string Query_insert = "insert into detalle_mantenimiento (Fecha_registro, Observaciones_detalle_mantenimiento)" +
                                      "values ('" + txtfecha.Text + "' , '" + txtdetallefor.Text + "');";
                MySqlCommand datos_requeridos = new MySqlCommand(Query_insert, conexion.Realizar_Conexion);
                datos_requeridos.ExecuteNonQuery();
                conexion.cerrar_coneccion();
                MessageBox.Show("se guardo con exito");
            }
            catch (Exception err)
            {
                MessageBox.Show("error"+ err, "mensaje del sistema");
            }
        }

        private void txtdetalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            string detalle_mantenimiento = Convert.ToString(dataGridViewdetalle.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show("¿ Esta seguro que desea eliminar este archivo de forma permanente?", "Eliminar", MessageBoxButtons.YesNo);
            

            if (result == DialogResult.Yes)
            {
                conexion.abrir_coneccion();

                string Sql_borrar = "DELETE FROM detalle_mantenimiento" +
                                    "WHERE id_Detalle_mantenimiento = ('" + detalle_mantenimiento + "');";
                MySqlCommand CMD = new MySqlCommand(Sql_borrar, conexion.Realizar_Conexion);
                CMD.ExecuteNonQuery();
                conexion.cerrar_coneccion();
                conexion.llenarDataGridViewDetalleMantenmiento(dataGridViewdetalle);
            }


        }

        private void dataGridViewMantenimiento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimefecha.Text = Convert.ToString(dataGridViewdetalle.CurrentRow.Cells[1].Value);
            txtdetallefor.Text = Convert.ToString(dataGridViewdetalle.CurrentRow.Cells[2].Value);

            btnGuardar.Enabled = false;
            btnborrar.Enabled = true;
            btnActualizar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            txtdetallefor.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conexion.llenarDataGridViewDetalleMantenmiento(dataGridViewdetalle);
        }
    }
}
