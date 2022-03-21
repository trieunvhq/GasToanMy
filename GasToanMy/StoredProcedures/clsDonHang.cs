///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'DonHang'
// Generated by LLBLGen v1.3.5996.26197 Final on: Monday, March 21, 2022, 9:47:14 AM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace GasToanMy
{
	/// <summary>
	/// Purpose: Data Access class for the table 'DonHang'.
	/// </summary>
	public class clsDonHang : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlString		m_sRecordStatus, m_sType;
			private SqlDateTime		m_daCreateDate, m_daUpdateDate;
			private SqlDecimal		m_dcGiaBan;
			private SqlInt32		m_iID, m_iSoLuong;
			private SqlString		m_sCreateUser, m_sCodeSanPham, m_sUpdateUser, m_sCode, m_sDescription, m_sCodeUser, m_sPaymentStatus, m_sCodeKhachHang;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public clsDonHang()
		{
			// Nothing for now.
		}


		/// <summary>
		/// Purpose: Insert method. This method will insert one new row into the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>sType. May be SqlString.Null</LI>
		///		 <LI>sCode. May be SqlString.Null</LI>
		///		 <LI>sCodeSanPham. May be SqlString.Null</LI>
		///		 <LI>sCodeKhachHang. May be SqlString.Null</LI>
		///		 <LI>sCodeUser. May be SqlString.Null</LI>
		///		 <LI>iSoLuong. May be SqlInt32.Null</LI>
		///		 <LI>dcGiaBan. May be SqlDecimal.Null</LI>
		///		 <LI>sDescription. May be SqlString.Null</LI>
		///		 <LI>sRecordStatus. May be SqlString.Null</LI>
		///		 <LI>sPaymentStatus. May be SqlString.Null</LI>
		///		 <LI>daCreateDate. May be SqlDateTime.Null</LI>
		///		 <LI>sCreateUser. May be SqlString.Null</LI>
		///		 <LI>daUpdateDate. May be SqlDateTime.Null</LI>
		///		 <LI>sUpdateUser. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iID</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[DonHang_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sType", SqlDbType.Char, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sType));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCode));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCodeSanPham", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCodeSanPham));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCodeKhachHang", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCodeKhachHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCodeUser", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCodeUser));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iSoLuong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iSoLuong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcGiaBan", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcGiaBan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDescription", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDescription));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sRecordStatus", SqlDbType.Char, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sRecordStatus));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPaymentStatus", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPaymentStatus));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daCreateDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daCreateDate));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCreateUser", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCreateUser));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daUpdateDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daUpdateDate));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sUpdateUser", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUpdateUser));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iID = (SqlInt32)scmCmdToExecute.Parameters["@iID"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDonHang::Insert::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Update method. This method will Update one existing row in the database.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>iID</LI>
		///		 <LI>sType. May be SqlString.Null</LI>
		///		 <LI>sCode. May be SqlString.Null</LI>
		///		 <LI>sCodeSanPham. May be SqlString.Null</LI>
		///		 <LI>sCodeKhachHang. May be SqlString.Null</LI>
		///		 <LI>sCodeUser. May be SqlString.Null</LI>
		///		 <LI>iSoLuong. May be SqlInt32.Null</LI>
		///		 <LI>dcGiaBan. May be SqlDecimal.Null</LI>
		///		 <LI>sDescription. May be SqlString.Null</LI>
		///		 <LI>sRecordStatus. May be SqlString.Null</LI>
		///		 <LI>sPaymentStatus. May be SqlString.Null</LI>
		///		 <LI>daCreateDate. May be SqlDateTime.Null</LI>
		///		 <LI>sCreateUser. May be SqlString.Null</LI>
		///		 <LI>daUpdateDate. May be SqlDateTime.Null</LI>
		///		 <LI>sUpdateUser. May be SqlString.Null</LI>
		/// </UL>
		/// </remarks>
		public override bool Update()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[DonHang_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sType", SqlDbType.Char, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sType));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCode));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCodeSanPham", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCodeSanPham));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCodeKhachHang", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCodeKhachHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCodeUser", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCodeUser));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iSoLuong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iSoLuong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@dcGiaBan", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcGiaBan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDescription", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDescription));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sRecordStatus", SqlDbType.Char, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sRecordStatus));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sPaymentStatus", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sPaymentStatus));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daCreateDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daCreateDate));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sCreateUser", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCreateUser));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daUpdateDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daUpdateDate));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sUpdateUser", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUpdateUser));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDonHang::Update::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Delete method. This method will Delete one existing row in the database, based on the Primary Key.
		/// </summary>
		/// <returns>True if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>iID</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[DonHang_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDonHang::Delete::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		/// <summary>
		/// Purpose: Select method. This method will Select one existing row from the database, based on the Primary Key.
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// Properties needed for this method: 
		/// <UL>
		///		 <LI>iID</LI>
		/// </UL>
		///		 <LI>iID</LI>
		///		 <LI>sType</LI>
		///		 <LI>sCode</LI>
		///		 <LI>sCodeSanPham</LI>
		///		 <LI>sCodeKhachHang</LI>
		///		 <LI>sCodeUser</LI>
		///		 <LI>iSoLuong</LI>
		///		 <LI>dcGiaBan</LI>
		///		 <LI>sDescription</LI>
		///		 <LI>sRecordStatus</LI>
		///		 <LI>sPaymentStatus</LI>
		///		 <LI>daCreateDate</LI>
		///		 <LI>sCreateUser</LI>
		///		 <LI>daUpdateDate</LI>
		///		 <LI>sUpdateUser</LI>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[DonHang_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DonHang");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				if(dtToReturn.Rows.Count > 0)
				{
					m_iID = (Int32)dtToReturn.Rows[0]["ID"];
					m_sType = dtToReturn.Rows[0]["Type"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Type"];
					m_sCode = dtToReturn.Rows[0]["Code"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Code"];
					m_sCodeSanPham = dtToReturn.Rows[0]["CodeSanPham"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["CodeSanPham"];
					m_sCodeKhachHang = dtToReturn.Rows[0]["CodeKhachHang"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["CodeKhachHang"];
					m_sCodeUser = dtToReturn.Rows[0]["CodeUser"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["CodeUser"];
					m_iSoLuong = dtToReturn.Rows[0]["SoLuong"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["SoLuong"];
					m_dcGiaBan = dtToReturn.Rows[0]["GiaBan"] == System.DBNull.Value ? SqlDecimal.Null : (Decimal)dtToReturn.Rows[0]["GiaBan"];
					m_sDescription = dtToReturn.Rows[0]["Description"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["Description"];
					m_sRecordStatus = dtToReturn.Rows[0]["RecordStatus"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["RecordStatus"];
					m_sPaymentStatus = dtToReturn.Rows[0]["PaymentStatus"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["PaymentStatus"];
					m_daCreateDate = dtToReturn.Rows[0]["CreateDate"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["CreateDate"];
					m_sCreateUser = dtToReturn.Rows[0]["CreateUser"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["CreateUser"];
					m_daUpdateDate = dtToReturn.Rows[0]["UpdateDate"] == System.DBNull.Value ? SqlDateTime.Null : (DateTime)dtToReturn.Rows[0]["UpdateDate"];
					m_sUpdateUser = dtToReturn.Rows[0]["UpdateUser"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["UpdateUser"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDonHang::SelectOne::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		/// <summary>
		/// Purpose: SelectAll method. This method will Select all rows from the table.
		/// </summary>
		/// <returns>DataTable object if succeeded, otherwise an Exception is thrown. </returns>
		/// <remarks>
		/// </remarks>
		public override DataTable SelectAll()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[DonHang_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DonHang");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDonHang::SelectAll::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		#region Class Property Declarations
		public SqlInt32 iID
		{
			get
			{
				return m_iID;
			}
			set
			{
				SqlInt32 iIDTmp = (SqlInt32)value;
				if(iIDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID", "iID can't be NULL");
				}
				m_iID = value;
			}
		}


		public SqlString sType
		{
			get
			{
				return m_sType;
			}
			set
			{
				SqlString sTypeTmp = (SqlString)value;
				if(sTypeTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sType", "sType can't be NULL");
				}
				m_sType = value;
			}
		}


		public SqlString sCode
		{
			get
			{
				return m_sCode;
			}
			set
			{
				SqlString sCodeTmp = (SqlString)value;
				if(sCodeTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sCode", "sCode can't be NULL");
				}
				m_sCode = value;
			}
		}


		public SqlString sCodeSanPham
		{
			get
			{
				return m_sCodeSanPham;
			}
			set
			{
				SqlString sCodeSanPhamTmp = (SqlString)value;
				if(sCodeSanPhamTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sCodeSanPham", "sCodeSanPham can't be NULL");
				}
				m_sCodeSanPham = value;
			}
		}


		public SqlString sCodeKhachHang
		{
			get
			{
				return m_sCodeKhachHang;
			}
			set
			{
				SqlString sCodeKhachHangTmp = (SqlString)value;
				if(sCodeKhachHangTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sCodeKhachHang", "sCodeKhachHang can't be NULL");
				}
				m_sCodeKhachHang = value;
			}
		}


		public SqlString sCodeUser
		{
			get
			{
				return m_sCodeUser;
			}
			set
			{
				SqlString sCodeUserTmp = (SqlString)value;
				if(sCodeUserTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sCodeUser", "sCodeUser can't be NULL");
				}
				m_sCodeUser = value;
			}
		}


		public SqlInt32 iSoLuong
		{
			get
			{
				return m_iSoLuong;
			}
			set
			{
				SqlInt32 iSoLuongTmp = (SqlInt32)value;
				if(iSoLuongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iSoLuong", "iSoLuong can't be NULL");
				}
				m_iSoLuong = value;
			}
		}


		public SqlDecimal dcGiaBan
		{
			get
			{
				return m_dcGiaBan;
			}
			set
			{
				SqlDecimal dcGiaBanTmp = (SqlDecimal)value;
				if(dcGiaBanTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("dcGiaBan", "dcGiaBan can't be NULL");
				}
				m_dcGiaBan = value;
			}
		}


		public SqlString sDescription
		{
			get
			{
				return m_sDescription;
			}
			set
			{
				SqlString sDescriptionTmp = (SqlString)value;
				if(sDescriptionTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sDescription", "sDescription can't be NULL");
				}
				m_sDescription = value;
			}
		}


		public SqlString sRecordStatus
		{
			get
			{
				return m_sRecordStatus;
			}
			set
			{
				SqlString sRecordStatusTmp = (SqlString)value;
				if(sRecordStatusTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sRecordStatus", "sRecordStatus can't be NULL");
				}
				m_sRecordStatus = value;
			}
		}


		public SqlString sPaymentStatus
		{
			get
			{
				return m_sPaymentStatus;
			}
			set
			{
				SqlString sPaymentStatusTmp = (SqlString)value;
				if(sPaymentStatusTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sPaymentStatus", "sPaymentStatus can't be NULL");
				}
				m_sPaymentStatus = value;
			}
		}


		public SqlDateTime daCreateDate
		{
			get
			{
				return m_daCreateDate;
			}
			set
			{
				SqlDateTime daCreateDateTmp = (SqlDateTime)value;
				if(daCreateDateTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("daCreateDate", "daCreateDate can't be NULL");
				}
				m_daCreateDate = value;
			}
		}


		public SqlString sCreateUser
		{
			get
			{
				return m_sCreateUser;
			}
			set
			{
				SqlString sCreateUserTmp = (SqlString)value;
				if(sCreateUserTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sCreateUser", "sCreateUser can't be NULL");
				}
				m_sCreateUser = value;
			}
		}


		public SqlDateTime daUpdateDate
		{
			get
			{
				return m_daUpdateDate;
			}
			set
			{
				SqlDateTime daUpdateDateTmp = (SqlDateTime)value;
				if(daUpdateDateTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("daUpdateDate", "daUpdateDate can't be NULL");
				}
				m_daUpdateDate = value;
			}
		}


		public SqlString sUpdateUser
		{
			get
			{
				return m_sUpdateUser;
			}
			set
			{
				SqlString sUpdateUserTmp = (SqlString)value;
				if(sUpdateUserTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sUpdateUser", "sUpdateUser can't be NULL");
				}
				m_sUpdateUser = value;
			}
		}
		#endregion
	}
}