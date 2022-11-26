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
    public class GroupDataBase
    {

        private SqlConnection _connection;

        public GroupDataBase(SqlConnection connection)
        {
            _connection = connection;
        }

        #region "Methods"

        public bool AddGroupEntities(GroupEntities item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO GruposEntidades(Descripcion,Comentario,StatusGrupo,NoEliminable,FechaRegistro) VALUES(@Descripcion, @Comentario, @StatusGroup, @Noeliminable, @FechaRegistro)", _connection);

            command.Parameters.AddWithValue("@Descripcion", item.Description);
            command.Parameters.AddWithValue("@Comentario", item.Comentary);
            command.Parameters.AddWithValue("@StatusGroup", item.Status);
            command.Parameters.AddWithValue("@Noeliminable", item.noEliminable);
            command.Parameters.AddWithValue("@FechaRegistro", item.Date);

            return ExecuteDml(command);
        }

        public bool EditGroupIdentities(GroupEntities item)
        {
            SqlCommand command = new SqlCommand("UPDATE GruposEntidades SET Descripcion=@Descripcion,Comentario=@Comentario,StatusGrupo=@StatusGrupo,NoEliminable=@Noeliminable,FechaRegistro=@FechaRegistro WHERE IdGrupoEntidad  = @id", _connection);

            command.Parameters.AddWithValue("@Descripcion", item.Description);
            command.Parameters.AddWithValue("@Comentario", item.Comentary);
            command.Parameters.AddWithValue("@StatusGrupo", item.Status);
            command.Parameters.AddWithValue("@Noeliminable", item.noEliminable);
            command.Parameters.AddWithValue("@FechaRegistro", item.Date);
            command.Parameters.AddWithValue("@id", item.Id);

            return ExecuteDml(command);
        }

        public DataTable GetAllGroup()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT IdGrupoEntidad as Code,Descripcion,Comentario,StatusGrupo,NoEliminable as Eliminable,FechaRegistro FROM GruposEntidades", _connection);

            return LoadDatatypes(query);
        }

        public bool DeleteGroup(int id)
        {
            SqlCommand command = new SqlCommand("DELETE  GruposEntidades WHERE IdGrupoEntidad = @id", _connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public GroupEntities GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("SELECT IdGrupoEntidad as Code,Descripcion,Comentario,StatusGrupo,NoEliminable as Eliminable,FechaRegistro FROM GruposEntidades WHERE IdGrupoEntidad = @id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                GroupEntities data = new GroupEntities();

                while (reader.Read())
                {

                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Description = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.Comentary = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Status = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.noEliminable = reader.IsDBNull(4) ? false : reader.GetBoolean(4);
                    data.Date = reader.IsDBNull(5) ? DateTime.Now : reader.GetDateTime(5);
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

