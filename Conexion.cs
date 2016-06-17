using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Collections;


namespace MAQUINAS_GRANJA
{
    public class Conexion
    {
        static String server = " Server = localhost;";
        static String db = " Database = sim_senad;";
        static String usuario = " UID = root;";
        static String clave = " Password = root;";

        static String datos_de_entrada = server + db + usuario + clave;
        public MySqlConnection Realizar_Conexion = new MySqlConnection(datos_de_entrada);
        public MySqlCommand cmd;
        public static MySqlDataReader leer;


        public void abrir_coneccion()
        {
            try { Realizar_Conexion.Open();  }
            catch (Exception err)
            {
                MessageBox.Show("error al cerrrar la coneccion" + err);
            }
        }

        // funcion para cerrar la coneccion db
        public void cerrar_coneccion()
        {
            try{ Realizar_Conexion.Close(); }
            catch (Exception er)
            {
                MessageBox.Show("error al cerrar_conexion " + er);
            }
        }



        

       /* public static int Autentificar(String pDocumento, String pContraseña)
        {
            int resultado = 0;
            SqlConnection Conn = BDComnun.ObtenerCOnexion();

            SqlCommand Comando = new SqlCommand(string.Format("Insert Into usuario(Numero_doc, Clave) Values ('{0}', PwdEncrypt('{1}'))", pDocumento, pContraseña), Conn);

            resultado = Comando.ExecuteNonQuery();

            return resultado;
        }*/



        public void solonumeros(KeyPressEventArgs e)
        {
            try
            {
                //Para obligar a que sólo se introduzcan números 
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                  if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                  if (Char.IsSeparator(e.KeyChar))  
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("errroeorooe" + ex);
            }


        }

        public void sololetras(KeyPressEventArgs e)
        {
            try
            {
                //Para obligar a que sólo se introduzcan números 
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                  if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                  if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("errroeorooe" + ex);
            }


        }

        public void llenar_t_busqueda(ComboBox comboxbuscarpor)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand(" SELECT Tipo_mantenimiento FROM t_busqueda ", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    comboxbuscarpor.Items.Add(leer["tipo_mantenimiento"].ToString());

                }
                Realizar_Conexion.Close();

            }

