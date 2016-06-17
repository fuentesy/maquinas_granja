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
    public partial class Maquinas : Form
    {

        Conexion conexion = new Conexion();


        public Maquinas()
        {
            InitializeComponent();
            conexion.llenar_Area(comboArea, "");
            conexion.llenar_centro(comboCentro);
            conexion.llenar_Usuario(comboUsu);
            //conexion.llenar_Combustible(cmbBox_combustible);
        }


        private void btnGuardar_M_Click(object sender, EventArgs e)
        {
            try
            {

                conexion.abrir_coneccion();
                string SQL_CONSULTAR = "SELECT count(Serie)" +
                                         "FROM maquina " +
                                         "WHERE Serie=('" + textSerie.Text + "');";
                MySqlCommand valores = new MySqlCommand(SQL_CONSULTAR, conexion.Realizar_Conexion);
                Int32 total_registros_encontrados = System.Convert.ToInt32(valores.ExecuteScalar());
                if (total_registros_encontrados > 0)
                {
                    MessageBox.Show("EL DATO A INSERTAR YA EXISTE");
                    textSerie.Focus();
                }
                else
                {
                    int id_Area, id_Usuario;
                    id_Area = comboArea.SelectedIndex + 1;
                    id_Usuario = comboArea.SelectedIndex + 1;

                    string Query_insert = " INSERT INTO maquina (Serie, Modelo, Potencia, Marca, Observaciones, id_Tipo_mantenimiento, id_Detalle_mantenimiento, id_Maquina) " +
                                           " VALUES('" + textSerie.Text + "' , '" + textModelo.Text + "' , '" + textPotencia.Text + "' , '" + textMarca.Text + "' , '" + textObser.Text + "', '" + id_Area + "', '" + id_Usuario + "');";
                    MySqlCommand datos_requeridos = new MySqlCommand(Query_insert, conexion.Realizar_Conexion);
                    datos_requeridos.ExecuteNonQuery();
                    MessageBox.Show(" La operacion se realizo satisfactoriamente ");
                }
                conexion.cerrar_coneccion();

            }
            catch (Exception err)
            {
                MessageBox.Show("error", "mensaje del sistema" + err);

            }
        }



        private void btnBorrar_M_Click(object sender, EventArgs e)
        {

            string maquina = Convert.ToString(dataGridViewMaquinas.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show("¿ esta seguro que desea eliminar este archivo de forma permanente?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                conexion.abrir_coneccion();

                string Sql_borrar = " DELETE FROM maquina" +
                                 " WHERE id_Maquina = ('" + maquina + "');";
                MySqlCommand CMD = new MySqlCommand(Sql_borrar, conexion.Realizar_Conexion);
                CMD.ExecuteNonQuery();
                conexion.cerrar_coneccion();
                conexion.llenarDataGridViewMaquina(dataGridViewMaquinas);
            }
            else if (result == DialogResult.No)
            {
            }

        }

        private void dataGridViewMaquinas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textSerie.Text = Convert.ToString(dataGridViewMaquinas.CurrentRow.Cells[1].Value);
            textModelo.Text = Convert.ToString(dataGridViewMaquinas.CurrentRow.Cells[2].Value);
            textPotencia.Text = Convert.ToString(dataGridViewMaquinas.CurrentRow.Cells[3].Value);
            textMarca.Text = Convert.ToString(dataGridViewMaquinas.CurrentRow.Cells[4].Value);
            //cmbBox_combustible.Text = Convert.ToString(dataGridViewMaquinas.CurrentRow.Cells[5].Value);
            textObser.Text = Convert.ToString(dataGridViewMaquinas.CurrentRow.Cells[6].Value);


            btnGuardar_M.Enabled = false;//se bloquea 
            btnBorrar_M.Enabled = true;//se activa
            btnActualizar_M.Enabled = true;//se activa
        }

        private void btnActualizar_M_Click(object sender, EventArgs e)
        {
            conexion.llenarDataGridViewMaquina( dataGridViewMaquinas );
        }

        private void btnLimpiar_M_Click(object sender, EventArgs e)
        {
            textSerie.Clear();
            textModelo.Clear();
            textPotencia.Clear();
            //cmbBox_combustible.Items.Clear();
            textObser.Clear();
            btnGuardar_M.Enabled = true;
            btnBuscar_M.Enabled = true;
            btnBorrar_M.Enabled = true;
            btnActualizar_M.Enabled = true;
        }

        private void btnBuscar_M_Click(object sender, EventArgs e)
        {
            string serie = textSerie.Text;
            conexion.abrir_coneccion();

            string SQL_Buscar = "SELECT * FROM maquina WHERE id_Maquina=('" + serie + "');";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_Buscar, conexion.Realizar_Conexion);

            DataSet registros_encontrados = new DataSet();
            obtener.Fill(registros_encontrados);
            dataGridViewMaquinas.DataSource = registros_encontrados.Tables[0];
            conexion.cerrar_coneccion();


        }


        private void comboArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboCentro_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                //cmb.abrir_conexion();
                textCentro.Text = comboCentro.Text;
                comboArea.Items.Clear();
                conexion.llenar_Area(comboArea, textCentro.Text);
                //cmb.cerrar_conexion();
            }
            catch (Exception err)
            {
                MessageBox.Show("error", "error del sistema" + err);
            }

        }



private void dataGridViewMaquinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboUsu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textCentro_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBox_combustible_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

       

