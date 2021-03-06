﻿using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Dao.Impl
{
    public class CourseDao : GenericDao<Course>, ICourseDao
    {
        override protected IRowMapper<Course> GetRowMapper()
        {
            return new CourseRowMapper();
        }

        public void AddCourse(Course course)
        {
            string command = @"INSERT INTO Course (Course_Id, Course_Name, Course_Description,Course_Tel,Course_Start,Course_End,Course_Here,Course_Rest) VALUES (@Id, @Name, @Description,@Tel,@Start,@End,@Here,@Rest);";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = course.Tel;
            parameters.Add("Name", DbType.String).Value = course.Name;
            parameters.Add("Description", DbType.String).Value = course.Description;
            parameters.Add("Tel", DbType.String).Value = course.Tel;
            parameters.Add("Start", DbType.String).Value = course.Start;
            parameters.Add("End", DbType.String).Value = course.End;
            parameters.Add("Here", DbType.String).Value = course.Here;
            parameters.Add("Rest", DbType.String).Value = course.Rest;

            ExecuteNonQuery(command, parameters);
        }

        public void UpdateCourse(Course course)
        {
            string command = @"UPDATE Course SET Course_Name = @Name, Course_Description = @Description, Course_Tel = @Tel, Course_Start = @Start, Course_End = @End, Course_Here = @Here, Course_Rest = @Rest     WHERE Course_Id = @Id;";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = course.Id;
            parameters.Add("Name", DbType.String).Value = course.Name;
            parameters.Add("Description", DbType.String).Value = course.Description;
            parameters.Add("Tel", DbType.String).Value = course.Tel;
            parameters.Add("Start", DbType.String).Value = course.Start;
            parameters.Add("End", DbType.String).Value = course.End;
            parameters.Add("Here", DbType.String).Value = course.Here;
            parameters.Add("Rest", DbType.String).Value = course.Rest;


            ExecuteNonQuery(command, parameters);
        }

        public void DeleteCourse(Course course)
        {
            string command = @"DELETE FROM Course WHERE Course_Id = @Id";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Id", DbType.String).Value = course.Id;

            ExecuteNonQuery(command, parameters);
        }

        public IList<Course> GetAllCourse()
        {
            string command = @"SELECT * FROM Course ORDER BY Course_Id ASC";
            IList<Course> course = ExecuteQueryWithRowMapper(command);
            return course;
        }

        public Course GetCourseByName(string name)
        {
            string command = @"SELECT * FROM Course WHERE Course_Name = @Name";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("Name", DbType.String).Value = name;

            IList<Course> course = ExecuteQueryWithRowMapper(command, parameters);
            if (course.Count > 0)
            {
                return course[0];
            }

            return null;
        }

        public Course GetCourseById(string id)
        {
            string command = @"SELECT * FROM Course WHERE Course_Id = @id";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("id", DbType.String).Value = id;

            IList<Course> course = ExecuteQueryWithRowMapper(command, parameters);
            if (course.Count > 0)
            {
                return course[0];
            }

            return null;
        }
    }
}
