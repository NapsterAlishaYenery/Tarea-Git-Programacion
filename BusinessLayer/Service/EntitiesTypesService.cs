using BusinessLayer.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class EntitiesTypesService
    {
        public TypeDataBase repository;

        public EntitiesTypesService(SqlConnection connection)
        {
            repository = new TypeDataBase(connection);
        }

        #region "Methods"

        public bool Add(TypesIdentities item)
        {
            return repository.AddTypesIdentities(item);
        }

        public bool Delete(int id)
        {
            return repository.DeleteType(id);
        }

        public bool Edit(TypesIdentities item)
        {
            return repository.EditTypesIdentities(item);
        }

        public DataTable GetAll()
        {
            return repository.GetAllTypes();
        }

        public TypesIdentities GetById(int id)
        {
            return repository.GetById(id);
        }

        #endregion
    }
}
