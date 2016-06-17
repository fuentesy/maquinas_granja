using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MAQUINAS_GRANJA
{
    public partial class Login : Form
    {
        Conexion conexion = new Conexion();
        

        public Login()
        {
           
            InitializeComponent();
           // conexion.llenar_Rol(cboxRol);

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string numero_doc = txtNumero_Doc.Text;
              
                conexion.abrir_coneccion();
                string SQL = "SELECT Numero_Doc, Nombres, Primer_Apellido FROM usuario " +
                             "WHERE Numero_Doc=('" + txtNumero_Doc.Text + "') AND " +
                             "Clave=('" + txtContrasena.Text + "');";
                MySqlCommand valores = new MySqlCommand(SQL, conexion.Realizar_Conexion);
                double total_registros_encontrados = System.Convert.ToDouble(valores.ExecuteScalar());
                if (total_registros_encontrados > 0)
                {
                    MySqlDataReader dat = valores.ExecuteReader();
                    string nomb = "";
                    string ap = "";
                    while (dat.Read())
                    {
                        nomb = dat["Nombres"].ToString();
                        ap = dat["Primer_Apellido"].ToString();
                    }

                    //MessageBox.Show("Bienvenido "+nomb +" "+ ap, "informe de conexion");
                     
                    menu m1 = new menu();
                    m1.Show();

                    m1.Visible = true;
                    Visible = false;
                    
                }
                else
                {
                    MessageBox.Show("datos no encontrados", "informe de conexion");
                }
                conexion.cerrar_coneccion();
            }
            catch (Exception error)
            {
                MessageBox.Show("El error es: " + error);
            }
        
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cboxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
