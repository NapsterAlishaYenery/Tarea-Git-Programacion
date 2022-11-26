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
    public class GroupService
    {
        public GroupDataBase repository;
        public GroupService(SqlConnection connection)
        {
            repository = new GroupDataBase(connection);
        }

        #region "Methods"

        public bool Add(GroupEntities item)
        {
            return repository.AddGroupEntities(item);
        }

        public bool Delete(int id)
        {
            return repository.DeleteGroup(id);
        }

        public bool Edit(GroupEntities item)
        {
            return repository.EditGroupIdentities(item);
        }

        public DataTable GetAll()
        {
            return repository.GetAllGroup();
        }

        public GroupEntities GetById(int Id)
        {
            return repository.GetById(Id);
        }

        #endregion
    }
}

