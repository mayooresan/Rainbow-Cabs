using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DBLayer
{
    /// <summary>
    /// Abstraction of a stored procedure execution
    /// </summary>
    public class StoredProc
    {
        private string _StoredProcedureName;
        private SqlParameter[] _SqlParams;

        /// <summary>
        /// Name of the stored procedure
        /// </summary>
        public string StoredProcedureName
        {
            get { return _StoredProcedureName; }
            set { _StoredProcedureName = value; }
        }

        /// <summary>
        /// SQL paramters to be passed to the stored procedure
        /// </summary>
        public SqlParameter[] SqlParams
        {
            get { return _SqlParams; }
            set { _SqlParams = value; }
        }

        /// <summary>
        /// Creates an object with a procedure name and parameters
        /// </summary>
        /// <param name="SpName">Name of the stored procedure</param>
        /// <param name="paramSQl">parameter array</param>
        public StoredProc(string SpName, SqlParameter[] paramSQl)
        {
            //initiation
            _StoredProcedureName = SpName;
            _SqlParams = paramSQl;
        }

    }
}
