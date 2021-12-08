﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.Models
{
     public class GuestBookDB
    {
        static GuestBookDB instance;
        SqlConnection connection;
        string connectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\adham\Desktop\db.mdf;Integrated Security=True;Connect Timeout=30");
        public static GuestBookDB getInstance()
        {
           if(instance == null)
            {
                instance = new GuestBookDB();
                return instance;
            }

            return instance;
        }
        public  GuestBookDB()
        {
            connection = new SqlConnection(connectionString);
        }




        string GenerateQuery(string Table , Dictionary<string,object>Parameters , out List<SqlParameter> SqlParamters)
        {
            string query = "INSERT INTO " + Table + " ( ";
            string values = "  values ( ";
            int dictCounter = 0;
            SqlParamters = new List<SqlParameter>();

            foreach (var (key, value) in Parameters)
            {
                query += key;
                values += "@" + key;
                if (dictCounter + 1 < Parameters.Count)
                {
                    query += ",";
                    values += ",";
                }
                SqlParameter paramter = new SqlParameter("@" + key, value);
                SqlParamters.Add(paramter);
                dictCounter++;
            }
            values += ");";
            query += ")";
            query += values;

            return query;
        }
        public int Insert(string Table , Dictionary<string,Object>Parameters)
        {
            
             
                    connection.Open();
            List<SqlParameter> sqlParamters;

            string query =   GenerateQuery(Table, Parameters,out sqlParamters);

            SqlCommand UpdateCommand = new SqlCommand(query,connection);
            UpdateCommand.Parameters.AddRange(sqlParamters.ToArray());
          
           
            int rowsAffeced = UpdateCommand.ExecuteNonQuery();


                     connection.Close();
                return rowsAffeced;
                    
          

            
        }
      public DataTable Query(string command)
        {
           
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(command, connection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
                connection.Close();
                return dtbl;
            
         
        }
    }
}