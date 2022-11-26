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
    public class TypeDataBase
    {

        private SqlConnection _connection;

        public TypeDataBase(SqlConnection connection)
        {
            _connection = connection;
        }

        #region "Methods"

        public bool AddTypesIdentities(TypesIdentities item)
        {
            SqlCommand command = new SqlCommand("INSERT INTO TiposEntidades(Descripcion,IdGrupoEntidad,Comentario,StatusTiposEntidades,NoEliminable,FechaRegistro) VALUES(@Descripcion,@IdGrupo,@Comentario,@StatusEntidad,@Noeliminable,@Fecha)", _connection);

            command.Parameters.AddWithValue("@Descripcion", item.Description);
            command.Parameters.AddWithValue("@IdGrupo", item.IdGrupoEntidad);
            command.Parameters.AddWithValue("@Comentario", item.Comentary);
            command.Parameters.AddWithValue("@StatusEntidad", item.Status);
            command.Parameters.AddWithValue("@Noeliminable", item.NoEliminable);
            command.Parameters.AddWithValue("@Fecha", item.Date);

            return ExecuteDml(command);
        }

        public bool EditTypesIdentities(TypesIdentities item)
        {
            SqlCommand command = new SqlCommand("UPDATE TiposEntidades SET Descripcion=@Descripcion,IdGrupoEntidad=@IdGrupo,Comentario=@Comentario,StatusTiposEntidades=@StatusEntidad,NoEliminable= @Noeliminable,FechaRegistro=@Fecha WHERE IdTipoEntidad  = @id", _connection);

            command.Parameters.AddWithValue("@Descripcion", item.Description);
            command.Parameters.AddWithValue("@IdGrupo", item.IdGrupoEntidad);
            command.Parameters.AddWithValue("@Comentario", item.Comentary);
            command.Parameters.AddWithValue("@StatusEntidad", item.Status);
            command.Parameters.AddWithValue("@Noeliminable", item.NoEliminable);
            command.Parameters.AddWithValue("@Fecha", item.Date);

            return ExecuteDml(command);
        }

        public DataTable GetAllTypes()
        {
            SqlDataAdapter query = new SqlDataAdapter("SELECT IdTipoEntidad  as Code,Descripcion,IdGrupoEntidad as Grupo,Comentario,StatusTiposEntidades as Status,NoEliminable as Eliminable,FechaRegistro FROM TiposEntidades", _connection);

            return LoadDatatypes(query);
        }

        public bool DeleteType(int id)
        {
            SqlCommand command = new SqlCommand("DELETE TiposEntidades WHERE IdTipoEntidad = @id", _connection);

            command.Parameters.AddWithValue("@id", id);

            return ExecuteDml(command);
        }

        public TypesIdentities GetById(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand("SELECT IdTipoEntidad,Descripcion,IdGrupoEntidad,Comentario,StatusTiposEntidades,NoEliminable,FechaRegistro FROM TiposEntidades WHERE IdTipoEntidad = @id", _connection);

                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                TypesIdentities data = new TypesIdentities();

                while (reader.Read())
                {

                    data.Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    data.Description = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    data.IdGrupoEntidad = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    data.Comentary = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    data.Status = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    data.NoEliminable = reader.IsDBNull(5) ? false : reader.GetBoolean(5);
                    data.Date = reader.IsDBNull(6) ? DateTime.Now : reader.GetDateTime(6);
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
