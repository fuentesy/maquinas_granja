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
    public partial class Factura : Form
    {
        Conexion conexion = new Conexion();
        public Factura()
        {
            InitializeComponent();
            conexion.llenar_Mantenimiento(cbxid_Mantenimirnto);
            conexion.llenar_Proveedores(cbxproveedores);
            conexion.llenarDataGridViewFactura(dtg_Factura);
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir_coneccion();

                int id_Proveedores, id_Mantenimiento;
                id_Proveedores = cbxproveedores.SelectedIndex + 1;
                id_Mantenimiento = cbxid_Mantenimirnto.SelectedIndex + 1;

                string Sql_consultar_iden = " SELECT count(Nit)" +
                                            "FROM factura" +
                                            " WHERE Nit = ('" + txt_Nit.Text + "');";
                MySqlCommand valores = new MySqlCommand(Sql_consultar_iden, conexion.Realizar_Conexion);
                Int32 total_registros_encontrados = System.Convert.ToInt32(valores.ExecuteScalar());
                if (total_registros_encontrados > 0)
                {
                    MessageBox.Show(" EL NIT INGRESADO YA EXISTE !!");
                    txt_Nit.Focus();
                }

                else
                {
                    string Sql_consultar_telefono = " SELECT count(Telefono) " +
                                        "FROM factura" +
                                        " WHERE Telefono = ('" + txt_Telefono.Text + "');";
                    MySqlCommand telefo = new MySqlCommand(Sql_consultar_telefono, conexion.Realizar_Conexion);
                    total_registros_encontrados = System.Convert.ToInt32(telefo.ExecuteScalar());
                    if (total_registros_encontrados > 0)
                    {
                        MessageBox.Show(" EL TELEFONO DIGITADO  YA EXISTE !!");
                        txt_Telefono.Focus();
                    }

                    else
                    {
                        string Sql_consultar_direccion = " SELECT count(Direccion) " +
                                            "FROM factura" +
                                            " WHERE Direccion = ('" + txt_Direccion.Text + "');";
                        MySqlCommand val = new MySqlCommand(Sql_consultar_direccion, conexion.Realizar_Conexion);
                        total_registros_encontrados = System.Convert.ToInt32(val.ExecuteScalar());
                        if (total_registros_encontrados > 0)
                        {
                            MessageBox.Show(" LA DIRECCION INGRESADA  YA EXISTE !!"); //se ingresa derecho no se espera para cambiarla
                            txt_Direccion.Focus();
                        }
                        else {
                            String SQL_insert = "INSERT INTO factura (Factura, Nit,  Cliente, Fecha, Telefono, Direccion, id_Proveedores, id_Mantenimiento)" +
                                             " VALUES ('" + txt_Factura.Text + "', '" + txt_Nit.Text +
                                             "', '" + txt_Cliente.Text + "', '" + dateTimePickerFecha_M.Text + "', '" +
                                             txt_Telefono.Text + "', '" + txt_Direccion.Text + "', '" + id_Proveedores + "', '" + id_Mantenimiento + "')";
                            MySqlCommand datos_requeridos = new MySqlCommand(SQL_insert, conexion.Realizar_Conexion);
                            datos_requeridos.ExecuteNonQuery();
                            MessageBox.Show(" SE CONECTO CON EXITO!!");
                        }
                    }
                }

                conexion.cerrar_coneccion();
            }
             
            catch (Exception err)
            {

                MessageBox.Show("error" + err, "MENSAJE DEL SISTEMA");
                conexion.cerrar_coneccion();
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conexion.llenarDataGridViewFactura(dtg_Factura);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string fac = Convert.ToString(dtg_Factura.CurrentRow.Cells[0].Value);

            DialogResult result = MessageBox.Show("¿ esta seguro que desea eliminar este archivo de forma permanente?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                conexion.abrir_coneccion();

                string Sql_borrar = " DELETE FROM factura" +
                                 " WHERE id_Factura = ('" + fac + "');";
                MySqlCommand CMD = new MySqlCommand(Sql_borrar, conexion.Realizar_Conexion);
                CMD.ExecuteNonQuery();
                conexion.cerrar_coneccion();
                conexion.llenarDataGridViewFactura(dtg_Factura);
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void dtg_Factura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Factura.Text = Convert.ToString(dtg_Factura.CurrentRow.Cells[1].Value);
            txt_Nit.Text = Convert.ToString(dtg_Factura.CurrentRow.Cells[2].Value);
            txt_Cliente.Text = Convert.ToString(dtg_Factura.CurrentRow.Cells[3].Value);
            dateTimePickerFecha_M.Text = Convert.ToString(dtg_Factura.CurrentRow.Cells[4].Value);
            txt_Telefono.Text = Convert.ToString(dtg_Factura.CurrentRow.Cells[5].Value);
            txt_Direccion.Text = Convert.ToString(dtg_Factura.CurrentRow.Cells[6].Value);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_Factura.Focus();
            txt_Nit.Clear();
            txt_Cliente.Clear();
            txt_Telefono.Clear();
            txt_Direccion.Clear();
            btnActualizar.Enabled = true;
            btnBorrar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proveedores t3 = new Proveedores();
            t3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cbxproveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            string nit = txt_Nit.Text;
            string fecha = dateTimePickerFecha_M.Text;

            conexion.abrir_coneccion();

            string SQL_Buscar = "SELECT * FROM factura WHERE Nit=('" + nit + "') OR Fecha=('" + fecha + "');";

            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_Buscar, conexion.Realizar_Conexion);

            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            dtg_Factura.DataSource = registros_encontrados.Tables[0];

            conexion.cerrar_coneccion();
        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFecha_M_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
