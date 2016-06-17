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
    public partial class Centro : Form
    {
        Conexion conexion = new Conexion();
        private string id_actualizar = "";
        public Centro()
        {
            InitializeComponent();
            conexion.llenarDataGridViewCentro(dtg_Centro,"");
            conexion.llenar_Regional(cbxempresa);
            conexion.llenar_busquedaCentro(comboBox_buscar);
            //conexion.llenar_nombre_centro(cmbBox_Centro);
        }

        private bool verificar_campos()
        {
            if (!txtCentro.Text.Equals("") &&
               !txtDireccion.Text.Equals("") &&
               !txtTelefonoC.Text.Equals("") &&
               !txtCorreoC.Text.Equals("") &&
               !cbxempresa.Text.Equals(""))


            {
                return true;
            }
            else
            {
                return false;
            }

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (verificar_campos())
                {
                    conexion.abrir_coneccion();

                    int id_Regional;
                    id_Regional = cbxempresa.SelectedIndex + 1;

                    string sql_consultar_Centro = "SELECT count(Nombre_centro)" +
                                     " FROM centro" +
                                     " WHERE Nombre_centro=('" + txtCentro.Text + "');";
                    MySqlCommand valores = new MySqlCommand(sql_consultar_Centro, conexion.Realizar_Conexion);
                    Int32 total_registros_encontrados = System.Convert.ToInt32(valores.ExecuteScalar());
                    if (total_registros_encontrados > 0)
                    {
                        MessageBox.Show(" El centro ya existe!!");
                        txtCentro.Focus();
                    }
                    else {
                        string Sql_consultar_email = " SELECT count(Correo) " +
                                                    "FROM centro" +
                                                    " WHERE Correo = ('" + txtCorreoC.Text + "');";
                        MySqlCommand v = new MySqlCommand(Sql_consultar_email, conexion.Realizar_Conexion);
                        total_registros_encontrados = System.Convert.ToInt32(v.ExecuteScalar());
                        if (total_registros_encontrados > 0) {

                            MessageBox.Show(" El correo ya existe!!");
                            txtCentro.Focus();
                        }
                        else
                        {
                            string Sql_consultar_telefono = " SELECT count(Telefono) " +
                                                "FROM centro" +
                                                " WHERE Telefono = ('" + txtTelefonoC.Text + "');";
                            MySqlCommand valor = new MySqlCommand(Sql_consultar_telefono, conexion.Realizar_Conexion);
                            total_registros_encontrados = System.Convert.ToInt32(valor.ExecuteScalar());
                            if (total_registros_encontrados > 0)
                            {
                                MessageBox.Show(" EL TELEFONO DIGITADO  YA EXISTE !!");
                                txtTelefonoC.Focus();
                            }

                            else
                            {
                                String SQL_insert = " INSERT INTO centro (Nombre_centro, Direccion, Telefono, Correo, id_Regional)" +
                                                    " VALUES ('" + txtCentro.Text + "','" + txtDireccion.Text + "','" + txtTelefonoC.Text + "','" + txtCorreoC.Text + "', '" + id_Regional + "')";
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


                txtCentro.Clear();
                txtDireccion.Clear();
                txtTelefonoC.Clear();
                txtCorreoC.Clear();
                cbxempresa.ResetText();

            }
        catch (Exception Advertencia)
            {
                MessageBox.Show("Error" + Advertencia);
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
                        string sql = "UPDATE centro SET Nombre_centro = '" + txtCentro.Text + "', Direccion ='" + txtDireccion.Text +
                             "', Telefono='" + txtTelefonoC.Text + "', Correo = '" + txtCorreoC.Text +
                             "' WHERE id_Centro='" + id_actualizar + "';";
                        conexion.abrir_coneccion();
                        MySqlCommand cmd = new MySqlCommand(sql, conexion.Realizar_Conexion);
                        MySqlDataReader leer = cmd.ExecuteReader();
                        conexion.cerrar_coneccion();

                    }
                    else
                    {
                        MessageBox.Show("Todos los campos son obligatorios");
                    }
                    conexion.llenarDataGridViewCentro(dtg_Centro, "");
                }
                conexion.llenarDataGridViewCentro(dtg_Centro, "");


            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar " + err);
                conexion.cerrar_coneccion();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string doc = Convert.ToString(dtg_Centro.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show("¿ esta seguro que desea eliminar este archivo de forma permanente?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                conexion.abrir_coneccion();

                string Sql_borrar = " DELETE FROM centro" +
                                 " WHERE id_Centro = ('" + doc + "');";
                MySqlCommand CMD = new MySqlCommand(Sql_borrar, conexion.Realizar_Conexion);
                CMD.ExecuteNonQuery();
                conexion.cerrar_coneccion();
                conexion.llenarDataGridViewCentro(dtg_Centro,"");
            }
            else if (result == DialogResult.No)
            {
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCentro.Clear();
            txtDireccion.Clear();
            txtTelefonoC.Clear();
            txtCorreoC.Clear();
            btnGuardar.Enabled = true;
            btnBorrar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnActualizar.Enabled = true;
            cbxempresa.ResetText();
        }


       

        private void dtg_Centro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_actualizar = Convert.ToString(dtg_Centro.CurrentRow.Cells[0].Value);
            string centro = Convert.ToString(dtg_Centro.CurrentRow.Cells[1].Value);
            txtCentro.Text = centro;
            txtDireccion.Text = Convert.ToString(dtg_Centro.CurrentRow.Cells[2].Value);
            txtTelefonoC.Text = Convert.ToString(dtg_Centro.CurrentRow.Cells[3].Value);
            txtCorreoC.Text = Convert.ToString(dtg_Centro.CurrentRow.Cells[4].Value);
            // llenar combo regional     

            try
            {
                conexion.abrir_coneccion();
                string sql = "SELECT regional.Nombre_regional FROM centro " +
                        "INNER JOIN regional ON centro.id_Regional = regional.id_Regional " +
                        "WHERE Nombre_centro LIKE '%" + centro + "%' ";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.Realizar_Conexion);
                MySqlDataReader leer = cmd.ExecuteReader();
                string empresa = "";
                while (leer.Read())
                {
                    empresa = leer["Nombre_regional"].ToString();

                }
                conexion.cerrar_coneccion();
                cbxempresa.Text = empresa;
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar " + err);
                conexion.cerrar_coneccion();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regional t1 = new Regional();
            t1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 cantidad_tipo = Convert.ToInt32(comboBox_buscar.Text.Length);
                Int32 cantidad_dato = Convert.ToInt32(textBox2.Text.Length);
                string sql_complemento = "";
                if (!comboBox_buscar.Text.Equals("") && !textBox2.Text.Equals(""))
                {
                    
                    conexion.abrir_coneccion();
                    string sql_buscar_dato = "SELECT id FROM centrodos WHERE  centro ='" + comboBox_buscar.Text + "'";
                    MySqlCommand mycomando = new MySqlCommand(sql_buscar_dato, conexion.Realizar_Conexion);
                    string dato_encontrado = Convert.ToString(mycomando.ExecuteScalar());
                    conexion.cerrar_coneccion();
                    int p = 0;
                    switch (dato_encontrado)
                    {
                        case "1":
                            sql_complemento = " WHERE Nombre_centro  LIKE '%" + textBox2.Text + "%' ";
                       p= conexion.llenarDataGridViewCentro(dtg_Centro, sql_complemento); ////
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

        private void Centro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtDatoBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCentro_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.txtCentro, "INGRESE CENTRO ");
            ToolTip1.SetToolTip(this.txtDireccion, "INGRESE DIRECCION ");
            ToolTip1.SetToolTip(this.txtTelefonoC, "INGRESE TELEFONO ");
            ToolTip1.SetToolTip(this.txtCorreoC, "INGRESE CORREO ");
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoC_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCorreoC_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxempresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefonoC_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.solonumeros(e);
        }

        private void txtCentro_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.sololetras(e);
        }
    }
}

