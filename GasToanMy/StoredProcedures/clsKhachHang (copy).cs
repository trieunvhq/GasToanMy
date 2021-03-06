///////////////////////////////////////////////////////////////////////////
// Description: Data Access class for the table 'KhachHang'
// Generated by LLBLGen v1.3.5996.26197 Final on: Sunday, March 27, 2022, 10:36:06 PM
// Because the Base Class already implements IDispose, this class doesn't.
///////////////////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace GasToanMy
{
	/// <summary>
	/// Purpose: Data Access class for the table 'KhachHang'.
	/// </summary>
	public partial class clsKhachHang : clsDBInteractionBase
	{
        public bool KhachHang_DeleteWithCode()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[KhachHang_DeleteWithCode]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sCode", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sCode));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@daUpdateDate", SqlDbType.DateTime, 8, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daUpdateDate));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@sUpdateUser", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sUpdateUser));

                // Open connection.
                m_scoMainConnection.Open();

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("clsKhachHang::KhachHang_DeleteWithCode::Error occured.", ex);
            }
            finally
            {
                // Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
            }
        }

        public DataTable Create_CodeKhachHang()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[Create_CodeKhachHang]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("Create_CodeKhachHang");
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
                throw new Exception("Create_CodeKhachHang", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }


        public DataTable SelecPage_KhachHangAll(int SoHang, int sotrang, string keysearch)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[SelecPage_KhachHangAll]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("SelecPage_KhachHangAll");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                scmCmdToExecute.Parameters.Add(new SqlParameter("@SoHang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, SoHang));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@SoTrang", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, sotrang));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@keysearch", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keysearch));

                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("SelecPage_KhachHangAll", ex);
            }
            finally
            {
                //Close connection.
                m_scoMainConnection.Close();
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public DataTable TongSoKhachHangAll(string keysearch)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[TongSoKhachHangAll]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("TongSoKhachHangAll");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                m_scoMainConnection.Open();

                scmCmdToExecute.Parameters.Add(new SqlParameter("@keysearch", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, keysearch));

                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("TongSoKhachHangAll", ex);
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
