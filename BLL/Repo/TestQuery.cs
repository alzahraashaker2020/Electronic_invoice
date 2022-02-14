//using DAL.Entities;
using Microsoft.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace BLL.Repo
{
    public class TestQuery
    {

        //public void Get ()
        //{
        //    string connectionString = @"Data Source=10.8.2.154/DOTNET.lehaa.local;User ID=AGROTEST;Password=AGROTEST;Connection Timeout=0;Pooling=False";// @"User Id=BIOTECH;Password=BIOTECH;Data Source=10.8.2.154/DOTNET.lehaa.local;Connection Timeout=600;min pool size=0;connection lifetime=18000;PERSIST SECURITY INFO=True;";
        //    string query = "select *from STORE_TRNS";

        //    OracleConnection conn = new OracleConnection(connectionString); 
        //    OracleCommand cmd = new OracleCommand(query, conn);
        //    if(conn.State== ConnectionState.Closed)conn.Open();
        //    OracleDataReader Reader = cmd.ExecuteReader();
        //    DataTable Data = new DataTable();
        //    Data.Load(Reader);
        //    conn.Close();
        //    Reader.Close();
        //    var tt =  Data;

        //}



        public async Task<List<object>> Get(string squery, Dictionary<string, object> para = null, int type = 0)
        {
            
            string connectionString =@"Data Source=10.8.2.154/DOTNET.lehaa.local;User ID=AGROTEST;Password=AGROTEST;Connection Timeout=0;Pooling=False";
            //_configuration.GetConnectionString("TestConn");
            //@"DataSource=10.8.2.154/DOTNET.lehaa.local;User ID=AGROTEST;Password=AGROTEST;Connection Timeout=0;Pooling=False";// @"User Id=BIOTECH;Password=BIOTECH;Data Source=10.8.2.154/DOTNET.lehaa.local;Connection Timeout=600;min pool size=0;connection lifetime=18000;PERSIST SECURITY INFO=True;";
            string command = squery;

            await using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    if (type == 1)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        List<SqlParameter> orapar = new List<SqlParameter>();
                        foreach (var item in para)
                        {
                            var param = new SqlParameter();
                            param.ParameterName = item.Key;
                            param.SqlDbType = SqlDbType.Decimal;
                            if (param.ParameterName.Contains("transDate")) param.SqlDbType = SqlDbType.Date;
                            param.Value = item.Value;
                            orapar.Add(param);
                        }
                        cmd.Parameters.AddRange(orapar.ToArray());
                        //cmd.Parameters.Add("CURSORPARAM", SqlDbType.RefCursor, ParameterDirection.Output);
                    }
                    SqlDataReader Reader = null;
                    DataTable Data = new DataTable();
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    if(type == 2) { 
                    cmd.ExecuteNonQuery();
                    }
                    Reader = cmd.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        Data.Load(Reader);
                    }
                    return FromDataTableToJson(Data);
                }
            }
        }

        public List<object> FromDataTableToJson(DataTable dt)
        {
            var list = new List< object>();
            foreach (DataRow row in dt.Rows)
            {
                var dic = new Dictionary<string, object>();
                foreach (DataColumn column in dt.Columns)
                    dic[column.ColumnName] = (Convert.ToString(row[column]));
                list.Add(dic);
            }
            return list;
        }


        public static  List<T> Get<T>(string squery, Dictionary<string, object> para = null, int type = 0)
        {

            string connectionString = @"Data Source=CSHARP55;Initial Catalog=Invoice_Electronic;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //_configuration.GetConnectionString("TestConn");
            //@"Data Source=10.8.2.154/DOTNET.lehaa.local;User ID=AGROTEST;Password=AGROTEST;Connection Timeout=0;Pooling=False";// @"User Id=BIOTECH;Password=BIOTECH;Data Source=10.8.2.154/DOTNET.lehaa.local;Connection Timeout=600;min pool size=0;connection lifetime=18000;PERSIST SECURITY INFO=True;";
            string command = squery;

             using (SqlConnection conn = new SqlConnection(connectionString))
            {
                 using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    if (type == 1)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        List<SqlParameter> orapar = new List<SqlParameter>();
                        foreach (var item in para)
                        {
                            var param = new SqlParameter();
                            param.ParameterName = item.Key;
                            param.SqlDbType = SqlDbType.Decimal;
                            param.Value = item.Value;
                            orapar.Add(param);
                        }
                        cmd.Parameters.AddRange(orapar.ToArray());
                        //cmd.Parameters.Add("CURSORPARAM", SqlDbType., ParameterDirection.Output);
                    }
                    SqlDataReader Reader = null;
                    DataTable Data = new DataTable();
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    Reader = cmd.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        Data.Load(Reader);
                    }
                    return ConvertDataTable<T>(Data);
                    //return ConvertDataTable<object>(Data);// FromDataTableToJson(Data);
                }
            }
        }


        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

    }
}
