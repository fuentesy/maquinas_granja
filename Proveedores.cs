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
    public partial class Proveedores : Form
    {
        Conexion conexion = new Conexion();
        public Proveedores()
        {
            InitializeComponent();
            conexion.llenar_Area(cbxid_Area, txtCentro.Text);
            conexion.llenar_centro(combCentro);
            conexion.llenarDataGridViewProveedores(dtg_Proveedores);
        }

        private void dtg_Proveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir_coneccion();
                int id_Area;
                id_Area = cbxid_Area.SelectedIndex + 1;

                string sql_consultar_Centro = "SELECT count(Nombre)" +
                                 " FROM proveedores" +
                                 " WHERE Nombre=('" + txt_Nombre.Text + "');";
                MySqlCommand valores = new MySqlCommand(sql_consultar_Centro, conexion.Realizar_Conexion);
                Int32 total_registros_encontrados = System.Convert.ToInt32(valores.ExecuteScalar());
                if (total_registros_encontrados > 0)
                {
                    MessageBox.Show(" El provedor ya existe!!");
                    txt_Nombre.Focus();
                }

                else
                {
                    string Sql_consultar_telefono = " SELECT count(Telefono) " +
                                        "FROM proveedores" +
                                        " WHERE Telefono = ('" + txt_Telefono.Text + "');";
                    MySqlCommand val = new MySqlCommand(Sql_consultar_telefono, conexion.Realizar_Conexion);
                    total_registros_encontrados = System.Convert.ToInt32(val.ExecuteScalar());
                    if (total_registros_encontrados > 0)
                    {
                        MessageBox.Show(" EL TELEFONO DIGITADO  YA EXISTE !!");
                        txt_Telefono.Focus();
                    }

                    else
                    {
                        string Sql_consultar_direccion = " SELECT count(Direccion) " +
                                            "FROM proveedores" +
                                            " WHERE Direccion = ('" + txt_Direccion.Text + "');";
                        MySqlCommand direccion = new MySqlCommand(Sql_consultar_direccion, conexion.Realizar_Conexion);
                        total_registros_encontrados = System.Convert.ToInt32(direccion.ExecuteScalar());
                        if (total_registros_encontrados > 0)
                        {
                            MessageBox.Show(" LA DIRECCION DIGITADA  YA EXISTE !!");
                            txt_Direccion.Focus();
                        }

                        else
                        {
                            string Sql_consultar_email = " SELECT count(Correo) " +
                                                "FROM Proveedores" +
                                                " WHERE Correo = ('" + txt_Correo.Text + "');";
                            MySqlCommand valor = new MySqlCommand(Sql_consultar_email, conexion.Realizar_Conexion);
                            total_registros_encontrados = System.Convert.ToInt32(valor.ExecuteScalar());
                            if (total_registros_encontrados > 0)
                            {
                                MessageBox.Show(" EL CORREO DIGITADO  YA EXISTE !!");
                                txt_Correo.Focus();
                            }



                            else
                            {

                                String SQL_insert = " INSERT INTO proveedores (Nombre, direccion,ciudad,telefono,correo, id_Area)" +
                                                    " VALUES ('" + txt_Nombre.Text + "','" + txt_Direccion.Text + "','" + txt_Ciudad.Text +
                                                    "','" + txt_Telefono.Text + "','" + txt_Correo.Text + "','" + id_Area + "')";
                                MySqlCommand datos_requeridos = new MySqlCommand(SQL_insert, conexion.Realizar_Conexion);
                                datos_requeridos.ExecuteNonQuery();
                                MessageBox.Show(" SE CONECTO CON EXITO!!");

                            }

                        }
                    }

                }
                conexion.cerrar_coneccion();
            }
            catch (Exception err)
            {

                MessageBox.Show("error" + err, "MENSAJE DEL SISTEMA");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Focus();
            txt_Direccion.Clear();
            txt_Telefono.Clear();
            txt_Correo.Clear();
            txt_Ciudad.Clear();


            btnGuardar.Enabled = true;
            btnBorrar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnActualizar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conexion.llenarDataGridViewProveedores(dtg_Proveedores);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string doc = Convert.ToString(dtg_Proveedores.CurrentRow.Cells[1].Value);

            DialogResult result = MessageBox.Show("¿ esta seguro que desea eliminar este archivo de forma permanente?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                conexion.abrir_coneccion();

                string Sql_borrar = " DELETE FROM proveedores" +
                                 " WHERE Nombre = ('" + doc + "');";
                MySqlCommand CMD = new MySqlCommand(Sql_borrar, conexion.Realizar_Conexion);
                CMD.ExecuteNonQuery();
                conexion.cerrar_coneccion();
                conexion.llenarDataGridViewProveedores(dtg_Proveedores);
            }
            else if (result == DialogResult.No)
            {
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

      

        private void cbxCentro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txtCentro.Text = combCentro.Text;
                cbxid_Area.Items.Clear();
                conexion.llenar_Area(cbxid_Area, txtCentro.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("eere", "erer" + err);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dtg_Proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg_Proveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Nombre.Text = Convert.ToString(dtg_Proveedores.CurrentRow.Cells[1].Value);
            txt_Direccion.Text = Convert.ToString(dtg_Proveedores.CurrentRow.Cells[2].Value);
            txt_Ciudad.Text = Convert.ToString(dtg_Proveedores.CurrentRow.Cells[3].Value);
            txt_Telefono.Text = Convert.ToString(dtg_Proveedores.CurrentRow.Cells[4].Value);
            txt_Correo.Text = Convert.ToString(dtg_Proveedores.CurrentRow.Cells[5].Value);
            cbxid_Area.Text = Convert.ToString(dtg_Proveedores.CurrentRow.Cells[6].Value);
            // aqui hay error no me da dobleclick

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void txt_Telefono_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && ((e.KeyChar) != 32))
                {
                    MessageBox.Show(" solo se permite numeros", " advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;

                }
            }

        }
    }
}
           

