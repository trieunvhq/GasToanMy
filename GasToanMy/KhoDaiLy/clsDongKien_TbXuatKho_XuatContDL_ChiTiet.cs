///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'DongKien_TbXuatKho_XuatContDL_ChiTiet'
// Generated by LLBLGen v1.3.5996.26197 Final on: Wednesday, December 1, 2021, 2:48:16 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace GasToanMy
{
	/// <summary>
	/// Purpose: Data Access class for the table 'DongKien_TbXuatKho_XuatContDL_ChiTiet'.
	/// </summary>
	public class clsDongKien_TbXuatKho_XuatContDL_ChiTiet : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlDouble		m_fDonGia, m_fThanhTien, m_fSoLuongXuat;
			private SqlInt32		m_iID_ChiTietXuatKho, m_iID_XuatContDongKien, m_iID_VTHH;
			private SqlString		m_sDienGiai;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public clsDongKien_TbXuatKho_XuatContDL_ChiTiet()
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
		///		 <LI>iID_XuatContDongKien. May be SqlInt32.Null</LI>
		///		 <LI>iID_VTHH</LI>
		///		 <LI>fSoLuongXuat</LI>
		///		 <LI>fDonGia</LI>
		///		 <LI>fThanhTien</LI>
		///		 <LI>sDienGiai. May be SqlString.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iID_ChiTietXuatKho</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[Tr_DongKien_TbXuatKho_XuatContDL_ChiTiet_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_XuatContDongKien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_XuatContDongKien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_VTHH", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_VTHH));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fSoLuongXuat", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSoLuongXuat));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fDonGia", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDonGia));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fThanhTien", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fThanhTien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDienGiai", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDienGiai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietXuatKho", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietXuatKho));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iID_ChiTietXuatKho = (SqlInt32)scmCmdToExecute.Parameters["@iID_ChiTietXuatKho"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDongKien_TbXuatKho_XuatContDL_ChiTiet::Insert::Error occured.", ex);
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
		///		 <LI>iID_ChiTietXuatKho</LI>
		///		 <LI>iID_XuatContDongKien. May be SqlInt32.Null</LI>
		///		 <LI>iID_VTHH</LI>
		///		 <LI>fSoLuongXuat</LI>
		///		 <LI>fDonGia</LI>
		///		 <LI>fThanhTien</LI>
		///		 <LI>sDienGiai. May be SqlString.Null</LI>
		/// </UL>
		/// </remarks>
		public override bool Update()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[Tr_DongKien_TbXuatKho_XuatContDL_ChiTiet_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietXuatKho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietXuatKho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_XuatContDongKien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_XuatContDongKien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_VTHH", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_VTHH));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fSoLuongXuat", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSoLuongXuat));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fDonGia", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDonGia));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fThanhTien", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fThanhTien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDienGiai", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDienGiai));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDongKien_TbXuatKho_XuatContDL_ChiTiet::Update::Error occured.", ex);
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
		///		 <LI>iID_ChiTietXuatKho</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[Tr_DongKien_TbXuatKho_XuatContDL_ChiTiet_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietXuatKho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietXuatKho));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDongKien_TbXuatKho_XuatContDL_ChiTiet::Delete::Error occured.", ex);
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
		///		 <LI>iID_ChiTietXuatKho</LI>
		/// </UL>
		///		 <LI>iID_ChiTietXuatKho</LI>
		///		 <LI>iID_XuatContDongKien</LI>
		///		 <LI>iID_VTHH</LI>
		///		 <LI>fSoLuongXuat</LI>
		///		 <LI>fDonGia</LI>
		///		 <LI>fThanhTien</LI>
		///		 <LI>sDienGiai</LI>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[Tr_DongKien_TbXuatKho_XuatContDL_ChiTiet_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DongKien_TbXuatKho_XuatContDL_ChiTiet");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietXuatKho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietXuatKho));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				if(dtToReturn.Rows.Count > 0)
				{
					m_iID_ChiTietXuatKho = (Int32)dtToReturn.Rows[0]["ID_ChiTietXuatKho"];
					m_iID_XuatContDongKien = dtToReturn.Rows[0]["ID_XuatContDongKien"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_XuatContDongKien"];
					m_iID_VTHH = (Int32)dtToReturn.Rows[0]["ID_VTHH"];
					m_fSoLuongXuat = (double)dtToReturn.Rows[0]["SoLuongXuat"];
					m_fDonGia = (double)dtToReturn.Rows[0]["DonGia"];
					m_fThanhTien = (double)dtToReturn.Rows[0]["ThanhTien"];
					m_sDienGiai = dtToReturn.Rows[0]["DienGiai"] == System.DBNull.Value ? SqlString.Null : (string)dtToReturn.Rows[0]["DienGiai"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDongKien_TbXuatKho_XuatContDL_ChiTiet::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[Tr_DongKien_TbXuatKho_XuatContDL_ChiTiet_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DongKien_TbXuatKho_XuatContDL_ChiTiet");
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
				throw new Exception("clsDongKien_TbXuatKho_XuatContDL_ChiTiet::SelectAll::Error occured.", ex);
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
		public SqlInt32 iID_ChiTietXuatKho
		{
			get
			{
				return m_iID_ChiTietXuatKho;
			}
			set
			{
				SqlInt32 iID_ChiTietXuatKhoTmp = (SqlInt32)value;
				if(iID_ChiTietXuatKhoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_ChiTietXuatKho", "iID_ChiTietXuatKho can't be NULL");
				}
				m_iID_ChiTietXuatKho = value;
			}
		}


		public SqlInt32 iID_XuatContDongKien
		{
			get
			{
				return m_iID_XuatContDongKien;
			}
			set
			{
				SqlInt32 iID_XuatContDongKienTmp = (SqlInt32)value;
				if(iID_XuatContDongKienTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_XuatContDongKien", "iID_XuatContDongKien can't be NULL");
				}
				m_iID_XuatContDongKien = value;
			}
		}


		public SqlInt32 iID_VTHH
		{
			get
			{
				return m_iID_VTHH;
			}
			set
			{
				SqlInt32 iID_VTHHTmp = (SqlInt32)value;
				if(iID_VTHHTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_VTHH", "iID_VTHH can't be NULL");
				}
				m_iID_VTHH = value;
			}
		}


		public SqlDouble fSoLuongXuat
		{
			get
			{
				return m_fSoLuongXuat;
			}
			set
			{
				SqlDouble fSoLuongXuatTmp = (SqlDouble)value;
				if(fSoLuongXuatTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fSoLuongXuat", "fSoLuongXuat can't be NULL");
				}
				m_fSoLuongXuat = value;
			}
		}


		public SqlDouble fDonGia
		{
			get
			{
				return m_fDonGia;
			}
			set
			{
				SqlDouble fDonGiaTmp = (SqlDouble)value;
				if(fDonGiaTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fDonGia", "fDonGia can't be NULL");
				}
				m_fDonGia = value;
			}
		}


		public SqlDouble fThanhTien
		{
			get
			{
				return m_fThanhTien;
			}
			set
			{
				SqlDouble fThanhTienTmp = (SqlDouble)value;
				if(fThanhTienTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fThanhTien", "fThanhTien can't be NULL");
				}
				m_fThanhTien = value;
			}
		}


		public SqlString sDienGiai
		{
			get
			{
				return m_sDienGiai;
			}
			set
			{
				SqlString sDienGiaiTmp = (SqlString)value;
				if(sDienGiaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sDienGiai", "sDienGiai can't be NULL");
				}
				m_sDienGiai = value;
			}
		}
		#endregion
	}
}