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
    public partial class Genero : Form
    {

        Conexion conexion = new Conexion();
        private string id_actualizar = "";
        public Genero()
        {
            InitializeComponent();
            conexion.llenarDataGridViewGenero(dtg_Genero);

        }

        private bool verificar_campos()
        {
            if (!id_actualizar.Equals(""))

            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnACTUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificar_campos())

                {
                    if (verificar_campos())
                    {
                        string sql = "UPDATE genero SET Genero = '" + txt_Genero.Text +
                            "' WHERE id_Genero='" + id_actualizar + "';";
                        conexion.abrir_coneccion();
                        MySqlCommand cmd = new MySqlCommand(sql, conexion.Realizar_Conexion);
                        MySqlDataReader leer = cmd.ExecuteReader();
                        conexion.cerrar_coneccion();

                    }
                    else
                    {
                        MessageBox.Show("Todos los campos son obligatorios");
                    }
                    conexion.llenarDataGridViewGenero(dtg_Genero);
                }

                conexion.llenarDataGridViewGenero(dtg_Genero);


            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar " + err);
                conexion.cerrar_coneccion();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txt_Genero.Text.Equals(""))

                {

                    conexion.abrir_coneccion();
                string sql_consultar_Centro = "SELECT count(Genero)" +
                                 " FROM genero" +
                                 " WHERE Genero=('" + txt_Genero.Text + "');";
                MySqlCommand valores = new MySqlCommand(sql_consultar_Centro, conexion.Realizar_Conexion);
                Int32 total_registros_encontrados = System.Convert.ToInt32(valores.ExecuteScalar());
                if (total_registros_encontrados > 0)
                {
                    MessageBox.Show(" El genero ya existe!!");
                    txt_Genero.Focus();
                }

                else
                {

                    String SQL_insert = " INSERT INTO genero (Genero)" +
                                        " VALUES ('" + txt_Genero.Text + "')";
                    MySqlCommand datos_requeridos = new MySqlCommand(SQL_insert, conexion.Realizar_Conexion);
                    datos_requeridos.ExecuteNonQuery();
                    MessageBox.Show(" SE GUARDO CON EXITO!!");

                }

                conexion.cerrar_coneccion();

              }
                else {
                MessageBox.Show("ingrese todos los campos", "Error");

            }


                txt_Genero.Clear();


            }
            catch (Exception err)
            {

                MessageBox.Show("error" + err, "MENSAJE DEL SISTEMA");
            }
        }

        private void dtg_Genero_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_actualizar = Convert.ToString(dtg_Genero.CurrentRow.Cells[0].Value);

            txt_Genero.Text = Convert.ToString(dtg_Genero.CurrentRow.Cells[1].Value);
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_Genero.Clear();
            btnACTUALIZAR.Enabled = true;
            btnBorrar.Enabled = true;
            btn_Guardar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string gen = Convert.ToString(dtg_Genero.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show("¿ esta seguro que desea eliminar este archivo de forma permanente?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                conexion.abrir_coneccion();

                string Sql_borrar = " DELETE FROM genero" +
                                 " WHERE id_Genero = ('" + gen + "');";
                MySqlCommand CMD = new MySqlCommand(Sql_borrar, conexion.Realizar_Conexion);
                CMD.ExecuteNonQuery();
                conexion.cerrar_coneccion();
                conexion.llenarDataGridViewGenero(dtg_Genero);
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void dtg_Genero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            string genero = txt_Genero.Text;
            conexion.abrir_coneccion();

            string SQL_Buscar = "SELECT * FROM genero WHERE Genero=('" + genero + "');";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_Buscar, conexion.Realizar_Conexion);

            DataSet registros_encontrados = new DataSet();
            obtener.Fill(registros_encontrados);
            dtg_Genero.DataSource = registros_encontrados.Tables[0];
            conexion.cerrar_coneccion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Genero_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.txt_Genero, "INGRESE GENERO ");
        }

        private void txt_Genero_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.sololetras(e);
        }
    }
}
