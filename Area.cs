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
    public partial class Area : Form

    {
        
        Conexion conexion = new Conexion();
        private string id_actualizar = "";
        public Area()
        {
            InitializeComponent();
            conexion.llenar_centro(cmbBox_Centro);
            conexion.llenarDataGridViewArea(dtg_Area,"");
            conexion.llenar_busquedaArea(comboBox_buscar);
        }

        private bool verificar_campos()
        {
            if (!txtArea.Text.Equals("") &&
                   !cmbBox_Centro.Text.Equals(""))


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

                string sql_consultar_Centro = "SELECT count(Nombre_Area)" +
                                 " FROM area" +
                                 " WHERE Nombre_Area=('" + txtArea.Text + "');";
                MySqlCommand valores = new MySqlCommand(sql_consultar_Centro, conexion.Realizar_Conexion);
                Int32 total_registros_encontrados = System.Convert.ToInt32(valores.ExecuteScalar());



                if (total_registros_encontrados > 0)
                {
                    MessageBox.Show(" El area ya existe!!");
                    txtArea.Focus();
                }

                else
                {
                    int id_centro = cmbBox_Centro.SelectedIndex + 1;
                    String SQL_insert = " INSERT INTO area (Nombre_Area, id_Centro)" +
                                        " VALUES ('" + txtArea.Text + "','" + id_centro + "')";
                    MySqlCommand datos_requeridos = new MySqlCommand(SQL_insert, conexion.Realizar_Conexion);
                    datos_requeridos.ExecuteNonQuery();
                    MessageBox.Show(" SE GUARDO CON EXITO!!");

                }

                conexion.cerrar_coneccion();
            }
             else {
                MessageBox.Show("ingrese todos los campos", "Error");

            }


                txtArea.Clear();
                cmbBox_Centro.ResetText();

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
                        string sql = "UPDATE area SET Nombre_area = '" + txtArea.Text  +
                            "' WHERE id_Area='" + id_actualizar + "';";
                        conexion.abrir_coneccion();
                        MySqlCommand cmd = new MySqlCommand(sql, conexion.Realizar_Conexion);
                        MySqlDataReader leer = cmd.ExecuteReader();
                        conexion.cerrar_coneccion();

                    }
                    else
                    {
                        MessageBox.Show("Todos los campos son obligatorios");
                    }
                    conexion.llenarDataGridViewArea(dtg_Area, "");
                }

                conexion.llenarDataGridViewArea(dtg_Area, "");


            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar " + err);
                conexion.cerrar_coneccion();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string doc = Convert.ToString(dtg_Area.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show("¿ esta seguro que desea eliminar este archivo de forma permanente?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                conexion.abrir_coneccion();

                string Sql_borrar = " DELETE FROM area" +
                                 " WHERE id_Area = ('" + doc + "');";
                MySqlCommand CMD = new MySqlCommand(Sql_borrar, conexion.Realizar_Conexion);
                CMD.ExecuteNonQuery();
                conexion.cerrar_coneccion();
                conexion.llenarDataGridViewArea(dtg_Area,"");
            }
            else if (result == DialogResult.No)
            {
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtArea.Clear();

            button5.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;
            cmbBox_Centro.ResetText();
        }

      

        private void dtg_Area_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_actualizar = Convert.ToString(dtg_Area.CurrentRow.Cells[0].Value);
           
            /// falta aqui llenar combo centro
            /// 
            string area = Convert.ToString(dtg_Area.CurrentRow.Cells[1].Value);
            txtArea.Text = area;

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
                cmbBox_Centro.Text = centro;
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar " + err);
                conexion.cerrar_coneccion();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Centro t1 = new Centro();
            t1.Show();
        }

        private void dtg_Area_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 cantidad_tipo = Convert.ToInt32(comboBox_buscar.Text.Length);
                Int32 cantidad_dato = Convert.ToInt32(txtDatoBuscar.Text.Length);
                string sql_complemento = "";
                if (!comboBox_buscar.Text.Equals("") && !txtDatoBuscar.Text.Equals(""))
                {
                    //Int16 buscar_datico = Convert.ToInt16(txtDato_Buscar.Text);
                    conexion.abrir_coneccion();
                    string sql_buscar_dato = "SELECT id FROM areados WHERE  area ='" + comboBox_buscar.Text + "'";
                    MySqlCommand mycomando = new MySqlCommand(sql_buscar_dato, conexion.Realizar_Conexion);
                    string dato_encontrado = Convert.ToString(mycomando.ExecuteScalar());
                    conexion.cerrar_coneccion();
                    int p = 0;
                    switch (dato_encontrado)
                    {
                        case "1":
                            sql_complemento = " WHERE Nombre_area   LIKE '%" + txtDatoBuscar.Text + "%' ";
                          p =  conexion.llenarDataGridViewArea(dtg_Area, sql_complemento);
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

        private void Area_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.txtArea, "INGRESE AREA ");

        }

        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.sololetras(e);
        }
    }
}
