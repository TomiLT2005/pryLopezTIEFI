using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace pryLopezTparcial
{
    internal class clsConexionBD
    {

        //Cadenas de conexión

        private string cadena = "Server = localhost\\SQLEXPRESS;Database=Auditoria;Trusted_Connection=True;"; //Casa//
        private string cadena2 = "Server=localhost;Database=Auditoria;Trusted_Connection=True;"; //Laboratorio//



        //Verificar Conexión
        public void ConectarBD()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la conexión a la base de datos: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Listar Usuarios
        public void Listar(DataGridView Grilla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT u.Id, u.Nombre, u.Contraseña, u.Correo, u.Telefono, r.Nombre AS Rol FROM Usuarios u INNER JOIN Roles r ON u.RolId = r.Id;";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    Grilla.DataSource = tabla;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"No se pudieron cargar los Usuarios correctamente. Revise su conexión o intente más tarde. Detalles del error: {error.Message}", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Agregar Usuario
        public void Agregar(clsUsuario usuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "INSERT INTO Usuarios (Nombre, Contraseña, Correo, Telefono, RolId) VALUES (@nombre, @contraseña, @correo, @telefono, @rolId)";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                    comando.Parameters.AddWithValue("@correo", usuario.Correo);
                    comando.Parameters.AddWithValue("@telefono", usuario.Telefono);
                    comando.Parameters.AddWithValue("@rolId", 2);  //Siempre será 'usuario'//

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Usuario agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al agregar usuario: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Modificar Usuario
        public void Modificar(clsUsuario usuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "UPDATE Usuarios SET Nombre = @nombre, Contraseña = @contraseña, Correo = @correo, Telefono = @telefono  WHERE Id = @id";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                    comando.Parameters.AddWithValue("@correo", usuario.Correo);
                    comando.Parameters.AddWithValue("@telefono", usuario.Telefono);
                    comando.Parameters.AddWithValue("@id", usuario.Id);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Usuario modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al modificar usuario: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Eliminar Usuario
        public void Eliminar(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "DELETE FROM Usuarios WHERE Id = @id";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@id", id);

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Usuario eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al eliminar el usuario: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Buscar por nombre de Usuario
        public void BuscarporNombre(DataGridView Grilla, string nombreUsuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT * FROM Usuarios WHERE Nombre LIKE @nombre";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@nombre", "%" + nombreUsuario + "%");


                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    if (tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontró el usuario", "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Grilla.DataSource = tabla;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al buscar el usuario: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //Verificar Usuario
        public bool verificarUsuario(clsUsuario usuario)
        {
            bool loginExitoso = false;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT RolId FROM Usuarios WHERE Nombre = @Nombre AND Contraseña = @Contraseña";


                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);

                    object match = comando.ExecuteScalar();

                    if (match != null)
                    {
                        usuario.RolId = Convert.ToInt32(match);
                        loginExitoso = true;
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos. Intente nuevamente.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al verificar el Usuario: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return loginExitoso;
        }





        //-----------------------------------------------------------------------------------------------------------------

        //Guardar Sesión
        public void GuardarSesion(clsSesion sesion)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "INSERT INTO Sesiones (IdUsuario, FechaInicio, HoraInicio, HoraFin, TiempoTranscurrido) VALUES (@idUsuario, @fechaInicio, @horaInicio, @horaFin, @tiempoTranscurrido)";


                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@idUsuario", sesion.IdUsuario);
                        comando.Parameters.AddWithValue("@fechaInicio", sesion.FechaInicio);
                        comando.Parameters.AddWithValue("@horaInicio", sesion.HoraInicio.TimeOfDay);
                        comando.Parameters.AddWithValue("@horaFin", sesion.HoraFin.TimeOfDay);
                        comando.Parameters.AddWithValue("@tiempoTranscurrido", sesion.TiempoTranscurrido);

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al guardar Sesión: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Obtener Id del usuario por Nombre
        public int ObtenerIdUsuarioPorNombre(string nombreUsuario)
        {
            int id = 0;

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT Id FROM Usuarios WHERE Nombre = @NombreUsuario";
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);


                        var res = comando.ExecuteScalar(); //busca en la BD

                        if (res != null)
                        {
                            id = Convert.ToInt32(res);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al obtener IdUsuario: " + error.Message);
            }
            return id;
        }



        //Listar Sesiones
        public void ListarSesiones(DataGridView Grilla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();

                    string query = "SELECT u.Id, u.Nombre, s.FechaInicio, s.HoraInicio, s.HoraFin, s.TiempoTranscurrido FROM Sesiones s INNER JOIN Usuarios u ON s.IdUsuario = u.Id ORDER BY s.FechaInicio DESC, s.HoraInicio DESC;";


                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    Grilla.DataSource = tabla;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"No se pudieron cargar las sesiones correctamente. Revise su conexión o intente más tarde. Detalles del error: {error.Message}", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }  
}

