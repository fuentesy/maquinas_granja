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
    public partial class Tipo_Documento : Form
    {

        Conexion conexion = new Conexion();
        private string id_actualizar = "";
        public Tipo_Documento()
        {
            InitializeComponent();
            conexion.llenarDataGridViewTipoD(dtg_Tipo_Documento);
        }

        private bool verificar_campos()
        {
            if (!txt_Tipo_Documento.Text.Equals(""))

            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnACTUALIZAR_Click(object sender, EventArgs e) // cuando ingreso no me actualiza lo nuevo
        {
            try
            {
                if (!id_actualizar.Equals(""))

                {
                    if (verificar_campos())
                    {
                        string sql = "UPDATE tipo_documento SET Nombre_doc = '" + txt_Tipo_Documento.Text +
                            "' WHERE id_Tipo_documento='" + id_actualizar + "';";
                        conexion.abrir_coneccion();
                        MySqlCommand cmd = new MySqlCommand(sql, conexion.Realizar_Conexion);
                        MySqlDataReader leer = cmd.ExecuteReader();
                        conexion.cerrar_coneccion();

                    }
                    else
                    {
                        MessageBox.Show("Todos los campos son obligatorios");
                    }
                    conexion.llenarDataGridViewTipoD(dtg_Tipo_Documento);
                }

                conexion.llenarDataGridViewTipoD(dtg_Tipo_Documento);


            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar " + err);
                conexion.cerrar_coneccion();
            }
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificar_campos())

                {

                    conexion.abrir_coneccion();
                string sql_consultar_Centro = "SELECT count(Nombre_Doc)" +
                                 " FROM tipo_documento" +
                                 " WHERE Nombre_Doc=('" + txt_Tipo_Documento.Text + "');";
                MySqlCommand valores = new MySqlCommand(sql_consultar_Centro, conexion.Realizar_Conexion);
                Int32 total_registros_encontrados = System.Convert.ToInt32(valores.ExecuteScalar());
                if (total_registros_encontrados > 0)
                {
                    MessageBox.Show(" El tipo de documento ya existe!!");
                    txt_Tipo_Documento.Focus();
                }

                else
                {

                    String SQL_insert = " INSERT INTO tipo_documento (Nombre_Doc)" +
                                        " VALUES ('" + txt_Tipo_Documento.Text + "')";
                    MySqlCommand datos_requeridos = new MySqlCommand(SQL_insert, conexion.Realizar_Conexion);
                    datos_requeridos.ExecuteNonQuery();
                    MessageBox.Show(" SE GUARDO CON EXITO!!");

                }

                conexion.cerrar_coneccion();

            }
                else {
                MessageBox.Show("ingrese todos los campos", "Error");

            }

                txt_Tipo_Documento.Clear();

            }
            catch (Exception err)
            {

                MessageBox.Show("error" + err, "MENSAJE DEL SISTEMA");
            }
        }

        private void dtg_Tipo_Documento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_actualizar = Convert.ToString(dtg_Tipo_Documento.CurrentRow.Cells[0].Value);
            txt_Tipo_Documento.Text = Convert.ToString(dtg_Tipo_Documento.CurrentRow.Cells[1].Value);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_Tipo_Documento.Clear();
            btnACTUALIZAR.Enabled = true;
            btnBorrar.Enabled = true;
            BTNGUARDAR.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            string Doc = Convert.ToString(dtg_Tipo_Documento.CurrentRow.Cells[1].Value);

            DialogResult result = MessageBox.Show("¿ esta seguro que desea eliminar este archivo de forma permanente?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                conexion.abrir_coneccion();

                string Sql_borrar = " DELETE FROM tipo_documento" +
                                 " WHERE Nombre_Doc = ('" + Doc + "');";
                MySqlCommand CMD = new MySqlCommand(Sql_borrar, conexion.Realizar_Conexion);
                CMD.ExecuteNonQuery();
                conexion.cerrar_coneccion();
                conexion.llenarDataGridViewMatenimiento(dtg_Tipo_Documento);
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            string TipoDoc = txt_Tipo_Documento.Text;
            conexion.abrir_coneccion();

            string SQL_Buscar = "SELECT * FROM tipo_documento WHERE Nombre_doc=('" + TipoDoc + "');";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_Buscar, conexion.Realizar_Conexion);

            DataSet registros_encontrados = new DataSet();
            obtener.Fill(registros_encontrados);
            dtg_Tipo_Documento.DataSource = registros_encontrados.Tables[0];
            conexion.cerrar_coneccion();
        }

        private void txt_Tipo_Documento_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.txt_Tipo_Documento, "INGRESE TIPO DE DOCUMENTO ");
        }

        private void txt_Tipo_Documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.sololetras(e);
        }
    }
}
