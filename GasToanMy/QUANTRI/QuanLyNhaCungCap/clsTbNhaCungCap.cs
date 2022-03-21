using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace GasToanMy
{
	public partial class clsTbNhaCungCap : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bTonTai, m_bNgungTheoDoi, m_bKhoa;
			private SqlInt32		m_iID_NhaCungCap, m_iID_TaiKhoanKeToan;
			private SqlString		m_sTenNhaCungCap, m_sChiNhanh, m_sTinh_ThanhPho, m_sEmail, m_sMaNhaCungCap, m_sMaSoThue, m_sSoDienThoai, m_sDienGiai, m_sDiaChi, m_sTenNganHang, m_sSoTaiKhoan, m_sNguoiLienHe;
		#endregion


		public clsTbNhaCungCap()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbNhaCungCap_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMaNhaCungCap", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMaNhaCungCap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMaSoThue", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMaSoThue));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTenNhaCungCap", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTenNhaCungCap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sNguoiLienHe", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNguoiLienHe));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDiaChi", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDiaChi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDienGiai", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDienGiai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSoDienThoai", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSoDienThoai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sEmail", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sEmail));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSoTaiKhoan", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSoTaiKhoan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTenNganHang", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTenNganHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTinh_ThanhPho", SqlDbType.NVarChar, 150, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTinh_ThanhPho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sChiNhanh", SqlDbType.NVarChar, 350, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sChiNhanh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bNgungTheoDoi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bNgungTheoDoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_TaiKhoanKeToan", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_TaiKhoanKeToan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bKhoa", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bKhoa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NhaCungCap", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhaCungCap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iID_NhaCungCap = (SqlInt32)scmCmdToExecute.Parameters["@iID_NhaCungCap"].Value;
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_tbNhaCungCap_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbNhaCungCap::Insert::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		public override bool Update()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbNhaCungCap_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NhaCungCap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhaCungCap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMaNhaCungCap", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMaNhaCungCap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMaSoThue", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMaSoThue));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTenNhaCungCap", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTenNhaCungCap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sNguoiLienHe", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNguoiLienHe));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDiaChi", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDiaChi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sDienGiai", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDienGiai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSoDienThoai", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSoDienThoai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sEmail", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sEmail));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sSoTaiKhoan", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSoTaiKhoan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTenNganHang", SqlDbType.NVarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTenNganHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTinh_ThanhPho", SqlDbType.NVarChar, 150, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTinh_ThanhPho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sChiNhanh", SqlDbType.NVarChar, 350, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sChiNhanh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bNgungTheoDoi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bNgungTheoDoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_TaiKhoanKeToan", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_TaiKhoanKeToan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bKhoa", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bKhoa));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_tbNhaCungCap_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbNhaCungCap::Update::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		public override bool Delete()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbNhaCungCap_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NhaCungCap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhaCungCap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_tbNhaCungCap_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbNhaCungCap::Delete::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
			}
		}


		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbNhaCungCap_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbNhaCungCap");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NhaCungCap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhaCungCap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_tbNhaCungCap_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_iID_NhaCungCap = (Int32)dtToReturn.Rows[0]["ID_NhaCungCap"];
					m_sMaNhaCungCap = (string)dtToReturn.Rows[0]["MaNhaCungCap"];
					m_sMaSoThue = (string)dtToReturn.Rows[0]["MaSoThue"];
					m_sTenNhaCungCap = (string)dtToReturn.Rows[0]["TenNhaCungCap"];
					m_sNguoiLienHe = (string)dtToReturn.Rows[0]["NguoiLienHe"];
					m_sDiaChi = (string)dtToReturn.Rows[0]["DiaChi"];
					m_sDienGiai = (string)dtToReturn.Rows[0]["DienGiai"];
					m_sSoDienThoai = (string)dtToReturn.Rows[0]["SoDienThoai"];
					m_sEmail = (string)dtToReturn.Rows[0]["Email"];
					m_sSoTaiKhoan = (string)dtToReturn.Rows[0]["SoTaiKhoan"];
					m_sTenNganHang = (string)dtToReturn.Rows[0]["TenNganHang"];
					m_sTinh_ThanhPho = (string)dtToReturn.Rows[0]["Tinh_ThanhPho"];
					m_sChiNhanh = (string)dtToReturn.Rows[0]["ChiNhanh"];
					m_bNgungTheoDoi = (bool)dtToReturn.Rows[0]["NgungTheoDoi"];
					m_bTonTai = (bool)dtToReturn.Rows[0]["TonTai"];
					m_iID_TaiKhoanKeToan = (Int32)dtToReturn.Rows[0]["ID_TaiKhoanKeToan"];
					m_bKhoa = (bool)dtToReturn.Rows[0]["Khoa"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbNhaCungCap::SelectOne::Error occured.", ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		public override DataTable SelectAll()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbNhaCungCap_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbNhaCungCap");
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
					throw new Exception("Stored Procedure 'pr_tbNhaCungCap_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbNhaCungCap::SelectAll::Error occured.", ex);
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
		public SqlInt32 iID_NhaCungCap
		{
			get
			{
				return m_iID_NhaCungCap;
			}
			set
			{
				SqlInt32 iID_NhaCungCapTmp = (SqlInt32)value;
				if(iID_NhaCungCapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_NhaCungCap", "iID_NhaCungCap can't be NULL");
				}
				m_iID_NhaCungCap = value;
			}
		}


		public SqlString sMaNhaCungCap
		{
			get
			{
				return m_sMaNhaCungCap;
			}
			set
			{
				SqlString sMaNhaCungCapTmp = (SqlString)value;
				if(sMaNhaCungCapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sMaNhaCungCap", "sMaNhaCungCap can't be NULL");
				}
				m_sMaNhaCungCap = value;
			}
		}


		public SqlString sMaSoThue
		{
			get
			{
				return m_sMaSoThue;
			}
			set
			{
				SqlString sMaSoThueTmp = (SqlString)value;
				if(sMaSoThueTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sMaSoThue", "sMaSoThue can't be NULL");
				}
				m_sMaSoThue = value;
			}
		}


		public SqlString sTenNhaCungCap
		{
			get
			{
				return m_sTenNhaCungCap;
			}
			set
			{
				SqlString sTenNhaCungCapTmp = (SqlString)value;
				if(sTenNhaCungCapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sTenNhaCungCap", "sTenNhaCungCap can't be NULL");
				}
				m_sTenNhaCungCap = value;
			}
		}


		public SqlString sNguoiLienHe
		{
			get
			{
				return m_sNguoiLienHe;
			}
			set
			{
				SqlString sNguoiLienHeTmp = (SqlString)value;
				if(sNguoiLienHeTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sNguoiLienHe", "sNguoiLienHe can't be NULL");
				}
				m_sNguoiLienHe = value;
			}
		}


		public SqlString sDiaChi
		{
			get
			{
				return m_sDiaChi;
			}
			set
			{
				SqlString sDiaChiTmp = (SqlString)value;
				if(sDiaChiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sDiaChi", "sDiaChi can't be NULL");
				}
				m_sDiaChi = value;
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


		public SqlString sSoDienThoai
		{
			get
			{
				return m_sSoDienThoai;
			}
			set
			{
				SqlString sSoDienThoaiTmp = (SqlString)value;
				if(sSoDienThoaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sSoDienThoai", "sSoDienThoai can't be NULL");
				}
				m_sSoDienThoai = value;
			}
		}


		public SqlString sEmail
		{
			get
			{
				return m_sEmail;
			}
			set
			{
				SqlString sEmailTmp = (SqlString)value;
				if(sEmailTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sEmail", "sEmail can't be NULL");
				}
				m_sEmail = value;
			}
		}


		public SqlString sSoTaiKhoan
		{
			get
			{
				return m_sSoTaiKhoan;
			}
			set
			{
				SqlString sSoTaiKhoanTmp = (SqlString)value;
				if(sSoTaiKhoanTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sSoTaiKhoan", "sSoTaiKhoan can't be NULL");
				}
				m_sSoTaiKhoan = value;
			}
		}


		public SqlString sTenNganHang
		{
			get
			{
				return m_sTenNganHang;
			}
			set
			{
				SqlString sTenNganHangTmp = (SqlString)value;
				if(sTenNganHangTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sTenNganHang", "sTenNganHang can't be NULL");
				}
				m_sTenNganHang = value;
			}
		}


		public SqlString sTinh_ThanhPho
		{
			get
			{
				return m_sTinh_ThanhPho;
			}
			set
			{
				SqlString sTinh_ThanhPhoTmp = (SqlString)value;
				if(sTinh_ThanhPhoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sTinh_ThanhPho", "sTinh_ThanhPho can't be NULL");
				}
				m_sTinh_ThanhPho = value;
			}
		}


		public SqlString sChiNhanh
		{
			get
			{
				return m_sChiNhanh;
			}
			set
			{
				SqlString sChiNhanhTmp = (SqlString)value;
				if(sChiNhanhTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sChiNhanh", "sChiNhanh can't be NULL");
				}
				m_sChiNhanh = value;
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


		public SqlInt32 iID_TaiKhoanKeToan
		{
			get
			{
				return m_iID_TaiKhoanKeToan;
			}
			set
			{
				SqlInt32 iID_TaiKhoanKeToanTmp = (SqlInt32)value;
				if(iID_TaiKhoanKeToanTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_TaiKhoanKeToan", "iID_TaiKhoanKeToan can't be NULL");
				}
				m_iID_TaiKhoanKeToan = value;
			}
		}


		public SqlBoolean bKhoa
		{
			get
			{
				return m_bKhoa;
			}
			set
			{
				SqlBoolean bKhoaTmp = (SqlBoolean)value;
				if(bKhoaTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bKhoa", "bKhoa can't be NULL");
				}
				m_bKhoa = value;
			}
		}
		#endregion
	}
}
