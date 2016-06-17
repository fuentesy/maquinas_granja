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
    public partial class Horas_maquina : Form
    {
        Conexion conexion = new Conexion();

        public Horas_maquina()
        {
            InitializeComponent();
            conexion.llenar_Maquina(cmbmaquina);
            conexion.llenar_Usuario(cmboperario);
            

            cmbmaquina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboperario.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Horas_maquina_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir_coneccion();

                string Query_insert = " insert into horas_maquina (Nombre_trabajo, Fecha_trabajo, Horometro, Hora_salida, Hora_llegada, Total_horas, id_Maquina,  id_Usuario)" +
                                      " VALUES ('" + txttrabajo.Text + "' , '" + txtfecha.Text + "' , '" + txthorometro.Text + "' , '" + txtsalida.Text + "' , '" + txtllegada.Text + "' , '" + txttotal_horas.Text + "' , '" + txtId_maquinaa.Text + "' , '" + txtid_operario.Text + "');";
                MySqlCommand datos_requeridos = new MySqlCommand(Query_insert, conexion.Realizar_Conexion);
                datos_requeridos.ExecuteNonQuery(); 
                conexion.cerrar_coneccion();
                MessageBox.Show(" la operacion se realizo satisfactoriamente  ");
            }

            catch (Exception err)
            {
                MessageBox.Show(" error " + err, " mensaje del sistema ");
            }

        }

        private void dateTimePickerfechatraba_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerfechatraba_ValueChanged(object sender, EventArgs e)
        {
            txtfecha.Text = dateTimePickerfechatraba.Text;
            string dt = txtfecha.Text;
            DateTime myDatetime = DateTime.Parse(dt);
            string dia = Convert.ToString(myDatetime.Day);
            string mes = Convert.ToString(myDatetime.Month);
            string ano = Convert.ToString(myDatetime.Year);
            txtfecha.Text = ano + "/" + mes + "/" + dia;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

         /*   try
            {
                DialogResult valor;
                valor = MessageBox.Show("Esta seguro que desea eliminar este archivo?", " pregunta del servidor ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (valor == DialogResult.Yes)
                {
                    conexion.abrir_coneccion();
                    string SQL_consulta_eliminar = "DELETE FROM horas_maquina" +
                                                   "WHERE id_Horas_maquina = ('" + horas_maquina + "');";
                    MySqlCommand CMD = new MySqlCommand(SQL_consulta_eliminar, conexion.realizar_conexion);
                    CMD.ExecuteNonQuery();
                    conexion.cerrar_coneccion();

                    txttrabajo.Clear();
                    txthorometro.Clear();
                    txtsalida.Clear();
                    txtllegada.Clear();
                    txttotal_horas.Clear();
                    cmbmaquina.ResetText();
                    cmbcombustible.ResetText();
                    cmboperario.ResetText();
                }
            }*/
        }
    

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir_coneccion();
                string SQL_UPDATE = "UPDATE horas_maquina" +
                                    " SET Nombre_trabajo=('" + txttrabajo.Text + "') " +
                                    " Fecha_trabajo=('" + txtfecha.Text + "') " +
                                    " Horometro=('" + txthorometro.Text + "') " +
                                    " Hora_salida=('" + txtsalida.Text + "') " +
                                    " Hora_llegada=('" + txtllegada.Text + "') " +
                                    " Total_horas=('" + txttotal_horas + "') " +
                                    " id_Maquina=('" + cmbmaquina.Text + "') " +
                                   
                                    " id_Usuario=('" + cmboperario.Text + "') " +
                                    " WHERE id_Horas_maquina=('" + txtId_maquinaa.Text + "') ";
                MySqlCommand Mycomando = new MySqlCommand(SQL_UPDATE, conexion.Realizar_Conexion);
                Mycomando.ExecuteScalar();
                conexion.cerrar_coneccion();
                txttrabajo.Clear();
                txthorometro.Clear();
                txtsalida.Clear();
                txtllegada.Clear();
                txttotal_horas.Clear();
                cmbmaquina.ResetText();
               
                cmboperario.ResetText();

                MessageBox.Show("se actualizaron datos", " mesaje con exito");
            }
            catch (Exception err)
            {
                MessageBox.Show("error al actualizar" + err);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txttrabajo.Clear();
            txthorometro.Clear();
            txtsalida.Clear();
            txtllegada.Clear();
            txttotal_horas.Clear();
            cmbmaquina.ResetText();
           
            cmboperario.ResetText();
        }

        private void cmbmaquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir_coneccion();
                string maquinav = cmbmaquina.Text;
                string sql_buscar_datos = "select id_Maquina FROM maquina WHERE Serie = ('"+ cmbmaquina.Text +"')";
                MySqlCommand mycomando = new MySqlCommand(sql_buscar_datos, conexion.Realizar_Conexion);
                string dato_encontrado = System.Convert.ToString(mycomando.ExecuteScalar());
                txtId_maquinaa.Text = Convert.ToString(dato_encontrado);
                conexion.cerrar_coneccion();
            }

            catch (Exception err)
            {
                MessageBox.Show("error del sistema" + err);
            }
        }



        private void cmboperario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir_coneccion();
                string opereriov = cmboperario.Text;
                string sql_buscar_dato = "select id_Usuario FROM usuario WHERE Nombres = ('" + cmboperario.Text + "')";
                MySqlCommand mycomando = new MySqlCommand(sql_buscar_dato, conexion.Realizar_Conexion);
                string dato_encontrado = System.Convert.ToString(mycomando.ExecuteScalar());
                txtid_operario.Text = Convert.ToString(dato_encontrado);
                conexion.cerrar_coneccion();
            }

            catch (Exception err)
            {
                MessageBox.Show("error del sistema" + err);
            }

        }

    }
}
