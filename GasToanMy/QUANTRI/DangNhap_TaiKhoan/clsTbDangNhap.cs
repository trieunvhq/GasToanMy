﻿///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'tbDangNhap'
// Generated by LLBLGen v1.3.5996.26197 Final on: Friday, March 19, 2021, 3:20:06 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GasToanMy
{
	/// <summary>
	/// Purpose: Data Access class for the table 'tbDangNhap'.
	/// </summary>
	public partial class clsTbDangNhap : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bBThanhPham, m_bBQuanLySanXuat, m_bBThietLapBanDau, m_bBDaiLy, m_bBLuongChamCong, m_bBCaTruong, m_bBAdmin, m_bBQuyNganHang, m_bBQuanTri, m_bNgungTheoDoi, m_bTonTai, m_bBBanThanhPham, m_bBBanHang, m_bBMuaHang, m_bBNguyenPhuLieu;
			private SqlInt32		m_iID_DangNhap, m_iID_NhanSu;
			private SqlString		m_sMatKhau, m_sTen;
		#endregion


		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public clsTbDangNhap()
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
		///		 <LI>sTen</LI>
		///		 <LI>sMatKhau</LI>
		///		 <LI>bTonTai</LI>
		///		 <LI>bNgungTheoDoi</LI>
		///		 <LI>iID_NhanSu. May be SqlInt32.Null</LI>
		///		 <LI>bBMuaHang</LI>
		///		 <LI>bBBanHang</LI>
		///		 <LI>bBNguyenPhuLieu</LI>
		///		 <LI>bBBanThanhPham</LI>
		///		 <LI>bBDaiLy</LI>
		///		 <LI>bBThanhPham</LI>
		///		 <LI>bBQuanLySanXuat</LI>
		///		 <LI>bBLuongChamCong</LI>
		///		 <LI>bBQuyNganHang</LI>
		///		 <LI>bBQuanTri</LI>
		///		 <LI>bBCaTruong</LI>
		///		 <LI>bBAdmin</LI>
		///		 <LI>bBThietLapBanDau. May be SqlBoolean.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iID_DangNhap</LI>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbDangNhap_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTen", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTen));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMatKhau", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMatKhau));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bNgungTheoDoi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bNgungTheoDoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NhanSu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhanSu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbMuaHang", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBMuaHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbBanHang", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBBanHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbNguyenPhuLieu", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBNguyenPhuLieu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbBanThanhPham", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBBanThanhPham));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbDaiLy", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBDaiLy));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbThanhPham", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBThanhPham));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbQuanLySanXuat", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBQuanLySanXuat));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbLuongChamCong", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBLuongChamCong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbQuyNganHang", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBQuyNganHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbQuanTri", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBQuanTri));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbCaTruong", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBCaTruong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbAdmin", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBAdmin));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbThietLapBanDau", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBThietLapBanDau));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DangNhap", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DangNhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iID_DangNhap = (SqlInt32)scmCmdToExecute.Parameters["@iID_DangNhap"].Value;
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_tbDangNhap_Insert' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbDangNhap::Insert::Error occured.", ex);
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
		///		 <LI>iID_DangNhap</LI>
		///		 <LI>sTen</LI>
		///		 <LI>sMatKhau</LI>
		///		 <LI>bTonTai</LI>
		///		 <LI>bNgungTheoDoi</LI>
		///		 <LI>iID_NhanSu. May be SqlInt32.Null</LI>
		///		 <LI>bBMuaHang</LI>
		///		 <LI>bBBanHang</LI>
		///		 <LI>bBNguyenPhuLieu</LI>
		///		 <LI>bBBanThanhPham</LI>
		///		 <LI>bBDaiLy</LI>
		///		 <LI>bBThanhPham</LI>
		///		 <LI>bBQuanLySanXuat</LI>
		///		 <LI>bBLuongChamCong</LI>
		///		 <LI>bBQuyNganHang</LI>
		///		 <LI>bBQuanTri</LI>
		///		 <LI>bBCaTruong</LI>
		///		 <LI>bBAdmin</LI>
		///		 <LI>bBThietLapBanDau. May be SqlBoolean.Null</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Update()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbDangNhap_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DangNhap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DangNhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sTen", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTen));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@sMatKhau", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sMatKhau));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bTonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bNgungTheoDoi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bNgungTheoDoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_NhanSu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhanSu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbMuaHang", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBMuaHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbBanHang", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBBanHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbNguyenPhuLieu", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBNguyenPhuLieu));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbBanThanhPham", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBBanThanhPham));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbDaiLy", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBDaiLy));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbThanhPham", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBThanhPham));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbQuanLySanXuat", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBQuanLySanXuat));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbLuongChamCong", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBLuongChamCong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbQuyNganHang", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBQuyNganHang));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbQuanTri", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBQuanTri));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbCaTruong", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBCaTruong));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbAdmin", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBAdmin));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@bbThietLapBanDau", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bBThietLapBanDau));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_tbDangNhap_Update' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbDangNhap::Update::Error occured.", ex);
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
		///		 <LI>iID_DangNhap</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		/// </UL>
		/// </remarks>
		public override bool Delete()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbDangNhap_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DangNhap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DangNhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_tbDangNhap_Delete' reported the ErrorCode: " + m_iErrorCode);
				}

				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbDangNhap::Delete::Error occured.", ex);
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
		///		 <LI>iID_DangNhap</LI>
		/// </UL>
		/// Properties set after a succesful call of this method: 
		/// <UL>
		///		 <LI>iErrorCode</LI>
		///		 <LI>iID_DangNhap</LI>
		///		 <LI>sTen</LI>
		///		 <LI>sMatKhau</LI>
		///		 <LI>bTonTai</LI>
		///		 <LI>bNgungTheoDoi</LI>
		///		 <LI>iID_NhanSu</LI>
		///		 <LI>bBMuaHang</LI>
		///		 <LI>bBBanHang</LI>
		///		 <LI>bBNguyenPhuLieu</LI>
		///		 <LI>bBBanThanhPham</LI>
		///		 <LI>bBDaiLy</LI>
		///		 <LI>bBThanhPham</LI>
		///		 <LI>bBQuanLySanXuat</LI>
		///		 <LI>bBLuongChamCong</LI>
		///		 <LI>bBQuyNganHang</LI>
		///		 <LI>bBQuanTri</LI>
		///		 <LI>bBCaTruong</LI>
		///		 <LI>bBAdmin</LI>
		///		 <LI>bBThietLapBanDau</LI>
		/// </UL>
		/// Will fill all properties corresponding with a field in the table with the value of the row selected.
		/// </remarks>
		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_tbDangNhap_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbDangNhap");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DangNhap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DangNhap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

				// Open connection.
				m_scoMainConnection.Open();

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

				if(m_iErrorCode != (int)LLBLError.AllOk)
				{
					// Throw error.
					throw new Exception("Stored Procedure 'pr_tbDangNhap_SelectOne' reported the ErrorCode: " + m_iErrorCode);
				}

				if(dtToReturn.Rows.Count > 0)
				{
					m_iID_DangNhap = (Int32)dtToReturn.Rows[0]["ID_DangNhap"];
					m_sTen = (string)dtToReturn.Rows[0]["Ten"];
					m_sMatKhau = (string)dtToReturn.Rows[0]["MatKhau"];
					m_bTonTai = (bool)dtToReturn.Rows[0]["TonTai"];
					m_bNgungTheoDoi = (bool)dtToReturn.Rows[0]["NgungTheoDoi"];
					m_iID_NhanSu = dtToReturn.Rows[0]["ID_NhanSu"] == System.DBNull.Value ? SqlInt32.Null : (Int32)dtToReturn.Rows[0]["ID_NhanSu"];
					m_bBMuaHang = (bool)dtToReturn.Rows[0]["bMuaHang"];
					m_bBBanHang = (bool)dtToReturn.Rows[0]["bBanHang"];
					m_bBNguyenPhuLieu = (bool)dtToReturn.Rows[0]["bNguyenPhuLieu"];
					m_bBBanThanhPham = (bool)dtToReturn.Rows[0]["bBanThanhPham"];
					m_bBDaiLy = (bool)dtToReturn.Rows[0]["bDaiLy"];
					m_bBThanhPham = (bool)dtToReturn.Rows[0]["bThanhPham"];
					m_bBQuanLySanXuat = (bool)dtToReturn.Rows[0]["bQuanLySanXuat"];
					m_bBLuongChamCong = (bool)dtToReturn.Rows[0]["bLuongChamCong"];
					m_bBQuyNganHang = (bool)dtToReturn.Rows[0]["bQuyNganHang"];
					m_bBQuanTri = (bool)dtToReturn.Rows[0]["bQuanTri"];
					m_bBCaTruong = (bool)dtToReturn.Rows[0]["bCaTruong"];
					m_bBAdmin = (bool)dtToReturn.Rows[0]["bAdmin"];
					m_bBThietLapBanDau = dtToReturn.Rows[0]["bThietLapBanDau"] == System.DBNull.Value ? SqlBoolean.Null : (bool)dtToReturn.Rows[0]["bThietLapBanDau"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
                // some error occured. Bubble it to caller and encapsulate Exception object
                MessageBox.Show("Lỗi:... " + ex.Message, "Mất kết nối!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw new Exception("Stored Procedure 'pr_tbDangNhap_SelectOne' reported the ErrorCode: " + ex);
			}
			finally
			{
				// Close connection.
				m_scoMainConnection.Close();
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}

        //
        public bool SelectOne_Ten(string Ten)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[Tr_tbDangNhap_SelectOne_Ten]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("tbDangNhap");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sTen", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, Ten));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iErrorCode));

                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                sdaAdapter.Fill(dtToReturn);
                m_iErrorCode = (SqlInt32)scmCmdToExecute.Parameters["@iErrorCode"].Value;

                if (m_iErrorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    throw new Exception("Stored Procedure 'Tr_tbDangNhap_SelectOne_Ten' reported the ErrorCode: " + m_iErrorCode);
                }

                if (dtToReturn.Rows.Count > 0)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("clsTbDangNhap::Tr_tbDangNhap_SelectOne_Ten::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_tbDangNhap_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("tbDangNhap");
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
					throw new Exception("Stored Procedure 'pr_tbDangNhap_SelectAll' reported the ErrorCode: " + m_iErrorCode);
				}

				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsTbDangNhap::SelectAll::Error occured.", ex);
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
		public SqlInt32 iID_DangNhap
		{
			get
			{
				return m_iID_DangNhap;
			}
			set
			{
				SqlInt32 iID_DangNhapTmp = (SqlInt32)value;
				if(iID_DangNhapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_DangNhap", "iID_DangNhap can't be NULL");
				}
				m_iID_DangNhap = value;
			}
		}


		public SqlString sTen
		{
			get
			{
				return m_sTen;
			}
			set
			{
				SqlString sTenTmp = (SqlString)value;
				if(sTenTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sTen", "sTen can't be NULL");
				}
				m_sTen = value;
			}
		}


		public SqlString sMatKhau
		{
			get
			{
				return m_sMatKhau;
			}
			set
			{
				SqlString sMatKhauTmp = (SqlString)value;
				if(sMatKhauTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("sMatKhau", "sMatKhau can't be NULL");
				}
				m_sMatKhau = value;
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


		public SqlInt32 iID_NhanSu
		{
			get
			{
				return m_iID_NhanSu;
			}
			set
			{
				SqlInt32 iID_NhanSuTmp = (SqlInt32)value;
				if(iID_NhanSuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iID_NhanSu", "iID_NhanSu can't be NULL");
				}
				m_iID_NhanSu = value;
			}
		}


		public SqlBoolean bBMuaHang
		{
			get
			{
				return m_bBMuaHang;
			}
			set
			{
				SqlBoolean bBMuaHangTmp = (SqlBoolean)value;
				if(bBMuaHangTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bBMuaHang", "bBMuaHang can't be NULL");
				}
				m_bBMuaHang = value;
			}
		}


		public SqlBoolean bBBanHang
		{
			get
			{
				return m_bBBanHang;
			}
			set
			{
				SqlBoolean bBBanHangTmp = (SqlBoolean)value;
				if(bBBanHangTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bBBanHang", "bBBanHang can't be NULL");
				}
				m_bBBanHang = value;
			}
		}


		public SqlBoolean bBNguyenPhuLieu
		{
			get
			{
				return m_bBNguyenPhuLieu;
			}
			set
			{
				SqlBoolean bBNguyenPhuLieuTmp = (SqlBoolean)value;
				if(bBNguyenPhuLieuTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bBNguyenPhuLieu", "bBNguyenPhuLieu can't be NULL");
				}
				m_bBNguyenPhuLieu = value;
			}
		}


		public SqlBoolean bBBanThanhPham
		{
			get
			{
				return m_bBBanThanhPham;
			}
			set
			{
				SqlBoolean bBBanThanhPhamTmp = (SqlBoolean)value;
				if(bBBanThanhPhamTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bBBanThanhPham", "bBBanThanhPham can't be NULL");
				}
				m_bBBanThanhPham = value;
			}
		}


		public SqlBoolean bBDaiLy
		{
			get
			{
				return m_bBDaiLy;
			}
			set
			{
				SqlBoolean bBDaiLyTmp = (SqlBoolean)value;
				if(bBDaiLyTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bBDaiLy", "bBDaiLy can't be NULL");
				}
				m_bBDaiLy = value;
			}
		}


		public SqlBoolean bBThanhPham
		{
			get
			{
				return m_bBThanhPham;
			}
			set
			{
				SqlBoolean bBThanhPhamTmp = (SqlBoolean)value;
				if(bBThanhPhamTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bBThanhPham", "bBThanhPham can't be NULL");
				}
				m_bBThanhPham = value;
			}
		}


		public SqlBoolean bBQuanLySanXuat
		{
			get
			{
				return m_bBQuanLySanXuat;
			}
			set
			{
				SqlBoolean bBQuanLySanXuatTmp = (SqlBoolean)value;
				if(bBQuanLySanXuatTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bBQuanLySanXuat", "bBQuanLySanXuat can't be NULL");
				}
				m_bBQuanLySanXuat = value;
			}
		}


		public SqlBoolean bBLuongChamCong
		{
			get
			{
				return m_bBLuongChamCong;
			}
			set
			{
				SqlBoolean bBLuongChamCongTmp = (SqlBoolean)value;
				if(bBLuongChamCongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bBLuongChamCong", "bBLuongChamCong can't be NULL");
				}
				m_bBLuongChamCong = value;
			}
		}


		public SqlBoolean bBQuyNganHang
		{
			get
			{
				return m_bBQuyNganHang;
			}
			set
			{
				SqlBoolean bBQuyNganHangTmp = (SqlBoolean)value;
				if(bBQuyNganHangTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bBQuyNganHang", "bBQuyNganHang can't be NULL");
				}
				m_bBQuyNganHang = value;
			}
		}


		public SqlBoolean bBQuanTri
		{
			get
			{
				return m_bBQuanTri;
			}
			set
			{
				SqlBoolean bBQuanTriTmp = (SqlBoolean)value;
				if(bBQuanTriTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bBQuanTri", "bBQuanTri can't be NULL");
				}
				m_bBQuanTri = value;
			}
		}


		public SqlBoolean bBCaTruong
		{
			get
			{
				return m_bBCaTruong;
			}
			set
			{
				SqlBoolean bBCaTruongTmp = (SqlBoolean)value;
				if(bBCaTruongTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bBCaTruong", "bBCaTruong can't be NULL");
				}
				m_bBCaTruong = value;
			}
		}


		public SqlBoolean bBAdmin
		{
			get
			{
				return m_bBAdmin;
			}
			set
			{
				SqlBoolean bBAdminTmp = (SqlBoolean)value;
				if(bBAdminTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bBAdmin", "bBAdmin can't be NULL");
				}
				m_bBAdmin = value;
			}
		}


		public SqlBoolean bBThietLapBanDau
		{
			get
			{
				return m_bBThietLapBanDau;
			}
			set
			{
				SqlBoolean bBThietLapBanDauTmp = (SqlBoolean)value;
				if(bBThietLapBanDauTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("bBThietLapBanDau", "bBThietLapBanDau can't be NULL");
				}
				m_bBThietLapBanDau = value;
			}
		}
		#endregion
	}
}
