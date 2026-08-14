using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ProiectSupermarket
{
    public class DBConnect
    {
        public string myConnection()
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\antonio\Documents\DBPOSale.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            return con;
        }

        public DataTable getTable(string queryOrProc, params SqlParameter[] parameters)
        {
            return GetTable(queryOrProc, parameters);
        }
        public DataTable GetTable(string queryOrProc, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(myConnection()))
            {
                using (SqlCommand cm = new SqlCommand(queryOrProc, cn))
                {
                    if (!queryOrProc.Contains(" ") && !queryOrProc.ToUpper().StartsWith("SELECT"))
                    {
                        cm.CommandType = CommandType.StoredProcedure;
                    }
                    else
                    {
                        cm.CommandType = CommandType.Text;
                    }

                    if (parameters != null)
                    {
                        cm.Parameters.AddRange(parameters);
                    }

                    cn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cm))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public void ExecuteQuery(string query)
        {
            using (SqlConnection cn = new SqlConnection(myConnection()))
            {
                cn.Open();
                using (SqlCommand cm = new SqlCommand(query, cn))
                {
                    cm.ExecuteNonQuery();
                }
            }
        }

        public void ExecuteNonQuery(string queryOrProc, params SqlParameter[] parameters)
        {
            using (SqlConnection cn = new SqlConnection(myConnection()))
            {
                using (SqlCommand cm = new SqlCommand(queryOrProc, cn))
                {
                    if (!queryOrProc.Contains(" ") && !queryOrProc.ToUpper().StartsWith("DELETE") && !queryOrProc.ToUpper().StartsWith("UPDATE") && !queryOrProc.ToUpper().StartsWith("INSERT"))
                    {
                        cm.CommandType = CommandType.StoredProcedure;
                    }
                    else
                    {
                        cm.CommandType = CommandType.Text;
                    }

                    if (parameters != null)
                    {
                        cm.Parameters.AddRange(parameters);
                    }

                    cn.Open();
                    cm.ExecuteNonQuery();
                }
            }
        }

        public object ExecuteScalar(string queryOrProc, params SqlParameter[] parameters)
        {
            object result = null;
            using (SqlConnection cn = new SqlConnection(myConnection()))
            {
                using (SqlCommand cm = new SqlCommand(queryOrProc, cn))
                {
                    if (!queryOrProc.Contains(" ") && !queryOrProc.ToUpper().StartsWith("SELECT"))
                    {
                        cm.CommandType = CommandType.StoredProcedure;
                    }
                    else
                    {
                        cm.CommandType = CommandType.Text;
                    }

                    if (parameters != null)
                    {
                        cm.Parameters.AddRange(parameters);
                    }

                    cn.Open();
                    result = cm.ExecuteScalar();
                }
            }
            return result;
        }
    }
}