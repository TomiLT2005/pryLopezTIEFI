using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace pryLopezTparcial
{
    internal class clsConexion
    {

        //Cadenas de conexión

        private string cadena = "Server = localhost\\SQLEXPRESS;Database=Auditoria;Trusted_Connection=True;"; //Casa//
        private string cadena2 = "Server=localhost;Database=Auditoria;Trusted_Connection=True;"; //Laboratorio//


        #region verificar conexion

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
        #endregion


        #region Usuarios


        //Listar Usuarios
        public void Listar_Usuarios(DataGridView Grilla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT u.Id, u.Nombre, u.Contraseña, u.Correo, u.Telefono, r.Nombre AS Rol, u.RolId  " +
                                   "FROM Usuarios u INNER JOIN Roles r ON u.RolId = r.Id;";

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



        //Cargar Roles
        public void CargarRoles(ComboBox Combo)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT Id, Nombre FROM Roles WHERE Nombre IN ('Usuario', 'Supervisor')"; ; //Solo se carga 'Usuario' y 'Supervisor'//

                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    Combo.DataSource = tabla;
                    Combo.DisplayMember = "Nombre";
                    Combo.ValueMember = "Id";
                    Combo.SelectedIndex = -1;  //arranque vacío
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al cargar categorías: " + error.Message);
            }
        }



        //Agregar Usuario
        public void Agregar_Usuario(clsUsuario usuario)
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
                    comando.Parameters.AddWithValue("@rolId", usuario.RolId);

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
        public void Modificar_Usuario(clsUsuario usuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "UPDATE Usuarios SET Nombre = @nombre, Contraseña = @contraseña, Correo = @correo, Telefono = @telefono, RolId = @rolId  WHERE Id = @id";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    comando.Parameters.AddWithValue("@contraseña", usuario.Contraseña);
                    comando.Parameters.AddWithValue("@correo", usuario.Correo);
                    comando.Parameters.AddWithValue("@telefono", usuario.Telefono);
                    comando.Parameters.AddWithValue("@rolId", usuario.RolId); 
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
        public void Eliminar_Usuario(int id)
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



        //Buscar Nombre de Usuario
        public void BuscarporNombre_Usuario(DataGridView Grilla, string nombreUsuario)
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


                    //Si no se encuentra el usuario y escribe mas de 2 letras, mostrar mensaje
                    if (tabla.Rows.Count == 0 && nombreUsuario.Length > 2)
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
        public bool verificar_Usuario(clsUsuario usuario)
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
        #endregion


        #region Registros

        //Agregar Registro
        public void Agregar_Registro(clsRegistro registro)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();

                    string query = "INSERT INTO Registros " +
                                   "(FechaRegistro, TareaId, LugarId, Insumos, Vacacion, Estudio, Salario, Recibo, Comentarios) " +
                                   "VALUES (@fechaRegistro, @tareaId, @lugarId, @insumos, @vacacion, @estudio, @salario, @recibo, @comentarios)";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@fechaRegistro", registro.FechaRegistro);
                    comando.Parameters.AddWithValue("@tareaId", registro.TareaId);
                    comando.Parameters.AddWithValue("@lugarId", registro.LugarId);
                    comando.Parameters.AddWithValue("@insumos", registro.Insumos);
                    comando.Parameters.AddWithValue("@vacacion", registro.Vacacion);
                    comando.Parameters.AddWithValue("@estudio", registro.Estudio);
                    comando.Parameters.AddWithValue("@salario", registro.Salario);
                    comando.Parameters.AddWithValue("@recibo", registro.Recibo);


                    // Validación para comentarios nulos o vacíos
                    if (string.IsNullOrEmpty(registro.Comentarios))
                    {
                        comando.Parameters.AddWithValue("@comentarios", DBNull.Value);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@comentarios", registro.Comentarios);
                    }


                    comando.ExecuteNonQuery();

                    MessageBox.Show("Registro agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Listar Registros
        public void Listar_Registros(DataGridView grilla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();

                    string query = "SELECT r.Id, r.FechaRegistro, t.Nombre AS Tarea, l.Nombre AS Lugar, " +
                                   "r.Insumos, r.Vacacion, r.Estudio, r.Salario, r.Recibo, r.Comentarios " +
                                   "FROM Registros r " +
                                   "INNER JOIN Tareas t ON r.TareaId = t.Id " +
                                   "INNER JOIN Lugares l ON r.LugarId = l.Id " +
                                   "ORDER BY r.FechaRegistro DESC;";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    grilla.DataSource = tabla;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al listar los registros: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Buscar Registros por Fecha
        public void BuscarPorFecha_Registro(DataGridView grilla, DateTime fecha)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT r.Id, r.FechaRegistro, t.Nombre AS Tarea, l.Nombre AS Lugar, " +
                                   "r.Insumos, r.Vacacion, r.Estudio, r.Salario, r.Recibo, r.Comentarios " +
                                   "FROM Registros r INNER JOIN Tareas t ON r.TareaId = t.Id " +
                                   "INNER JOIN Lugares l ON r.LugarId = l.Id WHERE CAST(r.FechaRegistro AS DATE) = @fechaRegistro ORDER BY r.FechaRegistro DESC;";


                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@fechaRegistro", fecha.Date);

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    if (tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron sesiones para la fecha seleccionada.", "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        grilla.DataSource = tabla;
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al buscar por fecha: " + error.Message);
            }
        }



        //Buscar por Tarea
        public void BuscarporTarea(DataGridView Grilla, string tarea)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT r.Id, r.FechaRegistro, t.Nombre AS Tarea, l.Nombre AS Lugar, " +
                                   "r.Insumos, r.Vacacion, r.Estudio, r.Salario, r.Recibo, r.Comentarios " +
                                   "FROM Registros r " +
                                   "INNER JOIN Tareas t ON r.TareaId = t.Id " +
                                   "INNER JOIN Lugares l ON r.LugarId = l.Id " +
                                   "WHERE t.Nombre LIKE @tarea " +
                                   "ORDER BY r.FechaRegistro DESC;";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@tarea", "%" + tarea + "%");


                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);


                    //Si no se encuentra el usuario y escribe mas de 2 letras, mostrar mensaje
                    if (tabla.Rows.Count == 0 && tarea.Length > 2)
                    {
                        MessageBox.Show("No se encontró ninguna tarea", "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        #endregion


        #region Tareas

        //Cargar Tareas
        public void CargarTareas(ComboBox Combo)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT Id, Nombre FROM Tareas"; 

                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    Combo.DataSource = tabla;
                    Combo.DisplayMember = "Nombre";
                    Combo.ValueMember = "Id";
                    Combo.SelectedIndex = -1;   //arranque vacío
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al cargar categorías: " + error.Message);
            }
        }



        //Agregar Tarea
        public void Agregar_Tarea(clsTarea tarea)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "INSERT INTO Tareas (Nombre) VALUES (@nombre)";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@nombre", tarea.Nombre);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Tarea agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al agregar tarea: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Modificar Tarea
        public void Modificar_Tarea(clsTarea tarea)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "UPDATE Tareas SET Nombre = @nombre WHERE Id = @id";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@nombre", tarea.Nombre);
                    comando.Parameters.AddWithValue("@id", tarea.Id);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Tarea modificada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al modificar tarea: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Eliminar Tarea
        public void Eliminar_Tarea(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "DELETE FROM Tareas WHERE Id = @id";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@id", id);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Tarea eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al eliminar la tarea: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Listar Usuarios
        public void Listar_Tareas(DataGridView Grilla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT t.Id, t.Nombre FROM Tareas t";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    Grilla.DataSource = tabla;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"No se pudieron cargar las Tareas correctamente. Revise su conexión o intente más tarde. Detalles del error: {error.Message}", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        #region Lugares

        //Cargar Lugares
        public void CargarLugares(ComboBox Combo)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT Id, Nombre FROM Lugares";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    Combo.DataSource = tabla;
                    Combo.DisplayMember = "Nombre";
                    Combo.ValueMember = "Id";
                    Combo.SelectedIndex = -1;  //arranque vacío
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al cargar categorías: " + error.Message);
            }
        }



        //Agregar Lugar
        public void Agregar_Lugar(clsLugar lugar)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "INSERT INTO Lugares (Nombre) VALUES (@nombre)";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@nombre", lugar.Nombre);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Lugar agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al agregar lugar: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Modificar Lugar
        public void Modificar_Lugar(clsLugar lugar)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "UPDATE Lugares SET Nombre = @nombre WHERE Id = @id";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@nombre", lugar.Nombre);
                    comando.Parameters.AddWithValue("@id", lugar.Id);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Lugar modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al modificar lugar: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Eliminar Lugar
        public void Eliminar_Lugar(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "DELETE FROM Lugares WHERE Id = @id";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@id", id);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Lugar eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al eliminar el lugar: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Listar Usuarios
        public void Listar_Lugares(DataGridView Grilla)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT l.Id, l.Nombre FROM Lugares l";
                                  
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    Grilla.DataSource = tabla;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show($"No se pudieron cargar los Lugares correctamente. Revise su conexión o intente más tarde. Detalles del error: {error.Message}", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        #region Sesiones

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

                    string query = "SELECT u.Nombre, s.FechaInicio, s.HoraInicio, s.HoraFin, s.TiempoTranscurrido FROM Sesiones s INNER JOIN Usuarios u ON s.IdUsuario = u.Id ORDER BY s.FechaInicio DESC, s.HoraInicio DESC;";


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



        //Buscar Sesiones por Fecha
        public void BuscarPorFecha_Sesiones(DataGridView grilla, DateTime fecha)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    string query = "SELECT u.Nombre, s.FechaInicio, s.HoraInicio, s.HoraFin, s.TiempoTranscurrido " +
                                   "FROM Sesiones s INNER JOIN Usuarios u ON s.IdUsuario = u.Id " +
                                   "WHERE CAST(s.FechaInicio AS DATE) = @fecha ORDER BY s.HoraInicio DESC";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@fecha", fecha.Date);

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    if (tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron sesiones para la fecha seleccionada.", "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        grilla.DataSource = tabla;
                    }

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al buscar por fecha: " + error.Message);
            }
        }
        #endregion
    }
}

