///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'DongKien_TbNhapKho_ChiTietNhapKho'
// Generated by LLBLGen v1.3.5996.26197 Final on: Wednesday, October 20, 2021, 4:06:55 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace GasToanMy
{
	/// <summary>
	/// Purpose: Data Access class for the table 'DongKien_TbNhapKho_ChiTietNhapKho'.
	/// </summary>
	public partial class clsDongKien_TbNhapKho_ChiTietNhapKho : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bNgungTheoDoi, m_bTonTai, m_bBoolTonDauKy, m_bDaNhapKho;
			private SqlDouble		m_fThanhTien, m_fSoLuongNhap, m_fDonGia;
			private SqlInt32		m_iID_NhapKho_DongKien, m_iID_ChiTietNhapKho, m_iID_VTHH;
			private SqlString		m_sGhiChu;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public clsDongKien_TbNhapKho_ChiTietNhapKho()
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
		///		 <LI>iID_NhapKho_DongKien</LI>
		///		 <LI>iID_VTHH</LI>
		///		 <LI>fSoLuongNhap</LI>
		///		 <LI>fDonGia</LI>
		///		 <LI>fThanhTien</LI>
		///		 <LI>bTonTai</LI>
		///		 <LI>bNgungTheoDoi</LI>
		///		 <LI>sGhiChu</LI>
		///		 <LI>bDaNhapKho</LI>
		///		 <LI>bBoolTonDauKy</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iID_ChiTietNhapKho</LI>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DongKien_TbNhapKho_ChiTietNhapKho_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NhapKho_DongKien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhapKho_DongKien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_VTHH", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_VTHH));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fSoLuongNhap", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSoLuongNhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fDonGia", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDonGia));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fThanhTien", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fThanhTien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bNgungTheoDoi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bNgungTheoDoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sGhiChu", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sGhiChu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bDaNhapKho", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bDaNhapKho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bBoolTonDauKy", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBoolTonDauKy));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietNhapKho", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietNhapKho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iID_ChiTietNhapKho = (SqlInt32)scmCmdToExecute.Parameters["@iID_ChiTietNhapKho"].Value;
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_DongKien_TbNhapKho_ChiTietNhapKho_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDongKien_TbNhapKho_ChiTietNhapKho::Insert::Error occured.", ex);
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
		///		 <LI>iID_ChiTietNhapKho</LI>
		///		 <LI>iID_NhapKho_DongKien</LI>
		///		 <LI>iID_VTHH</LI>
		///		 <LI>fSoLuongNhap</LI>
		///		 <LI>fDonGia</LI>
		///		 <LI>fThanhTien</LI>
		///		 <LI>bTonTai</LI>
		///		 <LI>bNgungTheoDoi</LI>
		///		 <LI>sGhiChu</LI>
		///		 <LI>bDaNhapKho</LI>
		///		 <LI>bBoolTonDauKy</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Update()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DongKien_TbNhapKho_ChiTietNhapKho_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietNhapKho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietNhapKho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NhapKho_DongKien", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhapKho_DongKien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_VTHH", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_VTHH));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fSoLuongNhap", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSoLuongNhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fDonGia", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fDonGia));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fThanhTien", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fThanhTien));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bNgungTheoDoi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bNgungTheoDoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sGhiChu", SqlDbType.NVarChar, 250, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sGhiChu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bDaNhapKho", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bDaNhapKho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bBoolTonDauKy", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBoolTonDauKy));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_DongKien_TbNhapKho_ChiTietNhapKho_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDongKien_TbNhapKho_ChiTietNhapKho::Update::Error occured.", ex);
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
		///		 <LI>iID_ChiTietNhapKho</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DongKien_TbNhapKho_ChiTietNhapKho_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietNhapKho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietNhapKho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_DongKien_TbNhapKho_ChiTietNhapKho_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDongKien_TbNhapKho_ChiTietNhapKho::Delete::Error occured.", ex);
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
		///		 <LI>iID_ChiTietNhapKho</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		///		 <LI>iID_ChiTietNhapKho</LI>
		///		 <LI>iID_NhapKho_DongKien</LI>
		///		 <LI>iID_VTHH</LI>
		///		 <LI>fSoLuongNhap</LI>
		///		 <LI>fDonGia</LI>
		///		 <LI>fThanhTien</LI>
		///		 <LI>bTonTai</LI>
		///		 <LI>bNgungTheoDoi</LI>
		///		 <LI>sGhiChu</LI>
		///		 <LI>bDaNhapKho</LI>
		///		 <LI>bBoolTonDauKy</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DongKien_TbNhapKho_ChiTietNhapKho_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DongKien_TbNhapKho_ChiTietNhapKho");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietNhapKho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietNhapKho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_DongKien_TbNhapKho_ChiTietNhapKho_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_iID_ChiTietNhapKho = (Int32)dtToReturn.Rows[0]["ID_ChiTietNhapKho"];
					m_iID_NhapKho_DongKien = (Int32)dtToReturn.Rows[0]["ID_NhapKho_DongKien"];
					m_iID_VTHH = (Int32)dtToReturn.Rows[0]["ID_VTHH"];
					m_fSoLuongNhap = (double)dtToReturn.Rows[0]["SoLuongNhap"];
					m_fDonGia = (double)dtToReturn.Rows[0]["DonGia"];
					m_fThanhTien = (double)dtToReturn.Rows[0]["ThanhTien"];
					m_bTonTai = (bool)dtToReturn.Rows[0]["TonTai"];
					m_bNgungTheoDoi = (bool)dtToReturn.Rows[0]["NgungTheoDoi"];
					m_sGhiChu = (string)dtToReturn.Rows[0]["GhiChu"];
					m_bDaNhapKho = (bool)dtToReturn.Rows[0]["DaNhapKho"];
					m_bBoolTonDauKy = (bool)dtToReturn.Rows[0]["BoolTonDauKy"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDongKien_TbNhapKho_ChiTietNhapKho::SelectOne::Error occured.", ex);
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
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override DataTable SelectAll()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DongKien_TbNhapKho_ChiTietNhapKho_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DongKien_TbNhapKho_ChiTietNhapKho");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_DongKien_TbNhapKho_ChiTietNhapKho_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDongKien_TbNhapKho_ChiTietNhapKho::SelectAll::Error occured.", ex);
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
		public SqlInt32 iID_ChiTietNhapKho
		{
			get
			{
				return m_iID_ChiTietNhapKho;
			}
			set
			{
				SqlInt32 iID_ChiTietNhapKhoTmp = (SqlInt32)value;
				if(iID_ChiTietNhapKhoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_ChiTietNhapKho", "iID_ChiTietNhapKho can't be NULL");
				}
				m_iID_ChiTietNhapKho = value;
			}
		}


		public SqlInt32 iID_NhapKho_DongKien
		{
			get
			{
				return m_iID_NhapKho_DongKien;
			}
			set
			{
				SqlInt32 iID_NhapKho_DongKienTmp = (SqlInt32)value;
				if(iID_NhapKho_DongKienTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_NhapKho_DongKien", "iID_NhapKho_DongKien can't be NULL");
				}
				m_iID_NhapKho_DongKien = value;
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


		public SqlDouble fSoLuongNhap
		{
			get
			{
				return m_fSoLuongNhap;
			}
			set
			{
				SqlDouble fSoLuongNhapTmp = (SqlDouble)value;
				if(fSoLuongNhapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fSoLuongNhap", "fSoLuongNhap can't be NULL");
				}
				m_fSoLuongNhap = value;
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


		public SqlBoolean bTonTai
		{
			get
			{
				return m_bTonTai;
			}
			set
			{
				SqlBoolean bTonTaiTmp = (SqlBoolean)value;
				if(bTonTaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bTonTai", "bTonTai can't be NULL");
				}
				m_bTonTai = value;
			}
		}


		public SqlBoolean bNgungTheoDoi
		{
			get
			{
				return m_bNgungTheoDoi;
			}
			set
			{
				SqlBoolean bNgungTheoDoiTmp = (SqlBoolean)value;
				if(bNgungTheoDoiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bNgungTheoDoi", "bNgungTheoDoi can't be NULL");
				}
				m_bNgungTheoDoi = value;
			}
		}


		public SqlString sGhiChu
		{
			get
			{
				return m_sGhiChu;
			}
			set
			{
				SqlString sGhiChuTmp = (SqlString)value;
				if(sGhiChuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sGhiChu", "sGhiChu can't be NULL");
				}
				m_sGhiChu = value;
			}
		}


		public SqlBoolean bDaNhapKho
		{
			get
			{
				return m_bDaNhapKho;
			}
			set
			{
				SqlBoolean bDaNhapKhoTmp = (SqlBoolean)value;
				if(bDaNhapKhoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bDaNhapKho", "bDaNhapKho can't be NULL");
				}
				m_bDaNhapKho = value;
			}
		}


		public SqlBoolean bBoolTonDauKy
		{
			get
			{
				return m_bBoolTonDauKy;
			}
			set
			{
				SqlBoolean bBoolTonDauKyTmp = (SqlBoolean)value;
				if(bBoolTonDauKyTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bBoolTonDauKy", "bBoolTonDauKy can't be NULL");
				}
				m_bBoolTonDauKy = value;
			}
		}
		#endregion
	}
}
