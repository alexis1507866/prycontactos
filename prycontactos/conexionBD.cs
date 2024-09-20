using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
namespace prycontactos
{
    internal class conexionBD
    {
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;

        public class contacto
        {
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string telefono { get; set; }
            public string correo { get; set; }
            public string categoria { get; set; }


        }
        public conexionBD()
        {

            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../BD/contacto.accdb;";

        }



        public void listarproductos(DataGridView dgvGrilla)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM contactos ORDER BY nombre";

                DataTable tablacontactos= new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablacontactos);

                dgvGrilla.DataSource = tablacontactos;


            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }








        }

        public void agregar(string nombre,string apellido,string telefono,string correo,string categoria)
        {
            using (OleDbConnection connection = new OleDbConnection(cadena))
            {
                string query = "INSERT INTO contactos(nombre,apellido,telefono,categoria)VALUES(?,?,?,?,?)";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@categoria",categoria);
                    connection.Open();
                    command.ExecuteNonQuery();


                }


            }


        }
           
        public void eliminar(contacto contacto)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"DELETE FROM contactos WHERE Nombre='{contacto.nombre}'";

                conexion.Open();
                comando.ExecuteNonQuery();



            }
            catch 
            {
            
            
            }


        }
     
        public void editar()
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM contactos";
                DataTable tablacontactos = new DataTable();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablacontactos);

            }
            catch (Exception)
            {
               
                MessageBox.Show("conexion correcta", "conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void editar(DataGridView grilla)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM contactos";
                DataTable tablacontactos = new DataTable();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablacontactos);

                grilla.DataSource = tablacontactos;

            }
            catch (Exception)
            {

                MessageBox.Show("conexion correcta", "conexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    
}
