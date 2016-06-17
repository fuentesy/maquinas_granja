using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace MAQUINAS_GRANJA
{
    public partial class Tipo_mantenimiento : Form
    {
        Conexion conexion = new Conexion();
        public Tipo_mantenimiento()
        {
            InitializeComponent();
            conexion.llenar_t_busqueda(comboxbuscarpor);
            conexion.llenar_t_mantenimiento(comboboxnombre_man);
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Tipo_mantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void dtgtipoman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboboxnombre_man.Text = Convert.ToString(dtgtipoman.CurrentRow.Cells[1].Value);


            btnBorrar.Enabled = true;//se activa
            btnActualizar.Enabled = true;//se activa
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if 
                    (comboboxnombre_man.Text.Equals(""))
                {
                    conexion.abrir_coneccion();

                    string sql_consultar_iden = "SELECT Count(Nombre_mantenimiento)" +
                        " FROM tipo_mantenimiento " +
                        " WHERE Nombre_mantenimiento = ('" + comboboxnombre_man.Text + "');";
                    MySqlCommand valor = new MySqlCommand(sql_consultar_iden, conexion.Realizar_Conexion);
                    Int32 total_registros_encontrados = System.Convert.ToInt32(valor.ExecuteScalar());
                    if (total_registros_encontrados > 0)
                    {
                        MessageBox.Show("mantenimiento ya existe");
                        comboboxnombre_man.Focus();
                    }
                    else
                    {
                        string sql_INSERT = "INSERT INTO tipo_mantenimiento (Nombre_mantenimiento )" +
                            "VALUES ( '" + comboboxnombre_man.Text + "');";
                        MySqlCommand datos_requeridos = new MySqlCommand(sql_INSERT, conexion.Realizar_Conexion);
                        datos_requeridos.ExecuteNonQuery();
                        MessageBox.Show("se guardo con exito");

                    }
                    conexion.cerrar_coneccion();
                }
                else
                {
                    MessageBox.Show("ingrese todos los campos");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("error" + err);
                conexion.cerrar_coneccion();
                    
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                conexion.abrir_coneccion();
                string sql_actualizar = "tipo_mantenimiento" +
                    "set tipo_mantenimiento=('" + comboboxnombre_man.Text + "' )" +
                    "WHERE tipo_mantenimiento = ('" + comboboxnombre_man.Text + "');";
                conexion.cerrar_coneccion();
            }
            catch(Exception)
            
            {
                MessageBox.Show("error al actualizar");
            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
           
            }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            comboboxnombre_man.ResetText();
            txtdatobuscar.Clear ();
            btnGuardar.Enabled = true;
            btnBorrar.Enabled = true;
            btnActualizar.Enabled = true;

        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            string Tipo_mantenimiento = comboboxnombre_man.Text;
            conexion.abrir_coneccion();

            string SQL_Buscar = "SELECT * FROM Tipo_mantenimiento WHERE Nombre_mantenimiento=('" + Tipo_mantenimiento + "');";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_Buscar, conexion.Realizar_Conexion);

            DataSet registros_encontrados = new DataSet();
            obtener.Fill(registros_encontrados);
            dtgtipoman.DataSource = registros_encontrados.Tables[0];
            conexion.cerrar_coneccion();
        }
    }
}
