using KuasCore.Models;
using Spring.Data.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Mapper
{
    class CourseRowMapper : IRowMapper<Course>
    {
        public Course MapRow(IDataReader dataReader, int rowNum)
        {
            Course target = new Course();

            target.Id = dataReader.GetString(dataReader.GetOrdinal("Course_ID"));
            target.Name = dataReader.GetString(dataReader.GetOrdinal("Course_Name"));
            target.Description = dataReader.GetString(dataReader.GetOrdinal("Course_Description"));
            target.Tel = dataReader.GetString(dataReader.GetOrdinal("Course_Tel"));
            target.Start = dataReader.GetString(dataReader.GetOrdinal("Course_Start"));
            target.End = dataReader.GetString(dataReader.GetOrdinal("Course_End"));
            target.Here = dataReader.GetString(dataReader.GetOrdinal("Course_Here"));
            target.Rest = dataReader.GetString(dataReader.GetOrdinal("Course_Rest"));

            return target;
        }
    }
}
