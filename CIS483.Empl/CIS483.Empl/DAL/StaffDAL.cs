
using CIS483.Empl.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS483.Empl.DAL
{
	public class StaffDAL : DBHelper
	{
		#region Fields

		private SqlConnection _sqlConn;

		#endregion

		#region Constructors

		public StaffDAL()
		{

			_sqlConn = base._sqlConn;
		}

		#endregion

		#region Methods


		/// <summary>
		/// Selects a record from the Staff table by its primary key.
		/// </summary>
		public SqlDataReader Staff_Select(Staff StaffLine)
		{
			SqlCommand sqlCmd = new SqlCommand();
			sqlCmd.CommandType = CommandType.StoredProcedure;
			sqlCmd.CommandText = "usp_Staff_Select";
			sqlCmd.Connection = this._sqlConn;
			sqlCmd.Parameters.AddWithValue("@StaffID", StaffLine.staffID);
			if (this._sqlConn.State == ConnectionState.Closed)
			{
				this._sqlConn.Open();
			}
			SqlDataReader rd = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
			return rd;
		}


		/// <summary>
		/// Selects a record from the Staff table by its primary key.
		/// </summary>
		public SqlDataReader Staff_SelectList()
		{
			SqlCommand sqlCmd = new SqlCommand();
			sqlCmd.CommandType = CommandType.StoredProcedure;
			sqlCmd.CommandText = "usp_Staff_SelectList";
			sqlCmd.Connection = this._sqlConn;
			if (this._sqlConn.State == ConnectionState.Closed)
			{
				this._sqlConn.Open();
			}
			SqlDataReader rd = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection);
			return rd;
		}
		/// <summary>
		/// Saves a record to the Staff table.
		/// </summary>
		public bool Staff_Update(Staff StaffLine)
		{
			bool status = false;
			try
			{
				SqlCommand sqlCmd = new SqlCommand();
				sqlCmd.CommandType = CommandType.StoredProcedure;
				sqlCmd.CommandText = "usp_Staff_Update";
				sqlCmd.Connection = this._sqlConn;
				sqlCmd.Parameters.AddWithValue("@StaffID", StaffLine.staffID);
				sqlCmd.Parameters.AddWithValue("@LastName", StaffLine.lastName);
				sqlCmd.Parameters.AddWithValue("@MiddLeName", ((StaffLine.middLeName != null) ? (object)StaffLine.middLeName : DBNull.Value));
				sqlCmd.Parameters.AddWithValue("@FirstName", StaffLine.firstName);
				sqlCmd.Parameters.AddWithValue("@Gender", StaffLine.gender);
				sqlCmd.Parameters.AddWithValue("@Position", StaffLine.position );
				sqlCmd.Parameters.AddWithValue("@HiredDate", StaffLine.hiredDate);
				sqlCmd.Parameters.AddWithValue("@Salary", StaffLine.salary );
				if (this._sqlConn.State == ConnectionState.Closed)
				{
					this._sqlConn.Open();
				}
				int numberOfRecordsAffected = sqlCmd.ExecuteNonQuery();
				if (numberOfRecordsAffected > 0)
				{
					status = true;
				}
				this._sqlConn.Close();
			}
			catch (Exception ex)
			{
				if (ConfigurationManager.AppSettings["RethrowErrors"] == "true") { throw ex; }
				status = false;
			}
			return status;
		}

		/// <summary>
		/// Saves a record to the Staff table.
		/// </summary>
		public bool Staff_Insert(Staff StaffLine)
		{
			bool status = false;
			try
			{
				SqlCommand sqlCmd = new SqlCommand();
				sqlCmd.CommandType = CommandType.StoredProcedure;
				sqlCmd.CommandText = "usp_Staff_Insert";
				sqlCmd.Connection = this._sqlConn;
				sqlCmd.Parameters.AddWithValue("@LastName", StaffLine.lastName);
				sqlCmd.Parameters.AddWithValue("@MiddLeName", ((StaffLine.middLeName != null) ? (object)StaffLine.middLeName : DBNull.Value));
				sqlCmd.Parameters.AddWithValue("@FirstName", StaffLine.firstName);
				sqlCmd.Parameters.AddWithValue("@Gender", StaffLine.gender);
				sqlCmd.Parameters.AddWithValue("@Position", StaffLine.position);
				sqlCmd.Parameters.AddWithValue("@HiredDate", StaffLine.hiredDate);
				sqlCmd.Parameters.AddWithValue("@Salary", StaffLine.salary);
				if (this._sqlConn.State == ConnectionState.Closed)
				{
					this._sqlConn.Open();
				}
				int numberOfRecordsAffected = sqlCmd.ExecuteNonQuery();
				if (numberOfRecordsAffected > 0)
				{
					status = true;
				}
				this._sqlConn.Close();
			}
			catch (Exception ex)
			{
				if (ConfigurationManager.AppSettings["RethrowErrors"] == "true") { throw ex; }
				status = false;
			}
			return status;
		}



		/// <summary>
		/// Deletes a record from the Staff table by its primary key.
		/// </summary>
		public bool Staff_Delete(Staff StaffLine)
		{
			bool status = false;
			try
			{
				SqlCommand sqlCmd = new SqlCommand();
				sqlCmd.CommandType = CommandType.StoredProcedure;
				sqlCmd.CommandText = "usp_Staff_Delete";
				sqlCmd.Connection = this._sqlConn;
				sqlCmd.Parameters.AddWithValue("@StaffID", StaffLine.staffID);
				if (this._sqlConn.State == ConnectionState.Closed)
				{
					this._sqlConn.Open();
				}
				int numberOfRecordsAffected = sqlCmd.ExecuteNonQuery();
				if (numberOfRecordsAffected > 0)
				{
					status = true;
				}
				this._sqlConn.Close();
			}
			catch (Exception ex)
			{
				if (ConfigurationManager.AppSettings["RethrowErrors"] == "true") { throw ex; }
				status = false;
			}
			return status;
		}


		#endregion
	}
}
