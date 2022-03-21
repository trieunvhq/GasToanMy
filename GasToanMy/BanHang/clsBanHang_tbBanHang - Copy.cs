///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'BanHang_tbBanHang'
// Generated by LLBLGen v1.3.5996.26197 Final on: Wednesday, January 13, 2021, 5:41:47 AM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace GasToanMy
{
	/// <summary>
	/// Purpose: Data Access class for the table 'BanHang_tbBanHang'.
	/// </summary>
	public partial class clsBanHang_tbBanHang : clsDBInteractionBase
	{
        //pr_MH_tbBanHang_SA_NgayThang_
        public DataTable SA_NgayThang_(bool TrangThai_KhoThanhPham_XXx, DateTime ngay_batdau, DateTime ngay_ketthuc)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BanHang_tbBanHang_SA_NgayThang_]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_BanHang_tbBanHang_SA_NgayThang_");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@bTrangThai_KhoThanhPham_", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, TrangThai_KhoThanhPham_XXx));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_BanHang_tbBanHang_SA_NgayThang_", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable SA_Time_DS_KH(DateTime ngay_batdau, DateTime ngay_ketthuc)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BanHang_tbBanHang_SA_Time_DS_KH]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_BanHang_tbBanHang_SA_Time_DS_KH");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_VTHH", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, iID_VTHH_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_BanHang_tbBanHang_SelectAll_ID_VTHH_NgayThang", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable SelectAll_ID_VTHH_NgayThang(int iID_VTHH_,DateTime ngay_batdau, DateTime ngay_ketthuc)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BanHang_tbBanHang_SelectAll_ID_VTHH_NgayThang]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_BanHang_tbBanHang_SelectAll_ID_VTHH_NgayThang");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_VTHH", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, iID_VTHH_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_BanHang_tbBanHang_SelectAll_ID_VTHH_NgayThang", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable SA_distinct_ID_VTHH_ID_KhachHang(int xxID_KH_,DateTime ngay_batdau, DateTime ngay_ketthuc)
        {
            //pr_BanHang_tbBanHang_SA_distinct_ID_VTHH_ID_KhachHang
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BanHang_tbBanHang_SA_distinct_ID_VTHH_ID_KhachHang]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_BanHang_tbBanHang_SA_distinct_ID_VTHH_ID_KhachHang");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_KhachHang_", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, xxID_KH_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_BanHang_tbBanHang_SA_distinct_ID_VTHH_ID_KhachHang", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public DataTable SelectAll_distinct_ID_VTHH_HUU(DateTime ngay_batdau, DateTime ngay_ketthuc)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BanHang_tbBanHang_SelectAll_distinct_ID_VTHH_HUU]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_BanHang_tbBanHang_SelectAll_distinct_ID_VTHH_HUU");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoTrang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sotrang_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_BanHang_tbBanHang_SelectAll_distinct_ID_VTHH_HUU", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable Dem_tbBanHang( DateTime ngay_batdau, DateTime ngay_ketthuc)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BanHang_tbBanHang_SelectAll_Dem_tbBanHang]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_BanHang_tbBanHang_SelectAll_Dem_tbBanHang");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoTrang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sotrang_));
                //scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_BanHang_tbBanHang_SelectAll_Dem_tbBanHang", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable Load_DaTa_NgayThang_So_Dong_Trang(int sotrang_, int sodong_, DateTime ngay_batdau, DateTime ngay_ketthuc)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BanHang_tbBanHang_SelectAll_Load_DaTa_NgayThang_So_Dong_Trang]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_BanHang_tbBanHang_SelectAll_Load_DaTa_NgayThang_So_Dong_Trang");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
               
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_batdau", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_batdau));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ngay_ketthuc", SqlDbType.SmallDateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ngay_ketthuc));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@SoTrang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sotrang_));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDong", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sodong_));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_BanHang_tbBanHang_SelectAll_Load_DaTa_NgayThang_So_Dong_Trang", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public void Update_TrangThai_DaXong()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BanHang_tbBanHang_Update_TrangThai_DaXong]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_BanHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_BanHang));
                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_BanHang_tbBanHang_Update_TrangThai_DaXong::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public void Update_W_LaiXe()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BanHang_tbBanHang_Update_W_LaiXe]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_BanHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_BanHang));
                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_BanHang_tbBanHang_Update_W_LaiXe::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public void Update_W_BaoVe()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BanHang_tbBanHang_Update_W_BaoVe]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_BanHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_BanHang));
                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_BanHang_tbBanHang_Update_W_BaoVe::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public DataTable SelectOne_W_ThamChieu_XuatKhoThanhPham()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BanHang_tbBanHang_SelectOne_W_ThamChieu_XuatKhoThanhPham]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_BanHang_tbBanHang_SelectOne_W_ThamChieu_XuatKhoThanhPham");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                scmCmdToExecute.Parameters.Add(new SqlParameter("@sThamChieu", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sThamChieu));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_BanHang_tbBanHang_SelectOne_W_ThamChieu_XuatKhoThanhPham", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable SelectAll_distinct_KhachHang_ThuTienKhachHang()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BanHang_tbBanHang_SelectAll_distinct_KhachHang_ThuTienKhachHang]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_BanHang_tbBanHang_SelectAll_distinct_KhachHang_ThuTienKhachHang");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                //scmCmdToExecute.Parameters.Add(new SqlParameter("@iIDNhaCungCap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iIDNhaCungCap));
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_BanHang_tbBanHang_SelectAll_distinct_KhachHang_ThuTienKhachHang", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public void Update_TrangThaiBanHang()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BanHang_tbBanHang_Update_TrangThaiBanHang]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_BanHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_BanHang));
             
                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_BanHang_tbBanHang_Update_TrangThaiBanHang::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public void Update_TongTienHang_and_GuiDuLieu__PhanTram_VAT_and_TienVAT()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BanHang_tbBanHang_Update_TongTienHang_and_GuiDuLieu__PhanTram_VAT_and_TienVAT]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_BanHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_BanHang));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTongTienHangChuaVAT", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTongTienHangChuaVAT));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTongTienHangCoVAT", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTongTienHangCoVAT));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fPhanTramVAT", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fPhanTramVAT));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@fTienVAT", SqlDbType.Float, 8, ParameterDirection.Input, false, 38, 0, "", DataRowVersion.Proposed, m_fTienVAT));

                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_BanHang_tbBanHang_Update_TongTienHang_and_GuiDuLieu__PhanTram_VAT_and_TienVAT::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
        public DataTable SelectAll_w_TenKH()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BanHang_tbBanHang_SelectAll_w_TenKH]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("pr_BanHang_tbBanHang_SelectAll_w_TenKH");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_BanHang_tbBanHang_SelectAll_w_TenKH", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public void Update_NgungTheoDoi()
        {

            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_BanHang_ChiTietBanHang_Update_NGUNGTHEODOI]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@bNgungTheoDoi", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bNgungTheoDoi));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@iID_BanHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_BanHang));
                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                //return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("pr_BanHang_ChiTietBanHang_Update_NGUNGTHEODOI::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }
    }
}