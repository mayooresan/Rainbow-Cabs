using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DBLayer
{
    public class DBConnect
    {
        // static method can be directly accessed by class method
        public static DataTable GetDataTable(string SQLCommand, string constr)
        {

            SqlDataAdapter da = new SqlDataAdapter(SQLCommand, constr);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();

            return dt;
        }

        /// <summary>
        /// Execute an SQL command
        /// </summary>
        /// <param name="SQLCmd">SQl Statement</param>
        /// <param name="constr">Connection String</param>
        public static void ExecuteSQLCommand(string SQLCmd, string constr)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(SQLCmd, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// Execute a stored procedure
        /// </summary>
        /// <param name="SpName">Stored procedure name</param>
        /// <param name="Constr">Connection string</param>
        /// <param name="sqlparams">paramters passed</param>
        public static void ExecuteStoredProc(string SpName,
                                            string Constr,
                                            SqlParameter[] sqlparams)
        {
            SqlConnection con = new SqlConnection(Constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SpName;
            cmd.Parameters.AddRange(sqlparams);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// Excutes stored procedures in a transaction
        /// </summary>
        /// <param name="constr">Connection string</param>
        /// <param name="sps">List of stored procedures</param>
        public static void ExcuteTransaction(string Constr,
                                            StoredProc[] sps)
        {
            SqlConnection con = new SqlConnection(Constr);
            SqlTransaction tr = null;

            try
            {
                con.Open();
                tr = con.BeginTransaction();

                foreach (StoredProc sp in sps)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = tr;
                    cmd.CommandText = sp.StoredProcedureName;
                    cmd.Parameters.AddRange(sp.SqlParams);
                    cmd.ExecuteNonQuery();
                }

                tr.Commit();
            }
            catch (Exception ex)
            {
                tr.Rollback();
                throw new Exception("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
