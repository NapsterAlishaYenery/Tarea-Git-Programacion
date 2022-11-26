using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataBase
{
    public  class EntitiesDatabase
    {
        private SqlConnection _connection;

        public EntitiesDatabase(SqlConnection conecction)
        {
            _connection = conecction;
        }

        #region "Methods"

        public bool Addentities(Entities item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Entidades(Descripcion,Direccion,Localidad,TipoEntidad,TipoDocumento,NumeroDocumento,Telefonos,URLPaginaWeb,URLFacebook,URLInstagram,URLTwitter,URLtiktok,IdGrupoEntidad,IdEntidad,LimiteCredito,UserNameEntidad,PassworEntidad,RolUserEntidad,Comentario,Statuss,NoEliminable,FechaRegistro)VALUES(@Descripcion,@Direccion,@Localidad,@TipoEntidad,@TipoDocumento,@NumeroDocumento,@Telefonos,@URLPaginaWeb,@URLFacebook,@URLInstagram,@URLTwitter,@LimiteCredito,@UserNameEntidad,@PasswordEntidad,@RolUserEntidad,@Comentario,@StatusEntidad,@NoEliminable,@FechaRegistro)", _connection);
            command.Parameters.AddWithValue("@Descripcion", item.Descripcion);
            command.Parameters.AddWithValue("@Direccion", item.Direccion);
            command.Parameters.AddWithValue("@Localidad", item.Localidad);
            command.Parameters.AddWithValue("@TipoEntidad", item.TipoEntidad);
            command.Parameters.AddWithValue("@TipoDocumento ", item.TipoDocumento);
            command.Parameters.AddWithValue("@NumeroDocumento", item.NumeroDocumento);
            command.Parameters.AddWithValue("@Telefonos", item.Telefonos);
            command.Parameters.AddWithValue("@URLPaginaWeb", item.URLPaginaWeb);
            command.Parameters.AddWithValue("@URLFacebook", item.URLFacebook);
            command.Parameters.AddWithValue("@URLInstagram", item.URLInstagram);
            command.Parameters.AddWithValue("@URLTwitter", item.URLTwitter);
            command.Parameters.AddWithValue("@LimiteCredito", item.LimiteCredito);
            command.Parameters.AddWithValue("@UserNameEntidad", item.UserNameEntidad);
            command.Parameters.AddWithValue("@PasswordEntidad", item.PasswordEntidad);
            command.Parameters.AddWithValue("@RolUserEntidad", item.RolUserEntidad);
            command.Parameters.AddWithValue("@Comentario", item.Comentario);
            command.Parameters.AddWithValue("@StatusEntidad", item.Status1);
            command.Parameters.AddWithValue("@NoEliminable", item.NoEliminable);
            command.Parameters.AddWithValue("@FechaRegistro", item.FechaRegistro);

            return ExecuteDml(command);
        }

        public bool Editentities(Entities item)
        {
            SqlCommand command = new SqlCommand("UPDATE Entidades SET Descripcion = @Descripcion ,Direccion = @Direccion ,TipoEntidad = @TipoEntidad,NumeroDocumento = @NumeroDocumento,Telefonos = @Telefonos,URLPaginaWeb = @URLPaginaWeb,URLFacebook = @URLFacebook,URLInstagram = @URLInstagram,URLTwitter = @URLTwitter,URLtiktok= @URLtiktok,IdGrupoEntidad = @IdGrupoEntidad,IdTipoEntidad = @IdTipoEntidad,LimiteCredito = @LimiteCredito,UserNameEntidad = @UserNameEntidad,PassworEntidad = @PassworEntidad,RolUserEntidad = @RolUserEntidad,Comentario = @Comentario,Statuss = @StatusEntidad,NoEliminable = @NoEliminable,FechaRegistro = @FechaRegistro WHERE IdEntidad = @Id", _connection);

            command.Parameters.AddWithValue("@Descripcion", item.Descripcion);
            command.Parameters.AddWithValue("@Direccion", item.Direccion);
            command.Parameters.AddWithValue("@Localidad", item.Localidad);
            command.Parameters.AddWithValue("@TipoEntidad", item.TipoEntidad);
            command.Parameters.AddWithValue("@TipoDocumento ", item.TipoDocumento);
            command.Parameters.AddWithValue("@NumeroDocumento", item.NumeroDocumento);
            command.Parameters.AddWithValue("@Telefonos", item.Telefonos);
            command.Parameters.AddWithValue("@URLPaginaWeb", item.URLPaginaWeb);
            command.Parameters.AddWithValue("@URLFacebook", item.URLFacebook);
            command.Parameters.AddWithValue("@URLInstagram", item.URLInstagram);
            command.Parameters.AddWithValue("@URLTwitter", item.URLTwitter);
            command.Parameters.AddWithValue("@LimiteCredito", item.LimiteCredito);
            command.Parameters.AddWithValue("@UserNameEntidad", item.UserNameEntidad);
            command.Parameters.AddWithValue("@PasswordEntidad", item.PasswordEntidad);
            command.Parameters.AddWithValue("@RolUserEntidad", item.RolUserEntidad);
            command.Parameters.AddWithValue("@Comentario", item.Comentario);
            command.Parameters.AddWithValue("@StatusEntidad ", item.Status1);
            command.Parameters.AddWithValue("@NoEliminable ", item.NoEliminable);
            command.Parameters.AddWithValue("@FechaRegistro ", item.FechaRegistro);

            return ExecuteDml(command);
        }

        public DataTable GetAll()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT * From Entidades", _connection);

            return LoadDatatypes(query);
        }

        public bool DeleteEntities(int id)
        {
            SqlCommand command = new SqlCommand("DELETE Entidades WHERE IdEntidad = @Id", _connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public Entities GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("SELECT Descripcion,Direccion,TipoEntidad,NumeroDocumento,Telefonos,URLPaginaWeb,URLFacebook,URLInstagram,URLTwitter, URLtiktok, IdGrupoEntidad, IdTipoEntidad, LimiteCredito, UserNameEntidad, PassworEntidad, RolUserEntidad, Comentario, StatusEntidad, NoEliminable, FechaRegistro, Localidad, TipoDocumento FROM Entidades WHERE IdEntidad = @id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                Entities data = new Entities();

                while (reader.Read())
                {

                    data.id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Descripcion = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.Direccion = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Localidad = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.TipoEntidad = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.TipoDocumento = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    data.NumeroDocumento = reader.IsDBNull(6) ? "" : reader.GetString(6);
                    data.Telefonos = reader.IsDBNull(7) ? "" : reader.GetString(7);
                    data.URLPaginaWeb = reader.IsDBNull(8) ? "" : reader.GetString(8);
                    data.URLFacebook = reader.IsDBNull(9) ? "" : reader.GetString(9);
                    data.URLInstagram = reader.IsDBNull(10) ? "" : reader.GetString(10);
                    data.URLTwitter = reader.IsDBNull(11) ? "" : reader.GetString(11);
                    data.URLtiktok = reader.IsDBNull(12) ? "" : reader.GetString(12);
                    data.IdGrupoEntidad = reader.IsDBNull(13) ? "" : reader.GetString(13);
                    data.IdTipoEntidad = reader.IsDBNull(14) ? "" : reader.GetString(14);
                    data.LimiteCredito = reader.IsDBNull(15) ? "" : reader.GetString(15);
                    data.UserNameEntidad = reader.IsDBNull(16) ? "" : reader.GetString(16);
                    data.PasswordEntidad = reader.IsDBNull(17) ? "" : reader.GetString(17);
                    data.Comentario = reader.IsDBNull(18) ? "" : reader.GetString(18);
                    data.RolUserEntidad = reader.IsDBNull(19) ? "" : reader.GetString(19);
                    data.Status1 = reader.IsDBNull(20) ? "" : reader.GetString(20);
                    data.NoEliminable = reader.IsDBNull(21) ? false : reader.GetBoolean(21);
                    data.FechaRegistro = reader.IsDBNull(22) ? DateTime.Now : reader.GetDateTime(22);
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Entities Login(string username, string password)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("SELECT UserNameEntidad, PassworEntidad FROM Entidades WHERE UserNameEntidad = @username AND PassworEntidad = @password", _connection);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();

                Entities data = new Entities();

                while (reader.Read())
                {
                    data.UserNameEntidad = reader.IsDBNull(14) ? "" : reader.GetString(14);
                    data.PasswordEntidad = reader.IsDBNull(15) ? "" : reader.GetString(15);
                }

                reader.Close();
                reader.Dispose();

                _connection.Close();

                return data;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #endregion

        #region "Connection"

        private bool ExecuteDml(SqlCommand query)
        {
            try
            {
                _connection.Open();

                query.ExecuteNonQuery();

                _connection.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private DataTable LoadDatatypes(SqlDataAdapter query)
        {
            try
            {
                DataTable data = new DataTable();

                _connection.Open();

                query.Fill(data);

                _connection.Close();

                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }

        #endregion
    }
}
