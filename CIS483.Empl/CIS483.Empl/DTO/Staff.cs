using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS483.Empl.DTO
{
	public class Staff 
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the Staff class.
		/// </summary>
		public Staff()
		{
		}


        #endregion

        #region Properties
        [Required(ErrorMessage = "{0} is required!")]
        [Display(Name = "Staff ID")]
        [Key]
		public int staffID { get; set; }

		/// <summary>
		/// Gets or sets the lastName value.
		/// </summary>
		/// 
		[Required(ErrorMessage = "{0} is required!")]

		[Display(Name = "Last Name")]
		public string lastName { get; set; }

		/// <summary>
		/// Gets or sets the middLeName value.
		/// </summary>
		/// 
		[Display(Name = "Middle Name")]

		public string middLeName { get; set; }

		/// <summary>
		/// Gets or sets the firstName value.
		/// </summary>
		///
		[Required(ErrorMessage = "{0} is required!")]
		[Display(Name = "First Name")]

		public string firstName { get; set; }

		/// <summary>
		/// Gets or sets the gender value.
		/// </summary>
		/// 
		[Required(ErrorMessage = "{0} is required!")]
		[Display(Name = "Gender")]
		public string gender { get; set; }

		/// <summary>
		/// Gets or sets the position value.
		/// </summary>
		/// 
		[Required(ErrorMessage = "{0} is required!")]
		[Display(Name = "Position")]
		public string position { get; set; }

		/// <summary>
		/// Gets or sets the hiredDate value.
		/// </summary>
		/// 
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
		[Required(ErrorMessage = "{0} is required!")]
		[Display(Name = "Hired Date")]
		public DateTime hiredDate { get; set; }

		/// <summary>
		/// Gets or sets the salary value.
		/// </summary>
		/// 
		[Required(ErrorMessage = "{0} is required!")]
		[Display(Name = "Salary")]
		public decimal salary { get; set; }

		#endregion
	
	}
}

