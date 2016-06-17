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
    public partial class Rol : Form

    {

        Conexion conexion = new Conexion();
        private string id_actualizar = "";
        public Rol()
        {
            InitializeComponent();
            conexion.llenarDataGridViewRol(dtg_Rol);
        }

        private bool verificar_campos()
        {
            if (!txt_Rol.Text.Equals(""))

            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_actualizar = Convert.ToString(dtg_Rol.CurrentRow.Cells[0].Value);
            txt_Rol.Text = Convert.ToString(dtg_Rol.CurrentRow.Cells[1].Value);
        }

       

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (verificar_campos())

                {
                    conexion.abrir_coneccion();
                string sql_consultar_Centro = "SELECT count(Nombre_Rol)" +
                                 " FROM rol" +
                                 " WHERE Nombre_Rol=('" + txt_Rol.Text + "');";
                MySqlCommand valores = new MySqlCommand(sql_consultar_Centro, conexion.Realizar_Conexion);
                Int32 total_registros_encontrados = System.Convert.ToInt32(valores.ExecuteScalar());
                if (total_registros_encontrados > 0)
                {
                    MessageBox.Show(" El Rol ya existe!!");
                    txt_Rol.Focus();
                }

                else
                {

                    String SQL_insert = " INSERT INTO rol (Nombre_Rol)" +
                                        " VALUES ('" + txt_Rol.Text + "')";
                    MySqlCommand datos_requeridos = new MySqlCommand(SQL_insert, conexion.Realizar_Conexion);
                    datos_requeridos.ExecuteNonQuery();
                    MessageBox.Show(" SE GUARDO CON EXITO!!");

                }

                conexion.cerrar_coneccion();
                }
                else {
                    MessageBox.Show("ingrese todos los campos", "Error");

                }

                txt_Rol.Clear();

            }
            catch (Exception err)
            {

                MessageBox.Show("error" + err, "MENSAJE DEL SISTEMA");
                conexion.cerrar_coneccion();
            }
        }

        private void Rol_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!id_actualizar.Equals(""))
                {
                    if (verificar_campos())
                    {
                        string sql = "UPDATE rol SET Nombre_rol = '" + txt_Rol.Text + 
                            "' WHERE id_Rol='" + id_actualizar + "';";
                        conexion.abrir_coneccion();
                        MySqlCommand cmd = new MySqlCommand(sql, conexion.Realizar_Conexion);
                        MySqlDataReader leer = cmd.ExecuteReader();
                        conexion.cerrar_coneccion();

                    }
                    else
                    {
                        MessageBox.Show("Todos los campos son obligatorios");
                    }
                    conexion.llenarDataGridViewRol(dtg_Rol);
                }

                conexion.llenarDataGridViewRol(dtg_Rol);


            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar " + err);
                conexion.cerrar_coneccion();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txt_Rol.Clear();
            button1.Enabled = true;
            btnBorrar.Enabled = true;
            btnguardar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string rol = Convert.ToString(dtg_Rol.CurrentRow.Cells[1].Value);

            DialogResult result = MessageBox.Show("¿ esta seguro que desea eliminar este archivo de forma permanente?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                conexion.abrir_coneccion();

                string Sql_borrar = " DELETE FROM rol" +
                                 " WHERE Nombre_Rol = ('" + rol + "');";
                MySqlCommand CMD = new MySqlCommand(Sql_borrar, conexion.Realizar_Conexion);
                CMD.ExecuteNonQuery();
                conexion.cerrar_coneccion();
                conexion.llenarDataGridViewMatenimiento(dtg_Rol);
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            string rol = txt_Rol.Text;
            conexion.abrir_coneccion();

            string SQL_Buscar = "SELECT * FROM rol WHERE Nombre_rol=('" + rol + "');";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_Buscar, conexion.Realizar_Conexion);

            DataSet registros_encontrados = new DataSet();
            obtener.Fill(registros_encontrados);
            dtg_Rol.DataSource = registros_encontrados.Tables[0];
            conexion.cerrar_coneccion();
        }

        private void dtg_Rol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Rol_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.txt_Rol, "INGRESE ROL ");
        }

        private void txt_Rol_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.sololetras(e);
        }
    }
}
