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
    public partial class Registro : Form
    {
        Conexion conexion = new Conexion();
        private string id_actualizar=""; //variable global

        public Registro()
        {
            InitializeComponent();
            conexion.llenar_tipo_documento(cboxTipo_Documento);
//          conexion.llenar_Area(cboxArea, txt_Centro.Text);
            conexion.llenar_Genero(cboxGenero);
            conexion.llenar_Rol(cboxRol);
            conexion.llenar_centro(cbxCentro);
            conexion.llenarDataGridViewUsuario(dtg_Usuario,"");
            conexion.llenar_tipo_busqueda(comboBox_buscar);

        }

      
        private bool verificar_campos()
        {
            if (!txtNumeroDoc.Text.Equals("") &&
                    !cboxTipo_Documento.Text.Equals("") &&
                    !txtNombres.Text.Equals("") &&
                    !txtPrimerAp.Text.Equals("") &&
                    
                    !cboxGenero.Text.Equals("") &&
                    !txtTelefono.Text.Equals("") &&
                    !txtCorreo.Text.Equals("") &&
                    !txtDireccion.Text.Equals("") &&
                    !cboxArea.Text.Equals("") &&
                    !cbxCentro.Text.Equals("") &&
                    !cboxRol.Text.Equals("") &&
                    !txtClave.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificar_campos())
                {
                    conexion.abrir_coneccion();

                    string Sql_consultar_iden = " SELECT count(Numero_Doc)" +
                                            "FROM Usuario" +
                                            " WHERE Numero_Doc = ('" + txtNumeroDoc.Text + "');";
                    MySqlCommand valores = new MySqlCommand(Sql_consultar_iden, conexion.Realizar_Conexion);
                    Int32 total_registros_encontrados = System.Convert.ToInt32(valores.ExecuteScalar());
                    if (total_registros_encontrados > 0)
                    {
                        MessageBox.Show(" EL NUMERO DE IDENTIFICACION YA EXISTE !!");
                        txtNumeroDoc.Focus();
                    }

                    else
                    {
                        string Sql_consultar_codigo = " SELECT count(Telefono) " +
                                            "FROM usuario" +
                                            " WHERE Telefono = ('" + txtTelefono.Text + "');";
                        MySqlCommand val = new MySqlCommand(Sql_consultar_codigo, conexion.Realizar_Conexion);
                        total_registros_encontrados = System.Convert.ToInt32(val.ExecuteScalar());
                        if (total_registros_encontrados > 0)
                        {
                            MessageBox.Show(" EL TELEFONO DIGITADO  YA EXISTE !!");
                            txtTelefono.Focus();
                        }

                        else
                        {
                            string Sql_consultar_email = " SELECT count(Correo) " +
                                                "FROM Usuario" +
                                                " WHERE Correo = ('" + txtCorreo.Text + "');";
                            MySqlCommand valor = new MySqlCommand(Sql_consultar_email, conexion.Realizar_Conexion);
                            total_registros_encontrados = System.Convert.ToInt32(valor.ExecuteScalar());
                            if (total_registros_encontrados > 0)
                            {
                                MessageBox.Show(" EL CORREO DIGITADO  YA EXISTE !!");
                                txtCorreo.Focus();
                            }

                            else
                            {

                                int id_tipo_doc, id_rol, id_genero, id_area;
                                id_tipo_doc = cboxTipo_Documento.SelectedIndex + 1;
                                id_rol = cboxRol.SelectedIndex + 1;
                                id_genero = cboxGenero.SelectedIndex + 1;
                                id_area = cboxArea.SelectedIndex + 1;

                                String SQL_insert = " INSERT INTO Usuario (Nombres, Primer_Apellido, Segundo_Apellido,  Telefono, " +
                                                    "Direccion, Numero_doc,Correo, Clave, id_Tipo_documento,id_Rol, id_Genero, id_Area ) " +
                                                    " VALUES ('" + txtNombres.Text + "','" + txtPrimerAp.Text + "', '" + txtSegundoAp.Text +
                                                    "', '" + txtTelefono.Text + "', '" + txtDireccion.Text + "', '" + txtNumeroDoc.Text + "', '" +
                                                    txtCorreo.Text + "', '" + txtClave.Text + "', '" + id_tipo_doc + "', '"
                                                    + id_rol + "', '" + id_genero + "', '" + id_area + "')";
                                MySqlCommand datos_requeridos = new MySqlCommand(SQL_insert, conexion.Realizar_Conexion);
                                datos_requeridos.ExecuteNonQuery();
                                MessageBox.Show(" SE REGISTRO CON EXITO!!");
                            }
                        }
                    }
                    conexion.cerrar_coneccion();
                }
                else {
                    MessageBox.Show("ingrese todos los campos", "Error");

                }

                txtNombres.Clear();
                txtPrimerAp.Clear();
                txtSegundoAp.Clear();
                txtTelefono.Clear();
                txtDireccion.Clear();
                txtNumeroDoc.Clear();
                txtClave.Clear();
                txtCorreo.Clear();
                cboxGenero.ResetText(); // con este no borra los comb desplegabbles el item me los limpia pero los oculta a la hora de volvver a escojer.
                cboxTipo_Documento.ResetText(); 
                cboxArea.ResetText();
                cbxCentro.ResetText();
                cboxRol.ResetText();

            }

            catch (Exception err)
            {

                MessageBox.Show("error" + err, "MENSAJE DEL SISTEMA");
                conexion.cerrar_coneccion();

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtPrimerAp.Clear();
            txtSegundoAp.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtNumeroDoc.Clear();
            txtClave.Clear();
            txtCorreo.Clear();
            cboxGenero.ResetText();
            cboxTipo_Documento.ResetText();
            cboxArea.ResetText();
            cbxCentro.ResetText();
            cboxRol.ResetText();
            btn_registrar.Enabled = true;
            btnBorrar.Enabled = true;
            btnACTUALIZAR.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string doc = Convert.ToString(dtg_Usuario.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show("¿ esta seguro que desea eliminar este archivo de forma permanente?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                conexion.abrir_coneccion();

                string Sql_borrar = "DELETE FROM usuario " +
                                 "WHERE id_Usuario=('" + doc + "');";
                MySqlCommand CMD = new MySqlCommand(Sql_borrar, conexion.Realizar_Conexion);
                CMD.ExecuteNonQuery();
                conexion.cerrar_coneccion();
                conexion.llenarDataGridViewUsuario(dtg_Usuario,"");
            }
            else if (result == DialogResult.No)
            {
            }

        }

        private void btnACTUALIZAR_Click(object sender, EventArgs e) 
        {
            try
            {
                if (!id_actualizar.Equals("")) // no me actualiza coorreo me pone cosas raras en direccion
                {
                    if (verificar_campos())
                    {
                        string sql = "UPDATE usuario SET Nombres = '" + txtNombres.Text + "', Primer_Apellido ='" + txtPrimerAp.Text +
                            "', Segundo_Apellido='" + txtSegundoAp.Text + "', Telefono = '" + txtTelefono.Text + "', Direccion ='" + txtDireccion.Text +
                            "', Numero_doc='" + txtNumeroDoc.Text + "', Correo ='" + txtCorreo.Text +
                            "' WHERE id_Usuario='" + id_actualizar + "';";
                        conexion.abrir_coneccion();
                        MySqlCommand cmd = new MySqlCommand(sql, conexion.Realizar_Conexion);
                        MySqlDataReader leer = cmd.ExecuteReader();
                        conexion.cerrar_coneccion();

                    }
                    else
                    {
                        MessageBox.Show("Todos los campos son obligatorios");
                    }
                    conexion.llenarDataGridViewUsuario(dtg_Usuario, "");
                }

                conexion.llenarDataGridViewUsuario(dtg_Usuario, "");


            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar " + err);
                conexion.cerrar_coneccion();
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
                    string sql_buscar_dato = "SELECT id FROM id_buscar WHERE  usuarios ='" + comboBox_buscar.Text + "'";
                    MySqlCommand mycomando = new MySqlCommand(sql_buscar_dato, conexion.Realizar_Conexion);
                    string dato_encontrado = Convert.ToString(mycomando.ExecuteScalar());
                    conexion.cerrar_coneccion();
                    int p = 0;
                    switch (dato_encontrado)
                    {
                        case "1":
                            sql_complemento = " WHERE Nombres    LIKE '%" + txtDatoBuscar.Text + "%' ";
                            p= conexion.llenarDataGridViewUsuario(dtg_Usuario, sql_complemento);
                            break;
                        case "2":
                            sql_complemento = " WHERE Primer_apellido LIKE '%" + txtDatoBuscar.Text + "%' ";
                            p= conexion.llenarDataGridViewUsuario(dtg_Usuario, sql_complemento);
                            break;
                        case "3":
                            sql_complemento = " WHERE Segundo_apellido LIKE '%" + txtDatoBuscar.Text + "%' ";
                            p = conexion.llenarDataGridViewUsuario(dtg_Usuario, sql_complemento);
                            break;
                        case "4":
                            sql_complemento = " WHERE Numero_doc LIKE '%" + txtDatoBuscar.Text + "%' ";
                            p = conexion.llenarDataGridViewUsuario(dtg_Usuario, sql_complemento);
                            break;
                    }
                    if (p == 0) {
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

        private void cbxCentro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //cmb.abrir_conexion();
                txt_Centro.Text = cbxCentro.Text;
                cboxArea.Items.Clear();
                conexion.llenar_Area(cboxArea, txt_Centro.Text);
                //cmb.cerrar_conexion();
            }
            catch (Exception err)
            {
                MessageBox.Show("eere", "erer" + err);
            }

        }

        private void txtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.solonumeros(e);
        }
        
        private void dtg_Usuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            id_actualizar = Convert.ToString(dtg_Usuario.CurrentRow.Cells[0].Value);
            txtNombres.Text = Convert.ToString(dtg_Usuario.CurrentRow.Cells[1].Value);
            txtPrimerAp.Text = Convert.ToString(dtg_Usuario.CurrentRow.Cells[2].Value);
            txtSegundoAp.Text = Convert.ToString(dtg_Usuario.CurrentRow.Cells[3].Value);
            txtTelefono.Text = Convert.ToString(dtg_Usuario.CurrentRow.Cells[4].Value);
            txtDireccion.Text = Convert.ToString(dtg_Usuario.CurrentRow.Cells[5].Value);
            txtNumeroDoc.Text = Convert.ToString(dtg_Usuario.CurrentRow.Cells[6].Value);
            txtClave.Text = Convert.ToString(dtg_Usuario.CurrentRow.Cells[7].Value);
            cboxTipo_Documento.Text = Convert.ToString(dtg_Usuario.CurrentRow.Cells[8].Value);
            cboxRol.Text = Convert.ToString(dtg_Usuario.CurrentRow.Cells[9].Value);
            cboxGenero.Text = Convert.ToString(dtg_Usuario.CurrentRow.Cells[10].Value);
            string area = Convert.ToString(dtg_Usuario.CurrentRow.Cells[11].Value);
            
            txtCorreo.Text = Convert.ToString(dtg_Usuario.CurrentRow.Cells[12].Value);


            try
            {
                conexion.abrir_coneccion();
                string sql = "SELECT centro.Nombre_centro FROM area " +
                        "INNER JOIN centro ON area.id_centro = centro.id_centro " +
                        "WHERE Nombre_area LIKE '%" + area + "%' ";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.Realizar_Conexion);
                MySqlDataReader leer = cmd.ExecuteReader();
                string centro = "";
                while (leer.Read())
                {
                    centro = leer["Nombre_centro"].ToString();

                }
                conexion.cerrar_coneccion();
                cbxCentro.Text = centro;
                cboxArea.Text = area;
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar " + err);
                conexion.cerrar_coneccion();
            }

            btn_registrar.Enabled = false;//se bloquea 
            btnBorrar.Enabled = true;//se activa
            btnACTUALIZAR.Enabled = true;//se activa

        }

        private void txtNombres_TextChanged(object sender, System.EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.txtNombres, "INGRESE NOMBRE ");
            ToolTip1.SetToolTip(this.txtNumeroDoc, "INGRESE NUMERO DE DOUMENTO");
            ToolTip1.SetToolTip(this.txtPrimerAp, "INGRESE EL PRIMER APELLIDO");
            ToolTip1.SetToolTip(this.txtSegundoAp, "INGRESE SEGUNDO APELLIDO");
            ToolTip1.SetToolTip(this.txtTelefono, "INGRESE TELEFONO");
            ToolTip1.SetToolTip(this.txtCorreo, "INGRESE CORREO");
            ToolTip1.SetToolTip(this.txtDireccion, "INGRESE DIRECCION");
            
        }
        
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.solonumeros(e);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.sololetras(e);
        }

        private void txtPrimerAp_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.sololetras(e);
        }

        private void txtSegundoAp_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.sololetras(e);
        }
    }
}
