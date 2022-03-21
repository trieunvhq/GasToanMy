///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'NganHang_tbTaiKhoanguiNganHang'
// Generated by LLBLGen v1.3.5996.26197 Final on: Sunday, January 17, 2021, 11:02:29 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace GasToanMy
{
	/// <summary>
	/// Purpose: Data Access class for the table 'NganHang_tbTaiKhoanguiNganHang'.
	/// </summary>
	public partial class clsNganHang_tbTaiKhoanguiNganHang : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bNgungTheoDoi, m_bTienUSD, m_bTonTai, m_bBoolUyNhiemThu, m_bBoolUyNhhiemChi;
			private SqlDateTime		m_daNgayChungTu;
			private SqlDouble		m_fTiGia, m_fCo_TKTienGui, m_fNo_TKTienGui;
			private SqlInt32		m_iID_ThamChieuChungTu, m_iID_TaiKhoanTienGui, m_iID_TaiKhoanDoiUng, m_iID_TaiKhoanGuiNganHang;
			private SqlString		m_sSoUyNhiemChi, m_sSoUyNhiemThu, m_sDienGiai;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public clsNganHang_tbTaiKhoanguiNganHang()
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
		///		 <LI>daNgayChungTu</LI>
		///		 <LI>sSoUyNhiemChi</LI>
		///		 <LI>sSoUyNhiemThu</LI>
		///		 <LI>sDienGiai</LI>
		///		 <LI>iID_TaiKhoanTienGui</LI>
		///		 <LI>iID_TaiKhoanDoiUng</LI>
		///		 <LI>bBoolUyNhhiemChi</LI>
		///		 <LI>bBoolUyNhiemThu</LI>
		///		 <LI>bTonTai</LI>
		///		 <LI>bNgungTheoDoi</LI>
		///		 <LI>fNo_TKTienGui</LI>
		///		 <LI>fCo_TKTienGui</LI>
		///		 <LI>bTienUSD</LI>
		///		 <LI>fTiGia</LI>
		///		 <LI>iID_ThamChieuChungTu</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iID_TaiKhoanGuiNganHang</LI>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_NganHang_tbTaiKhoanguiNganHang_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daNgayChungTu", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgayChungTu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSoUyNhiemChi", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSoUyNhiemChi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSoUyNhiemThu", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSoUyNhiemThu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDienGiai", SqlDbType.NVarChar, 350, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDienGiai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_TaiKhoanTienGui", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_TaiKhoanTienGui));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_TaiKhoanDoiUng", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_TaiKhoanDoiUng));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bboolUyNhhiemChi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBoolUyNhhiemChi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bboolUyNhiemThu", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBoolUyNhiemThu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bNgungTheoDoi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bNgungTheoDoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNo_TKTienGui", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNo_TKTienGui));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fCo_TKTienGui", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fCo_TKTienGui));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTienUSD", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTienUSD));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fTiGia", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTiGia));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ThamChieuChungTu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ThamChieuChungTu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_TaiKhoanGuiNganHang", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_TaiKhoanGuiNganHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iID_TaiKhoanGuiNganHang = (SqlInt32)scmCmdToExecute.Parameters["@iID_TaiKhoanGuiNganHang"].Value;
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_NganHang_tbTaiKhoanguiNganHang_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsNganHang_tbTaiKhoanguiNganHang::Insert::Error occured.", ex);
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
		///		 <LI>iID_TaiKhoanGuiNganHang</LI>
		///		 <LI>daNgayChungTu</LI>
		///		 <LI>sSoUyNhiemChi</LI>
		///		 <LI>sSoUyNhiemThu</LI>
		///		 <LI>sDienGiai</LI>
		///		 <LI>iID_TaiKhoanTienGui</LI>
		///		 <LI>iID_TaiKhoanDoiUng</LI>
		///		 <LI>bBoolUyNhhiemChi</LI>
		///		 <LI>bBoolUyNhiemThu</LI>
		///		 <LI>bTonTai</LI>
		///		 <LI>bNgungTheoDoi</LI>
		///		 <LI>fNo_TKTienGui</LI>
		///		 <LI>fCo_TKTienGui</LI>
		///		 <LI>bTienUSD</LI>
		///		 <LI>fTiGia</LI>
		///		 <LI>iID_ThamChieuChungTu</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Update()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_NganHang_tbTaiKhoanguiNganHang_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_TaiKhoanGuiNganHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_TaiKhoanGuiNganHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@daNgayChungTu", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgayChungTu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSoUyNhiemChi", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSoUyNhiemChi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSoUyNhiemThu", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSoUyNhiemThu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDienGiai", SqlDbType.NVarChar, 350, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDienGiai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_TaiKhoanTienGui", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_TaiKhoanTienGui));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_TaiKhoanDoiUng", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_TaiKhoanDoiUng));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bboolUyNhhiemChi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBoolUyNhhiemChi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bboolUyNhiemThu", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBoolUyNhiemThu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bNgungTheoDoi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bNgungTheoDoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fNo_TKTienGui", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNo_TKTienGui));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fCo_TKTienGui", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fCo_TKTienGui));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTienUSD", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTienUSD));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@fTiGia", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTiGia));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ThamChieuChungTu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ThamChieuChungTu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_NganHang_tbTaiKhoanguiNganHang_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsNganHang_tbTaiKhoanguiNganHang::Update::Error occured.", ex);
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
		///		 <LI>iID_TaiKhoanGuiNganHang</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_NganHang_tbTaiKhoanguiNganHang_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_TaiKhoanGuiNganHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_TaiKhoanGuiNganHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_NganHang_tbTaiKhoanguiNganHang_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsNganHang_tbTaiKhoanguiNganHang::Delete::Error occured.", ex);
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
		///		 <LI>iID_TaiKhoanGuiNganHang</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		///		 <LI>iID_TaiKhoanGuiNganHang</LI>
		///		 <LI>daNgayChungTu</LI>
		///		 <LI>sSoUyNhiemChi</LI>
		///		 <LI>sSoUyNhiemThu</LI>
		///		 <LI>sDienGiai</LI>
		///		 <LI>iID_TaiKhoanTienGui</LI>
		///		 <LI>iID_TaiKhoanDoiUng</LI>
		///		 <LI>bBoolUyNhhiemChi</LI>
		///		 <LI>bBoolUyNhiemThu</LI>
		///		 <LI>bTonTai</LI>
		///		 <LI>bNgungTheoDoi</LI>
		///		 <LI>fNo_TKTienGui</LI>
		///		 <LI>fCo_TKTienGui</LI>
		///		 <LI>bTienUSD</LI>
		///		 <LI>fTiGia</LI>
		///		 <LI>iID_ThamChieuChungTu</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_NganHang_tbTaiKhoanguiNganHang_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("NganHang_tbTaiKhoanguiNganHang");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_TaiKhoanGuiNganHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_TaiKhoanGuiNganHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_NganHang_tbTaiKhoanguiNganHang_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_iID_TaiKhoanGuiNganHang = (Int32)dtToReturn.Rows[0]["ID_TaiKhoanGuiNganHang"];
					m_daNgayChungTu = (DateTime)dtToReturn.Rows[0]["NgayChungTu"];
					m_sSoUyNhiemChi = (string)dtToReturn.Rows[0]["SoUyNhiemChi"];
					m_sSoUyNhiemThu = (string)dtToReturn.Rows[0]["SoUyNhiemThu"];
					m_sDienGiai = (string)dtToReturn.Rows[0]["DienGiai"];
					m_iID_TaiKhoanTienGui = (Int32)dtToReturn.Rows[0]["ID_TaiKhoanTienGui"];
					m_iID_TaiKhoanDoiUng = (Int32)dtToReturn.Rows[0]["ID_TaiKhoanDoiUng"];
					m_bBoolUyNhhiemChi = (bool)dtToReturn.Rows[0]["boolUyNhhiemChi"];
					m_bBoolUyNhiemThu = (bool)dtToReturn.Rows[0]["boolUyNhiemThu"];
					m_bTonTai = (bool)dtToReturn.Rows[0]["TonTai"];
					m_bNgungTheoDoi = (bool)dtToReturn.Rows[0]["NgungTheoDoi"];
					m_fNo_TKTienGui = (double)dtToReturn.Rows[0]["No_TKTienGui"];
					m_fCo_TKTienGui = (double)dtToReturn.Rows[0]["Co_TKTienGui"];
					m_bTienUSD = (bool)dtToReturn.Rows[0]["TienUSD"];
					m_fTiGia = (double)dtToReturn.Rows[0]["TiGia"];
					m_iID_ThamChieuChungTu = (Int32)dtToReturn.Rows[0]["ID_ThamChieuChungTu"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsNganHang_tbTaiKhoanguiNganHang::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_NganHang_tbTaiKhoanguiNganHang_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("NganHang_tbTaiKhoanguiNganHang");
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
					throw new Exception("Stored Procedure 'pr_NganHang_tbTaiKhoanguiNganHang_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsNganHang_tbTaiKhoanguiNganHang::SelectAll::Error occured.", ex);
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
		public SqlInt32 iID_TaiKhoanGuiNganHang
		{
			get
			{
				return m_iID_TaiKhoanGuiNganHang;
			}
			set
			{
				SqlInt32 iID_TaiKhoanGuiNganHangTmp = (SqlInt32)value;
				if(iID_TaiKhoanGuiNganHangTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_TaiKhoanGuiNganHang", "iID_TaiKhoanGuiNganHang can't be NULL");
				}
				m_iID_TaiKhoanGuiNganHang = value;
			}
		}


		public SqlDateTime daNgayChungTu
		{
			get
			{
				return m_daNgayChungTu;
			}
			set
			{
				SqlDateTime daNgayChungTuTmp = (SqlDateTime)value;
				if(daNgayChungTuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("daNgayChungTu", "daNgayChungTu can't be NULL");
				}
				m_daNgayChungTu = value;
			}
		}


		public SqlString sSoUyNhiemChi
		{
			get
			{
				return m_sSoUyNhiemChi;
			}
			set
			{
				SqlString sSoUyNhiemChiTmp = (SqlString)value;
				if(sSoUyNhiemChiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sSoUyNhiemChi", "sSoUyNhiemChi can't be NULL");
				}
				m_sSoUyNhiemChi = value;
			}
		}


		public SqlString sSoUyNhiemThu
		{
			get
			{
				return m_sSoUyNhiemThu;
			}
			set
			{
				SqlString sSoUyNhiemThuTmp = (SqlString)value;
				if(sSoUyNhiemThuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sSoUyNhiemThu", "sSoUyNhiemThu can't be NULL");
				}
				m_sSoUyNhiemThu = value;
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


		public SqlInt32 iID_TaiKhoanTienGui
		{
			get
			{
				return m_iID_TaiKhoanTienGui;
			}
			set
			{
				SqlInt32 iID_TaiKhoanTienGuiTmp = (SqlInt32)value;
				if(iID_TaiKhoanTienGuiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_TaiKhoanTienGui", "iID_TaiKhoanTienGui can't be NULL");
				}
				m_iID_TaiKhoanTienGui = value;
			}
		}


		public SqlInt32 iID_TaiKhoanDoiUng
		{
			get
			{
				return m_iID_TaiKhoanDoiUng;
			}
			set
			{
				SqlInt32 iID_TaiKhoanDoiUngTmp = (SqlInt32)value;
				if(iID_TaiKhoanDoiUngTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_TaiKhoanDoiUng", "iID_TaiKhoanDoiUng can't be NULL");
				}
				m_iID_TaiKhoanDoiUng = value;
			}
		}


		public SqlBoolean bBoolUyNhhiemChi
		{
			get
			{
				return m_bBoolUyNhhiemChi;
			}
			set
			{
				SqlBoolean bBoolUyNhhiemChiTmp = (SqlBoolean)value;
				if(bBoolUyNhhiemChiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bBoolUyNhhiemChi", "bBoolUyNhhiemChi can't be NULL");
				}
				m_bBoolUyNhhiemChi = value;
			}
		}


		public SqlBoolean bBoolUyNhiemThu
		{
			get
			{
				return m_bBoolUyNhiemThu;
			}
			set
			{
				SqlBoolean bBoolUyNhiemThuTmp = (SqlBoolean)value;
				if(bBoolUyNhiemThuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bBoolUyNhiemThu", "bBoolUyNhiemThu can't be NULL");
				}
				m_bBoolUyNhiemThu = value;
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


		public SqlDouble fNo_TKTienGui
		{
			get
			{
				return m_fNo_TKTienGui;
			}
			set
			{
				SqlDouble fNo_TKTienGuiTmp = (SqlDouble)value;
				if(fNo_TKTienGuiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fNo_TKTienGui", "fNo_TKTienGui can't be NULL");
				}
				m_fNo_TKTienGui = value;
			}
		}


		public SqlDouble fCo_TKTienGui
		{
			get
			{
				return m_fCo_TKTienGui;
			}
			set
			{
				SqlDouble fCo_TKTienGuiTmp = (SqlDouble)value;
				if(fCo_TKTienGuiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fCo_TKTienGui", "fCo_TKTienGui can't be NULL");
				}
				m_fCo_TKTienGui = value;
			}
		}


		public SqlBoolean bTienUSD
		{
			get
			{
				return m_bTienUSD;
			}
			set
			{
				SqlBoolean bTienUSDTmp = (SqlBoolean)value;
				if(bTienUSDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bTienUSD", "bTienUSD can't be NULL");
				}
				m_bTienUSD = value;
			}
		}


		public SqlDouble fTiGia
		{
			get
			{
				return m_fTiGia;
			}
			set
			{
				SqlDouble fTiGiaTmp = (SqlDouble)value;
				if(fTiGiaTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("fTiGia", "fTiGia can't be NULL");
				}
				m_fTiGia = value;
			}
		}


		public SqlInt32 iID_ThamChieuChungTu
		{
			get
			{
				return m_iID_ThamChieuChungTu;
			}
			set
			{
				SqlInt32 iID_ThamChieuChungTuTmp = (SqlInt32)value;
				if(iID_ThamChieuChungTuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_ThamChieuChungTu", "iID_ThamChieuChungTu can't be NULL");
				}
				m_iID_ThamChieuChungTu = value;
			}
		}
		#endregion
	}
}