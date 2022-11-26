using BusinessLayer.DataBase;
using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public  class EntitiesService
    {
        public EntitiesDatabase repository;

        public EntitiesService(SqlConnection connection)
        {
            repository = new EntitiesDatabase(connection);
        }

        #region "Methods"

        public bool Add(Entities item)
        {
            return repository.Addentities(item);
        }

        public bool Delete(int id)
        {
            return repository.DeleteEntities(id);
        }

        public bool Edit(Entities item)
        {
            return repository.Editentities(item);
        }

        public DataTable GetAll()
        {
         return repository.GetAll();
        }

        public Entities GetById(int Id)
        {
            return repository.GetById(Id);
        }

        public Entities Login(string username, string password)
        {
            return repository.Login(username, password);
        }

        #endregion

    }
}
