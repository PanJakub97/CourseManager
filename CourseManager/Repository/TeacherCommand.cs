using CourseManager.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManager.Repository
{
    internal class TeacherCommand
    {
        private string _connectionString;

        public TeacherCommand(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IList<TeacherModel> GetList()
        {
            List<TeacherModel> teachers = new List<TeacherModel>();

            var sql = "Teacher_GetList";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                teachers = connection.Query<TeacherModel>(sql).ToList();
            }

            return teachers;
        }
    }
}
