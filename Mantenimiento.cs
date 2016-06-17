using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace MAQUINAS_GRANJA
{
    public partial class Mantenimiento : Form
    {
        Conexion conexion = new Conexion();

        public Mantenimiento()
        {
            InitializeComponent();
            conexion.llenar_t_mantenimiento(comboBoxTipoM);            
            conexion.llenar_Maquina(comboMaquinaM);

            comboBoxTipoM.DropDownStyle = ComboBoxStyle.DropDownList;
            comboMaquinaM.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void llenar_maquina(String dato_complemento)
        {
            try
            {
                conexion.abrir_coneccion();

                string SQL_TIPO = " SELECT " +
                                    "  mantenimiento.id_Mantenimiento,mantenimiento.Fecha_mant, " +
                                    "  mantenimiento.Descripcion_mantenimiento, " +
                                    "  mantenimiento.Recomendaciones_mantenimiento, " +
                                    "  tipo_mantenimiento.id_Tipo_mantenimiento, " +
                                    " detalle_mantenimiento.id_Detalle_mantenimiento,maquina.id_Maquina " +
                                    " FROM " +
                                    " mantenimiento INNER JOIN " +
                                    " tipo_mantenimiento ON tipo_mantenimiento.id_Tipo_mantenimiento = " +
                                    " mantenimiento.id_Tipo_mantenimiento INNER JOIN " +
                                    " detalle_mantenimiento ON detalle_mantenimiento.id_Detalle_mantenimiento " +
                                    "   = mantenimiento.id_Detalle_mantenimiento INNER JOIN " +
                                    " maquina ON maquina.id_Maquina = mantenimiento.id_Maquina  " +
                                    " " + dato_complemento + " ";
            }

            catch (Exception err)
            {
                MessageBox.Show("error", "mensaje del sistema" + err);

            }
        }

        private void buttonGuardarM_Click(object sender, EventArgs e)
            {
            try
            {
                conexion.abrir_coneccion(); 
                string Query_insert = " INSERT INTO  mantenimiento, detalle_mantenimiento (Fecha_mant, Descripcion_mantenimiento, Recomendaciones_mantenimiento, id_Tipo_mantenimiento ,id_Detalle_mantenimiento, id_Maquina)"+
                                        "VALUES('" + txtfecha22.Text + "' , '" + textDescripcionM.Text + "' , '" + textRecomendacionesM.Text + "' , '" + txtid_mantenimiento.Text + "' , '" + txtid_maquina.Text + "');";
                MySqlCommand datos_requeridos = new MySqlCommand(Query_insert, conexion.Realizar_Conexion);
                datos_requeridos.ExecuteNonQuery();
                conexion.cerrar_coneccion();

                MessageBox.Show(" La operacion se realizo satisfactoriamente ");                

            }

              

            catch (Exception err)
            {
                MessageBox.Show("error" , "mensaje del sistema" + err);

            }

        }

        private void buttonActualizarM_Click(object sender, EventArgs e)
        {
            conexion.llenarDataGridViewMatenimiento(dataGridViewMantenimiento);
        }

        private void dataGridViewMantenimiento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dateTimePickerMant.Text = Convert.ToString(dataGridViewMantenimiento.CurrentRow.Cells[1].Value);
            textDescripcionM.Text = Convert.ToString(dataGridViewMantenimiento.CurrentRow.Cells[2].Value);
            textRecomendacionesM.Text = Convert.ToString(dataGridViewMantenimiento.CurrentRow.Cells[3].Value);
            txtid_mantenimiento.Text = Convert.ToString(dataGridViewMantenimiento.CurrentRow.Cells[4].Value);
            comboBoxTipoM.Text = Convert.ToString(dataGridViewMantenimiento.CurrentRow.Cells[5].Value);            
            comboMaquinaM.Text = Convert.ToString(dataGridViewMantenimiento.CurrentRow.Cells[6].Value);
            

            buttonGuardarM.Enabled = false;//se bloquea 
            buttonBorrarM.Enabled = true;//se activa
            buttonActualizarM.Enabled = true;//se activa
        }

        private void buttonLimpiarM_Click(object sender, EventArgs e)
        {
            textDescripcionM.Clear();
            textRecomendacionesM.Clear();
            txtid_mantenimiento.Clear();
            comboBoxTipoM.Items.Clear();            
            comboMaquinaM.Items.Clear();
            
            buttonGuardarM.Enabled = true;
            buttonBuscarM.Enabled = true;
            buttonBorrarM.Enabled = true;
            buttonActualizarM.Enabled = true;
        }

        private void buttonBorrarM_Click(object sender, EventArgs e)
        {
            string mantenimiento = Convert.ToString(dataGridViewMantenimiento.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show("¿ esta seguro que desea eliminar este archivo de forma permanente?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                conexion.abrir_coneccion();

                string Sql_borrar = " DELETE FROM mantenimiento" +
                                 " WHERE id_Mantenimiento = ('" + mantenimiento + "');";
                MySqlCommand CMD = new MySqlCommand(Sql_borrar, conexion.Realizar_Conexion);
                CMD.ExecuteNonQuery();
                conexion.cerrar_coneccion();
                conexion.llenarDataGridViewMatenimiento(dataGridViewMantenimiento);
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void comboBoxTipoM_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir_coneccion();
                string nommant = comboBoxTipoM.Text;
                string sql_buscar_datos = "select id_Tipo_mantenimiento FROM tipo_mantenimiento WHERE Nombre_mantenimiento = ('" + comboBoxTipoM.Text + "')";
                MySqlCommand mycomando = new MySqlCommand(sql_buscar_datos, conexion.Realizar_Conexion);
                string dato_encontrado = System.Convert.ToString(mycomando.ExecuteScalar());
                txtid_mantenimiento.Text = Convert.ToString(dato_encontrado);
                conexion.cerrar_coneccion();                
            }
            catch (Exception err)
            {
             MessageBox.Show ("error del sistema" + err);
            }

        }
        private void comboMaquinaM_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir_coneccion();
                string maq = comboMaquinaM.Text;
                string sql_bucar_maquina = "select id_Maquina FROM maquina WHERE Serie = ('" + comboMaquinaM.Text + "')";
                MySqlCommand mycomando = new MySqlCommand(sql_bucar_maquina, conexion.Realizar_Conexion);
                string dato_encontrado = System.Convert.ToString(mycomando.ExecuteScalar());
                txtid_maquina.Text = Convert.ToString(dato_encontrado);
                conexion.cerrar_coneccion();
            }
            catch (Exception err)
            {
                MessageBox.Show("error" + err, "mensaje del servidor");
            }
        }


        private void dateTimePickerMant_ValueChanged(object sender, EventArgs e)
        {
            txtfecha22.Text = dateTimePickerMant.Text;
            string dt = txtfecha22.Text;
            DateTime myDateTime = DateTime.Parse(dt);
            string dia = Convert.ToString(myDateTime.Day);
            string mes = Convert.ToString(myDateTime.Month);
            string ano = Convert.ToString(myDateTime.Year);
            txtfecha22.Text = ano + "/" + mes + "/" + dia;
        }

        private void txtDetalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void btnreoaracion_Click(object sender, EventArgs e)
        {
            Detalle_matenimiento dtm = new Detalle_matenimiento();
            dtm.Show();
        }

        private void txtid_mantenimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtmaquina_TextChanged(object sender, EventArgs e)
        {

        }
    }
}