            catch (Exception err)
            {
                MessageBox.Show("error inseerado" + err);
                Realizar_Conexion.Close();
            }
        }

        public void llenar_tipo_busqueda(ComboBox comboBox_buscar)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT usuarios FROM id_buscar", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    comboBox_buscar.Items.Add(leer["usuarios"].ToString());
                }

                Realizar_Conexion.Close();
            }

            catch (Exception er)
            {
                MessageBox.Show("ERROR INESPERADO" + er, "MENSAJE DEL SERVIDOR");
                Realizar_Conexion.Close();
            }

        }

        public void llenar_busquedaArea(ComboBox comboBox_buscar)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT area FROM areados", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    comboBox_buscar.Items.Add(leer["area"].ToString());
                }

                Realizar_Conexion.Close();
            }

            catch (Exception er)
            {
                MessageBox.Show("ERROR INESPERADO" + er, "MENSAJE DEL SERVIDOR");
                Realizar_Conexion.Close();
            }

        }

        public void llenar_busquedaRegional(ComboBox comboBox_buscar)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT regional FROM regionaldos", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    comboBox_buscar.Items.Add(leer["regional"].ToString());
                }

                Realizar_Conexion.Close();
            }

            catch (Exception er)
            {
                MessageBox.Show("ERROR INESPERADO" + er, "MENSAJE DEL SERVIDOR");
                Realizar_Conexion.Close();
            }

        }

        public void llenar_busquedaCentro(ComboBox comboBox_buscar)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT centro FROM centrodos", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    comboBox_buscar.Items.Add(leer["centro"].ToString());
                }

                Realizar_Conexion.Close();
            }

            catch (Exception er)
            {
                MessageBox.Show("ERROR INESPERADO" + er, "MENSAJE DEL SERVIDOR");
                Realizar_Conexion.Close();
            }

        }


        public void llenar_tipo_documento(ComboBox Tipo_Documento)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT Nombre_Doc FROM tipo_documento", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())       
                {
                    Tipo_Documento.Items.Add(leer["Nombre_Doc"].ToString());
                }
                Realizar_Conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar " + err);
                Realizar_Conexion.Close();
            }
        }

        public void llenar_Rol(ComboBox Rol)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT Nombre_Rol FROM rol", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    Rol.Items.Add(leer["Nombre_Rol"].ToString());
                }
                Realizar_Conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar Rol " + err);
                Realizar_Conexion.Close();
            }
        }

        public void llenar_Genero(ComboBox Genero)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT Genero FROM genero", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    Genero.Items.Add(leer["Genero"].ToString());
                }
                Realizar_Conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar Genero " + err);
                Realizar_Conexion.Close();
            }
        }

        public void llenar_Area(ComboBox Area, string CodCentro)
        {
            try
            {
                abrir_coneccion();
                cmd = new MySqlCommand("SELECT id_Centro FROM centro WHERE Nombre_Centro = ('" + CodCentro + "')", Realizar_Conexion);
                leer = cmd.ExecuteReader();

                string id_C = "";
                while (leer.Read())
                {
                    id_C = leer["id_Centro"].ToString();
                }
                Realizar_Conexion.Close(); // CONSULTAR ID

                abrir_coneccion();
                cmd = new MySqlCommand("SELECT Nombre_area FROM area WHERE id_Centro = ('" + id_C + "')", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    Area.Items.Add(leer["Nombre_area"].ToString()); // CONSULTAR nOMBRE AREA
                }
                Realizar_Conexion.Close();

            }

            catch (Exception err)
            {
                MessageBox.Show("error al ingresar Area " + err);
                Realizar_Conexion.Close();
            }
        }
          
        public void llenar_centro(ComboBox centro)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT Nombre_centro FROM centro", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    centro.Items.Add(leer["Nombre_centro"].ToString());
                }
                Realizar_Conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar Nombre_centro " + err);
                Realizar_Conexion.Close();
            }
        }

        public void llenar_t_mantenimiento(ComboBox mantenimiento)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT Nombre_mantenimiento" +
                    " FROM tipo_mantenimiento ", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    mantenimiento.Items.Add(leer["Nombre_mantenimiento"].ToString());

                }
                Realizar_Conexion.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show("error inserperdo" + err);
                Realizar_Conexion.Close();
            }
        }

        public void llenar_Detalle_Mantenimiento(ComboBox comboBox)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT Fecha_registro FROM Detalle_Mantenimiento", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    comboBox.Items.Add(leer["Fecha_registro"].ToString());
                }
                Realizar_Conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar Detalle_Mantenimiento " + err);
                Realizar_Conexion.Close();
            }
        }

        public void llenar_Factura(ComboBox comboBox)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT Factura FROM factura", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    comboBox.Items.Add(leer["Factura"].ToString());
                }
                Realizar_Conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar Factura " + err);
                Realizar_Conexion.Close();
            }
        }

        public void llenar_Maquina(ComboBox comboBox)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT Serie FROM maquina", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    comboBox.Items.Add(leer["Serie"].ToString());
                }
                Realizar_Conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar Maquina " + err);
                Realizar_Conexion.Open();
            }
        }

        public void llenar_Combustible(ComboBox comboBox)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT Fecha FROM combustible", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    comboBox.Items.Add(leer["Fecha"].ToString());
                }
                Realizar_Conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar Combustible " + err);
                Realizar_Conexion.Close();
            }
        }

        public void llenar_tipo_combustible(ComboBox comboBox)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT Nombre_combustible FROM Nombre_combustible", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    comboBox.Items.Add(leer["Nombre_combustible"].ToString());
                }
                Realizar_Conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar Combustible " + err);
                Realizar_Conexion.Close();
            }
        }

        public void llenar_Usuario(ComboBox comboBox)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT Nombres FROM Usuario", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    comboBox.Items.Add(leer["Nombres"].ToString());
                }
                Realizar_Conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar Usuario " + err);
                Realizar_Conexion.Close();
            }
        }

        public void llenar_Mantenimiento(ComboBox comboBox)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT Descripcion_mantenimiento FROM mantenimiento", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    comboBox.Items.Add(leer["Descripcion_mantenimiento"].ToString());
                }
                Realizar_Conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar Mantenimiento " + err);
                Realizar_Conexion.Close();
            }
        }

        public void llenar_Proveedores(ComboBox comboBox)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT Nombre FROM proveedores", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    comboBox.Items.Add(leer["Nombre"].ToString());
                }
                Realizar_Conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar Proveedor " + err);
                Realizar_Conexion.Close();
            }
        }

        public void llenar_Horas_Maq(ComboBox trabajoM)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT Nombre_Trabajo FROM horas_maquina", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    trabajoM.Items.Add(leer["Nombre_Trabajo"].ToString());
                }
                Realizar_Conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar Horas maquina " + err);
                Realizar_Conexion.Close();
            }
        }

        public void llenar_Regional(ComboBox comboBox)
        {
            try
            {
                Realizar_Conexion.Open();
                cmd = new MySqlCommand("SELECT Nombre_regional FROM regional", Realizar_Conexion);
                leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    comboBox.Items.Add(leer["Nombre_regional"].ToString());
                }
                Realizar_Conexion.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("error al ingresar Regional " + err);
                Realizar_Conexion.Close();
            }
        }

        public int llenarDataGridViewUsuario(DataGridView dataGridView,string dato_complemento)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT usuario.id_Usuario,usuario.Nombres,usuario.Primer_Apellido,usuario.Segundo_Apellido," +
                                  "usuario.Telefono,usuario.Direccion,usuario.Numero_Doc,usuario.Clave," +
                                  "tipo_documento.Nombre_doc,rol.Nombre_rol,genero.Genero,area.Nombre_area,usuario.Correo " +
                          "FROM usuario " +
                          "INNER JOIN tipo_documento ON usuario.id_Tipo_Documento=tipo_documento.id_Tipo_Documento " +
                          "INNER JOIN rol ON usuario.id_Rol=rol.id_Rol  " +
                          "INNER JOIN genero ON usuario.id_Genero=genero.id_Genero " +
                          "INNER JOIN area ON usuario.id_Area=area.id_Area " +
                          " " + dato_complemento + ";";
                                             

            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);
            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            DataTable datos = registros_encontrados.Tables[0];

            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();
            int c = datos.Rows.Count;///// buscar si o esta mns
            return c;
        }

        public int llenarDataGridViewCentro(DataGridView dataGridView,string dato_complemento)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT centro.id_Centro,centro.Nombre_centro,centro.Direccion,centro.Telefono," +
                                  "centro.Correo," +
                                  "regional.Nombre_regional " +
                          "FROM centro " +
                          "INNER JOIN regional ON centro.id_Regional=regional.id_Regional " +
                          " " + dato_complemento + ";";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);

            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            DataTable datos = registros_encontrados.Tables[0];

            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();
            int a = datos.Rows.Count; ///// buscar si o esta mns
            return a;
        }

        public void llenarDataGridView1(DataGridView dataGridView)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT  Combustible, Cantidad, Precio_galon, Precio_total" +
                          " FROM Combustible";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);

            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();

        }

        public int llenarDataGridViewArea(DataGridView dataGridView,string dato_complemento)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT area.id_Area,area.Nombre_area,centro.Nombre_centro" +
                          " FROM area " +
                          "INNER JOIN centro ON area.id_Centro=centro.id_Centro " +
                          " " + dato_complemento + ";"; // funciono
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);

            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            DataTable datos = registros_encontrados.Tables[0];

            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();
            int d = datos.Rows.Count; ///// buscar si o esta mns
            return d;
        }

        public void llenarDataGridViewMatenimiento(DataGridView dataGridView)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT id_Mantenimiento,Fecha_mant, Descripcion_mantenimiento, Recomendaciones_mantenimiento, " +
                                    "id_Tipo_mantenimiento, id_Detalle_mantenimiento,id_Maquina" +
                          " FROM mantenimiento";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);

            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();
        }

        public void llenarDataGridViewProveedores(DataGridView dataGridView)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT id_proveedores,Nombre, direccion,ciudad,telefono,correo, id_Area" +
                          " FROM proveedores";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);

            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();
        }

        public void llenarDataGridViewHorasM(DataGridView dataGridView)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT id_Horas_maquina,Nombre_trabajo, Fecha_trabajo,Horometro,Hora_salida,Hora_llegada,Total_horas,id_Maquina,id_Combustible,id_Usuario" +
                          " FROM horas_maquina";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);

            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();
        }

        public void llenarDataGridViewMaquina(DataGridView dataGridView)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT id_Maquina,Serie,Modelo,Potencia,Marca,Combustible,Observaciones,id_Usuario,id_Area" +
                          " FROM maquina";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);
            
            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();



        }

        public void llenarDataGridViewFactura(DataGridView dataGridView)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT id_Factura,Factura,Nit,Cliente,Fecha,Telefono,Direccion,id_Proveedores, id_Mantenimiento" +
                          " FROM factura";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);

            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();




        }

        public void llenarDataGridViewrevisionD(DataGridView dataGridView)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT id_Revicion_diaria,Revision,Observaciones,id_Horas_maquina" +
                          " FROM revision_diaria";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);

            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();



        }

        public void llenarDataGridViewDetalleMantenmiento(DataGridView dataGridView)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT id_Detalle_mantenimiento,Fecha_registro,Observaciones_detalle_mantenimiento" +
                          " FROM detalle_mantenimiento";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);

            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();
            
        }

        public void llenarDataGridViewGenero(DataGridView dataGridView)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT id_Genero,Genero" +
                          " FROM genero";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);

            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();




        }

        public void llenarDataGridViewTipoD(DataGridView dataGridView)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT id_Tipo_Documento,Nombre_Doc" +
                          " FROM tipo_documento";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);

            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();




        }

        public void llenarDataGridViewTipoMantenmiento(DataGridView dataGridView)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT id_Tipo_Mantenimiento,Nombre_Mantenimiento" +
                          " FROM tipo_mantenimiento";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);

            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();




        }

        public void llenarDataGridViewDetalleFactura(DataGridView dataGridView)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT id_Detalle_Factura,Producto, Cantidad, Precio_Unitario, Total" +
                          " FROM detalle_factura";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);

            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();




        }

        public void llenarDataGridViewRol(DataGridView dataGridView)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT id_Rol,Nombre_Rol" +
                          " FROM rol";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);

            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();




        }

        public int llenarDataGridViewRegional(DataGridView dataGridView,string dato_complemento)
        {

            string connstring = server + db + usuario + clave;
            MySqlConnection MyConexion = new MySqlConnection(connstring);
            MyConexion.Open();
            String SQL_ = "SELECT id_Regional,Nombre_regional,Codigo,Telefono,Direccion,Correo" +
                          " FROM regional" +
                           " " + dato_complemento + ";";
            MySqlDataAdapter obtener = new MySqlDataAdapter(SQL_, MyConexion);

            DataSet registros_encontrados = new DataSet();//para  guardar el conjuto de datos
            obtener.Fill(registros_encontrados);//guarda en registros_encontrados
            DataTable datos = registros_encontrados.Tables[0];

            dataGridView.DataSource = registros_encontrados.Tables[0];
            MyConexion.Close();
            int b = datos.Rows.Count; ///// buscar si o esta mns
            return b;




        }
        
    }
}
