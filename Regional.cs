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
    public partial class Regional : Form
    {
        Conexion conexion = new Conexion();
        private string id_actualizar = "";
        public Regional()
        {
            InitializeComponent();
            conexion.llenarDataGridViewRegional(dtg_Regional,"");
            conexion.llenar_busquedaRegional(comboBox_buscar);
        }

        private bool verificar_campos()
        {

            if (!txt_Nombre_Empresa.Text.Equals("") &&
               !txtCodigo.Text.Equals("") &&
               !txt_Telefono.Text.Equals("") &&
               !txt_Direccion.Text.Equals("") &&
               !txt_Correo.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void dtg_Regional_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificar_campos())

                {
                    conexion.abrir_coneccion();

                string Sql_consultar_iden = " SELECT count(Nombre_regional)" +
                                        "FROM regional" +
                                        " WHERE Nombre_regional = ('" + txt_Nombre_Empresa.Text + "');";
                MySqlCommand valores = new MySqlCommand(Sql_consultar_iden, conexion.Realizar_Conexion);
                Int32 total_registros_encontrados = System.Convert.ToInt32(valores.ExecuteScalar());
                if (total_registros_encontrados > 0)
                {
                    MessageBox.Show(" La Regional ya existe !!");
                    txt_Nombre_Empresa.Focus();
                }

                else
                {
                    string Sql_consultar_codigo = " SELECT count(Codigo) " +
                                        "FROM regional" +
                                        " WHERE Codigo = ('" + txtCodigo.Text + "');";
                    MySqlCommand val = new MySqlCommand(Sql_consultar_codigo, conexion.Realizar_Conexion);
                    total_registros_encontrados = System.Convert.ToInt32(val.ExecuteScalar());
                    if (total_registros_encontrados > 0)
                    {
                        MessageBox.Show(" EL CODIGO DIGITADO  YA EXISTE !!");
                        txtCodigo.Focus();
                    }



                else
                {
                    string Sql_consultar_email = " SELECT count(Correo) " +
                                        "FROM regional" +
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

                        String SQL_insert = " INSERT INTO regional (Nombre_regional, Codigo, Telefono,   Direccion, " +
                                 "Correo ) " +
                                            " VALUES ('" + txt_Nombre_Empresa.Text + "','" + txtCodigo.Text + "', '" + txt_Telefono.Text +
                                            "', '" + txt_Direccion.Text + "', '" + txt_Correo.Text + "');";
                        MySqlCommand datos_requeridos = new MySqlCommand(SQL_insert, conexion.Realizar_Conexion);
                        datos_requeridos.ExecuteNonQuery();
                        MessageBox.Show(" SE GUARDO CON EXITO!!");
                    }
                }

            }

                conexion.cerrar_coneccion();
            }
                else {
                MessageBox.Show("ingrese todos los campos", "Error");

            }


                txt_Nombre_Empresa.Clear();
                txtCodigo.Clear();
                txt_Telefono.Clear();
                txt_Direccion.Clear();
                txt_Correo.Clear();

            }

            catch (Exception err)
            {

                MessageBox.Show("error" + err, "MENSAJE DEL SISTEMA");
                conexion.cerrar_coneccion();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!id_actualizar.Equals(""))
                {
                    if (verificar_campos())
                    {
                        string sql = "UPDATE regional SET Nombre_regional = '" + txt_Nombre_Empresa.Text + "', Codigo ='" + txtCodigo.Text +
                            "', Telefono='" + txt_Telefono.Text + "', Direccion = '" + txt_Direccion.Text + "', Correo ='" + txt_Correo.Text +
                            "' WHERE id_Regional='" + id_actualizar + "';";
                        conexion.abrir_coneccion();
                        MySqlCommand cmd = new MySqlCommand(sql, conexion.Realizar_Conexion);
                        MySqlDataReader leer = cmd.ExecuteReader();
                        conexion.cerrar_coneccion();

                    }
                    else
                    {
                        MessageBox.Show("Todos los campos son obligatorios");
                    }
                    conexion.llenarDataGridViewRegional(dtg_Regional, "");
                }

                conexion.llenarDataGridViewRegional(dtg_Regional, "");

            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar " + err);
                conexion.cerrar_coneccion();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_Nombre_Empresa.Clear();
            txtCodigo.Clear();
            txt_Telefono.Clear();
            txt_Direccion.Clear();
            txt_Correo.Clear();
            btnGuardar.Enabled = true;
            btnBorrar.Enabled = true;
            btnActualizar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string nempre = Convert.ToString(dtg_Regional.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show("¿ esta seguro que desea eliminar este archivo de forma permanente?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                conexion.abrir_coneccion();

                string Sql_borrar = " DELETE FROM regional" +
                                 " WHERE id_Regional = ('" + nempre + "');";
                MySqlCommand CMD = new MySqlCommand(Sql_borrar, conexion.Realizar_Conexion);
                CMD.ExecuteNonQuery();
                conexion.cerrar_coneccion();
                conexion.llenarDataGridViewRegional(dtg_Regional,"");
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 cantidad_tipo = Convert.ToInt32(comboBox_buscar.Text.Length);
                Int32 cantidad_dato = Convert.ToInt32(txtDatoBuscar.Text.Length);
                string sql_complemento = "";
                if (!comboBox_buscar.Text.Equals("") && !txtDatoBuscar.Text.Equals(""))
                {
                   
                    conexion.abrir_coneccion();

                    string sql_buscar_dato = "SELECT id FROM regionaldos WHERE  regional ='" + comboBox_buscar.Text + "'";
                    MySqlCommand mycomando = new MySqlCommand(sql_buscar_dato, conexion.Realizar_Conexion);
                    string dato_encontrado = Convert.ToString(mycomando.ExecuteScalar());
                    conexion.cerrar_coneccion();
                    int p = 0;
                    switch (dato_encontrado)
                    {
                        case "1":
                            sql_complemento = " WHERE Nombre_regional  LIKE '%" + txtDatoBuscar.Text + "%' ";
                         p=   conexion.llenarDataGridViewRegional(dtg_Regional, sql_complemento);
                            break;
                        case "2":
                            sql_complemento = " WHERE Codigo LIKE '%" + txtDatoBuscar.Text + "%' ";
                        p=    conexion.llenarDataGridViewRegional(dtg_Regional, sql_complemento);
                            break;
                      
                    }
                    if (p == 0)
                    {
                        MessageBox.Show("NO SE ENCONTRARON REGISTROS ", "MENSAJE DEL SERVIDOR");
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY DATOS A CONSULTAR ", "MENSAJE DEL SERVIDOR");
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Error " + er, "MENSAJE DEL SERVIDOR");
            }
        }

        private void txtDatoBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.solonumeros(e);
        }

        private void dtg_Regional_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_actualizar = Convert.ToString(dtg_Regional.CurrentRow.Cells[0].Value);
            txt_Nombre_Empresa.Text = Convert.ToString(dtg_Regional.CurrentRow.Cells[1].Value);
            txtCodigo.Text = Convert.ToString(dtg_Regional.CurrentRow.Cells[2].Value);
            txt_Telefono.Text = Convert.ToString(dtg_Regional.CurrentRow.Cells[3].Value); 
            txt_Direccion.Text = Convert.ToString(dtg_Regional.CurrentRow.Cells[4].Value);
            txt_Correo.Text = Convert.ToString(dtg_Regional.CurrentRow.Cells[5].Value);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.solonumeros(e);
        }

        private void txt_Nombre_Empresa_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.txt_Nombre_Empresa, "INGRESE EL NOMBRE DE LA EMPRESA");
            ToolTip1.SetToolTip(this.txtCodigo, "INGRESE EL CODIGO");
            ToolTip1.SetToolTip(this.txt_Telefono, "INGRESE EL TELEFONO");
            ToolTip1.SetToolTip(this.txt_Direccion, "INGRESE LA DIRECCION");
            ToolTip1.SetToolTip(this.txt_Correo, "INGRESE EL CORREO");
           
        }

        private void txt_Nombre_Empresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.sololetras(e);
        }
    }
}
