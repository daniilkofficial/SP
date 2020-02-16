using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using SP.App_Code.DAL;
using System.Data.SqlTypes;
using SP.App_Code;

namespace SP.App_Code.DAL
{
    public class DataAccessor
    {   
            private static OdbcConnection conn = null;
            public static OdbcConnection Conn
            {
                get
                {
                    if (conn == null)
                    {
                        conn = new OdbcConnection(Config.ConnectionString);
                    }
                    return conn;
                }

            }
            public static void CreateConnection(string connectionString)
            {
                conn = new OdbcConnection(connectionString);
            }
            private static OdbcCommand cmd = null;
            private static OdbcDataAdapter dataAdapter = null;

        #region Products

        public static List<ClassProducts> SelectProducts()
        {
            List<ClassProducts> result = new List<ClassProducts>();
            DataTable dataTable = new DataTable();
            using (cmd = Conn.CreateCommand())
            {
                Conn.Open();
                try
                {
                    cmd.CommandText = "SELECT IdProduct, ImageProduct, NameProduct, DescriptionProduct, Price FROM Products WHERE(DescriptionProduct IS NOT NULL) ORDER BY NameProduct";
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
                int i = 1;//счетчик строк в таблице
                foreach (DataRow row in dataTable.Rows)
                {
                    result.Add(ClassProducts.Map(row, i));
                    i++;
                }
            }
            return result;
        }

        public static ClassProducts SelectProduct(int id)
        {
            ClassProducts result = null;
            DataTable dataTable = new DataTable("Products");
            using (cmd = Conn.CreateCommand())
            {
                conn.Open();
                try
                {
                    cmd.CommandText = "SELECT IdProduct, ImageProduct, NameProduct, DescriptionProduct, Price FROM Products WHERE  [Products].[IdProduct]=? ";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("[IdProduct]", id);
                    dataAdapter = new OdbcDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dataAdapter.Dispose();
                    if (dataTable.Rows.Count > 0)
                    {
                        result = ClassProducts.Map(dataTable.Rows[0]);
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        #endregion Products
    }
}