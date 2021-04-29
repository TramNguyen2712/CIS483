using CIS483.Empl.DAL;
using CIS483.Empl.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS483.Empl.BL
{
	public class StaffBL
	{
		#region Constructors

		public StaffBL()
		{

		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the Staff table.
		/// </summary>
		public static Staff Staff_Select(Staff _StaffLine)
		{
			Staff StaffLine = new Staff();
			try
			{
				StaffDAL IO = new StaffDAL();
				SqlDataReader myReader = IO.Staff_Select(_StaffLine);
				while (myReader.Read())
				{
					if (myReader["StaffID"] != DBNull.Value)
					{
						StaffLine.staffID = (int)myReader["StaffID"];
					}
					if (myReader["LastName"] != DBNull.Value)
					{
						StaffLine.lastName = (string)myReader["LastName"];
					}
					if (myReader["MiddLeName"] != DBNull.Value)
					{
						StaffLine.middLeName = (string)myReader["MiddLeName"];
					}
					if (myReader["FirstName"] != DBNull.Value)
					{
						StaffLine.firstName = (string)myReader["FirstName"];
					}
					if (myReader["Gender"] != DBNull.Value)
					{
						StaffLine.gender = (string)myReader["Gender"];
					}
					if (myReader["Position"] != DBNull.Value)
					{
						StaffLine.position = (string)myReader["Position"];
					}
					if (myReader["HiredDate"] != DBNull.Value)
					{
						StaffLine.hiredDate = (DateTime)myReader["HiredDate"];
					}
					if (myReader["Salary"] != DBNull.Value)
					{
						StaffLine.salary = (decimal)myReader["Salary"];
					}
				}
				myReader.Close();
			}
			catch (Exception ex)
			{
				if (ConfigurationManager.AppSettings["RethrowErrors"] == "true") { throw ex; }
				return new Staff();
			}
			return StaffLine;
		}


		/// <summary>
		/// Select a record to the Staff table.
		/// </summary>
		public static List<Staff> Staff_SelectList()
		{
			List<Staff> StaffList = new List<Staff>();
			try
			{
				StaffDAL IO = new StaffDAL();
				SqlDataReader myReader = IO.Staff_SelectList();
				while (myReader.Read())
				{

					Staff StaffLine = new Staff();
					if (myReader["StaffID"] != DBNull.Value)
					{
						StaffLine.staffID = (int)myReader["StaffID"];
					}
					if (myReader["LastName"] != DBNull.Value)
					{
						StaffLine.lastName = (string)myReader["LastName"];
					}
					if (myReader["MiddLeName"] != DBNull.Value)
					{
						StaffLine.middLeName = (string)myReader["MiddLeName"];
					}
					if (myReader["FirstName"] != DBNull.Value)
					{
						StaffLine.firstName = (string)myReader["FirstName"];
					}
					if (myReader["Gender"] != DBNull.Value)
					{
						StaffLine.gender = (string)myReader["Gender"];
					}
					if (myReader["Position"] != DBNull.Value)
					{
						StaffLine.position = (string)myReader["Position"];
					}
					if (myReader["HiredDate"] != DBNull.Value)
					{
						StaffLine.hiredDate = (DateTime)myReader["HiredDate"];
					}
					if (myReader["Salary"] != DBNull.Value)
					{
						StaffLine.salary = (decimal)myReader["Salary"];
					}
					StaffList.Add(StaffLine);

				}
				myReader.Close();
			}
			catch (Exception ex)
			{
				if (ConfigurationManager.AppSettings["RethrowErrors"] == "true") { throw ex; }
				return new List<Staff>();
			}
			return StaffList;
		}


		/// <summary>
		/// Updates a record to the Staff table.
		/// </summary>
		public static bool Staff_Update(Staff _StaffLine)
		{
			StaffDAL IO = new StaffDAL();
			return IO.Staff_Update(_StaffLine);

		}
		/// <summary>
		/// Saves a record to the Staff table.
		/// </summary>
		public static bool Staff_Insert(Staff _StaffLine)
		{
			StaffDAL IO = new StaffDAL();
			return IO.Staff_Insert(_StaffLine);

		}
		/// <summary>
		/// Deletes a record from the Staff table by its primary key.
		/// </summary>
		public static bool Staff_Delete(Staff _StaffLine)
		{
			StaffDAL IO = new StaffDAL();
			return IO.Staff_Delete(_StaffLine);

		}

		#endregion
	}
}
