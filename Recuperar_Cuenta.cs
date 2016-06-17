using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MAQUINAS_GRANJA
{
    public partial class Recuperar_Cuenta : Form
    {
        Conexion conexion = new Conexion();

        public Recuperar_Cuenta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string clave = "";
                clave = generarClave();
                conexion.abrir_coneccion();
                string sql = "UPDATE usuario SET clave = '" + clave + "'  WHERE correo = '" + txtrecuperac.Text + "';";
                MySqlCommand cmd = new MySqlCommand(sql, conexion.Realizar_Conexion);
                MySqlDataReader read = cmd.ExecuteReader();
                conexion.cerrar_coneccion();

                string msg = "SIM - Sistema de informacion de la maquinaria SENA \n" +
                             "Hola " + txtrecuperac.Text + " \n" +
                             "Se ha cambiado tu contraseña, esta es tu nueva contraseña. \n" +
                             "Contraseña = " + clave;

                if (ComprobarFormatoEmail(txtrecuperac.Text))
                {
                    CCorreo envioCorreo = new CCorreo(txtrecuperac.Text, "Nueva Contraseña", msg);
                    if (envioCorreo.Estado)
                    {
                        MessageBox.Show("Enviado Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Fallo Correo");

                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un correo valido");

                }

                txtrecuperac.Clear();

            }
            catch (Exception error)
            {
                MessageBox.Show("Error " + error);
                conexion.cerrar_coneccion();
            }

            
        }

        public static bool ComprobarFormatoEmail(string sEmailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(sEmailAComprobar, sFormato))
            {
                if (Regex.Replace(sEmailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private string generarClave()
        {
            string Caracteres = @"1234567890qwertyuiopaslñzxcvbnmQWERTYPÑLKJHGFDSXCVBNM_-.@";
            Random Rnd = new Random();
            StringBuilder SB = new StringBuilder();
            char CH;

            for (int i = 1; i <= 10; i++)
            {
                CH = Caracteres[Rnd.Next(0, Caracteres.Length)];
                SB.Append(CH);
            }

            return SB.ToString();
        }

        private void txtrecuperac_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.txtrecuperac, "INGRESE CORREO ELECTRONICO ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fondo f1 = new Fondo();
            f1.Show();
        }
        /*
private void EnviarCorreo()
{
SmtpClient ServidorSmtp = new SmtpClient("smtp-mail.outlook.com", 587);
ServidorSmtp.EnableSsl = true;
ServidorSmtp.UseDefaultCredentials = false;

ServidorSmtp.Credentials = new System.Net.NetworkCredential("yuranyfuentes2013@hotmail.com", "mamasita2013");

MailMessage Correo = new MailMessage();
MailAddress Remitente = new MailAddress("yuranyfuentes2013@hotmail.com");
Correo.From = Remitente;
Correo.Subject = "Nueva Contraseña";
Correo.To.Add("yfuentes50@misena.edu.co");
Correo.Body = "Usuario: este";

try {
ServidorSmtp.Send(Correo);
}catch(Exception e)
{
Console.Write(e);
}

}*/
    }
}
