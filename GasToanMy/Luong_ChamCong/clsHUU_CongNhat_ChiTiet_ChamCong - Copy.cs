///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'HUU_CongNhat_ChiTiet_ChamCong'
// Generated by LLBLGen v1.3.5996.26197 Final on: Thursday, December 31, 2020, 9:07:40 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace GasToanMy
{
	/// <summary>
	/// Purpose: Data Access class for the table 'HUU_CongNhat_ChiTiet_ChamCong'.
	/// </summary>
	public partial class clsHUU_CongNhat_ChiTiet_ChamCong : clsDBInteractionBase
	{
        //pr_HUU_CongNhat_ChiTiet_ChamCong_Update_SoTienTamUng
        public void Update_SoTienTamUng()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_CongNhat_ChiTiet_ChamCong_Update_SoTienTamUng]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietChamCong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietChamCong));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@dcTamUng", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcTamUng));
                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_CongNhat_ChiTiet_ChamCong_Update_SoTienTamUng::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public void Update_SoTienDaTraLuong_W_ID_CongNhanh_W_thang_Nam()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_CongNhat_ChiTiet_ChamCong_Update_SoTienDaTraLuong_W_ID_CongNhanh_W_thang_Nam]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongNhan", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongNhan));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iThang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iThang));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iNam", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iNam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@dcSoTienDaTraLuong", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcSoTienDaTraLuong));
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_CongNhat_ChiTiet_ChamCong_Update_SoTienDaTraLuong_W_ID_CongNhanh_W_thang_Nam::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public void Update_LuongSanLuong_LuongLonNhat_W_ID_CongNhan_W_thang_Nam()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_CongNhat_ChiTiet_ChamCong_Update_LuongSanLuong_LuongLonNhat_W_ID_CongNhan_W_thang_Nam]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongNhan", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongNhan));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iThang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iThang));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iNam", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iNam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@dcLuongSanLuong", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcLuongSanLuong));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@dcLuongLonNhat", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcLuongLonNhat));

                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_CongNhat_ChiTiet_ChamCong_Update_LuongSanLuong_LuongLonNhat_W_ID_CongNhan_W_thang_Nam::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public DataTable SelectAll_W_TenNhanVien()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_CongNhat_ChiTiet_ChamCong_SelectAll_W_TenNhanVien]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_HUU_CongNhat_ChiTiet_ChamCong_SelectAll_W_TenNhanVien");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@iThang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iThang));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@iNam", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iNam));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_CongNhat_ChiTiet_ChamCong_SelectAll_W_TenNhanVien", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public void Update_LuongCongNhat()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_CongNhat_ChiTiet_ChamCong_Update_LuongCongNhat]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietChamCong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietChamCong));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@dcLuongCongNhat", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcLuongCongNhat));
                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_CongNhat_ChiTiet_ChamCong_Update_LuongCongNhat::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public void Update_CongNhat_SanLuong_TangCa()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_CongNhat_ChiTiet_ChamCong_Update_CongNhat_SanLuong_TangCa]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietChamCong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietChamCong));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fSLTangCa", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSLTangCa));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay1", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay1));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay2", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay2));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay3", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay3));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay4", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay4));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay5", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay5));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay6", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay6));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay7", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay7));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay8", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay8));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay9", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay9));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay10", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay10));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay11", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay11));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay12", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay12));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay13", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay13));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay14", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay14));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay15", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay15));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay16", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay16));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay17", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay17));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay18", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay18));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay19", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay19));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay20", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay20));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay21", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay21));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay22", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay22));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay23", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay23));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay24", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay24));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay25", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay25));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay26", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay26));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay27", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay27));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay28", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay28));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay29", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay29));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay30", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay30));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTCNgay31", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTCNgay31));
                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_CongNhat_ChiTiet_ChamCong_Update_CongNhat_SanLuong_TangCa::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public void Update_CongNhat_SanLuongThuong()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_CongNhat_ChiTiet_ChamCong_Update_CongNhat_SanLuongThuong]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietChamCong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietChamCong));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fSLThuong", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fSLThuong));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay1", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay1));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay2", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay2));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay3", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay3));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay4", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay4));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay5", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay5));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay6", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay6));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay7", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay7));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay8", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay8));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay9", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay9));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay10", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay10));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay11", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay11));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay12", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay12));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay13", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay13));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay14", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay14));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay15", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay15));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay16", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay16));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay17", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay17));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay18", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay18));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay19", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay19));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay20", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay20));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay21", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay21));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay22", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay22));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay23", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay23));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay24", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay24));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay25", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay25));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay26", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay26));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay27", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay27));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay28", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay28));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay29", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay29));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay30", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay30));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fNgay31", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fNgay31));
               // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_CongNhat_ChiTiet_ChamCong_Update_CongNhat_SanLuongThuong::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public DataTable SelectOne_W_Thang_Nam_ID_Congnhan()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_CongNhat_ChiTiet_ChamCong_SelectOne_W_Thang_Nam_ID_Congnhan]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_HUU_CongNhat_ChiTiet_ChamCong_SelectOne_W_Thang_Nam_ID_Congnhan");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iThang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iThang));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iNam", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iNam));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_CongNhan", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_CongNhan));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_CongNhat_ChiTiet_ChamCong_SelectOne_W_Thang_Nam_ID_Congnhan", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable SelectAll_HienThi_TamUng_TrongThang()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_CongNhat_ChiTiet_ChamCong_SelectAll_HienThi_TamUng_TrongThang]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_HUU_CongNhat_ChiTiet_ChamCong_SelectAll_HienThi_TamUng_TrongThang");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iThang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iThang));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iNam", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iNam));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_CongNhat_ChiTiet_ChamCong_SelectAll_HienThi_TamUng_TrongThang", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
      
        public void Update_DaTraLuong()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_CongNhat_ChiTiet_ChamCong_Update_DaTraLuong]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietChamCong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietChamCong));
               // scmCmdToExecute.Parameters.Add(new SqlParameter("@dcSoTienPhaiTraLuong", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 0, "", DataRowVersion.Proposed, m_dcSoTienPhaiTraLuong));
                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_CongNhat_ChiTiet_ChamCong_Update_DaTraLuong::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
       
        public DataTable SelectAll_TraLuongCongNhan()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_CongNhat_ChiTiet_ChamCong_SelectAll_TraLuongCongNhan]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_HUU_CongNhat_ChiTiet_ChamCong_SelectAll_TraLuongCongNhan");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@iThang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iThang));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@iNam", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iNam));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_CongNhat_ChiTiet_ChamCong_SelectAll_TraLuongCongNhan", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public void Delete_W_ID_ChamCong()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_CongNhat_ChiTiet_ChamCong_Delete_W_ID_ChamCong]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChamCong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChamCong));
                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_CongNhat_ChiTiet_ChamCong_Delete_W_ID_ChamCong::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
     
        public DataTable SelectOne_W_tenNhanVien()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_CongNhat_ChiTiet_ChamCong_SelectOne_W_tenNhanVien]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_HUU_CongNhat_ChiTiet_ChamCong_SelectOne_W_tenNhanVien");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietChamCong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietChamCong));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_CongNhat_ChiTiet_ChamCong_SelectOne_W_tenNhanVien", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable Select_ALL_Thang_W_Nam()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_CongNhat_ChiTiet_ChamCong_SelectOne_Thang_W_Nam]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_HUU_CongNhat_ChiTiet_ChamCong_SelectOne_Thang_W_Nam");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iThang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iThang));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iNam", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iNam));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_CongNhat_ChiTiet_ChamCong_SelectOne_Thang_W_Nam", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public void Update_W_DinhMucLuongCongNhat()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_CongNhat_ChiTiet_ChamCong_Update_DinhMucLuongCongNhat]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_DinhMucLuong_CongNhat", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_DinhMucLuong_CongNhat));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChiTietChamCong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChiTietChamCong));
                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_CongNhat_ChiTiet_ChamCong_Update_DinhMucLuongCongNhat::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
       
        public DataTable SelectAll_HienThi_ALL_ChiTiet_TheoThang()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_HUU_CongNhat_ChiTiet_ChamCong_SelectAll_HienThi_ALL_TheoThang]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_HUU_CongNhat_ChiTiet_ChamCong_SelectAll_HienThi_ALL_TheoThang");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_ChamCong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_ChamCong));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_HUU_CongNhat_ChiTiet_ChamCong_SelectAll_HienThi_ALL_TheoThang", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
    }
}
