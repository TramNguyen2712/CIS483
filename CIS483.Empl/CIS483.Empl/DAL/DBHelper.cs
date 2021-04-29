using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS483.Empl.DAL
{
	public class DBHelper
	{
		#region Fields

		public SqlConnection _sqlConn;

		#endregion

		#region Constructors

		public DBHelper()
		{
			try
			{
				this._sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeUser"].ConnectionString);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		#endregion
	}
}
