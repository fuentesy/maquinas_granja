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
    public partial class combustible : Form
    {
      
        Conexion conexion = new Conexion();


        public combustible()
        {
            InitializeComponent();
            conexion.llenarDataGridView1(dataGridView1);
        }

        private void btnGuardar_C_Click(object sender, EventArgs e)
        {            
            try
            {             
                conexion.abrir_coneccion();             

                    string Query_insert = " INSERT INTO combustible (Combustible, Cantidad, Fecha, Precio_galon, Precio_total)" +
                                           " VALUES('" + textCombustible.Text + "' , '" + textCantidad.Text + "' , '" + txtfecha.Text + "' , '" + textPrecio.Text + "' , '" + textTotal.Text + "');";
                    MySqlCommand datos_requeridos = new MySqlCommand(Query_insert, conexion.Realizar_Conexion);
                    datos_requeridos.ExecuteNonQuery();
                    MessageBox.Show(" La operacion se realizo satisfactoriamente ");              
                    conexion.cerrar_coneccion();
            }
            catch (Exception err)  //tch (Exception err)
            {
                MessageBox.Show(" No existe informacion para guardar " + err);
            }
        }

        private void btnBorrar_C_Click(object sender, EventArgs e)
        {

            string combustible = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show("¿ esta seguro que desea eliminar este archivo de forma permanente?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                conexion.abrir_coneccion();

                string Sql_borrar = " DELETE FROM combustible" +
                                 " WHERE id_Combustible = ('" + combustible + "');";
                MySqlCommand CMD = new MySqlCommand(Sql_borrar, conexion.Realizar_Conexion);
                CMD.ExecuteNonQuery();
                conexion.cerrar_coneccion();
                conexion.llenarDataGridView1(dataGridView1);
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            textCombustible.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            textCantidad.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            //dateTimePicker1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            textPrecio.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            textTotal.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);

            btnGuardar_C.Enabled = false;
            btnBorrar_C.Enabled = true;
            btnActualizar_C.Enabled = true;

        }

        private void btnActualizar_C_Click(object sender, EventArgs e)
        {
            conexion.llenarDataGridView1(dataGridView1);
        }

        private void btnLimpiar_C_Click(object sender, EventArgs e)
        {
            textCombustible.Clear();
            textCantidad.Clear();
     
            textPrecio.Clear();
            textTotal.Clear();
            btnGuardar_C.Enabled = true;
            btnBuscar_C.Enabled = true;
            btnBorrar_C.Enabled = true;
            btnActualizar_C.Enabled = true;
        }

        private void btnBuscar_C_Click(object sender, EventArgs e)
        {
            string combustible = textCombustible.Text;
            conexion.abrir_coneccion();

            string SQL_Buscar = "SELECT * FROM combustible WHERE id_Combustible=('" + combustible + "');";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_Buscar, conexion.Realizar_Conexion);

            DataSet registros_encontrados = new DataSet();
            obtener.Fill(registros_encontrados);
            dataGridView1.DataSource = registros_encontrados.Tables[0];
            conexion.cerrar_coneccion();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtfecha.Text = datefechacom.Text;
            string dt = txtfecha.Text;
            DateTime Mydatetime = DateTime.Parse(dt);
            string dia = Convert.ToString(Mydatetime.Day);
            string mes = Convert.ToString(Mydatetime.Month);
            string ano = Convert.ToString(Mydatetime.Year);
            txtfecha.Text = ano + "/" + mes + "/" + dia;
        }

        private void textCombustible_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    }
}
        
    
