﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace GasToanMy
{
    public partial class UCThanhPham_XuatKho_Khac : UserControl
    {

        public static int miID_XuatKho;
        public static bool mbThemMoi_XuatKho, mbCopy, mbSua;
      
        private void HienThiGridControl_2(int xxidxuatkhp)
        {

            clsKhoThanhPham_tbChiTietXuatKho cls2 = new clsKhoThanhPham_tbChiTietXuatKho();
            DataTable dt = cls2.SA_ID_Xuatkho(xxidxuatkhp);
            gridControl2.DataSource = dt;
           
        }
        private void Load_Data(DateTime xxtungay, DateTime xxdenngay)
        {
            clsKhoThanhPham_tbXuatKho cls = new GasToanMy.clsKhoThanhPham_tbXuatKho();
            DataTable dt = cls.SA_Khac(xxtungay, xxdenngay);
            gridControl1.DataSource = dt;
        }


        frmQuanLyKhoThanhPham _frmQLKTP;
        public UCThanhPham_XuatKho_Khac(frmQuanLyKhoThanhPham frmQLKTP)
        {
            _frmQLKTP = frmQLKTP;
            InitializeComponent();
        }

        private void UCThanhPham_XuatKho_Khac_Load(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            dteDenNgay.EditValue = DateTime.Today;
            clsNgayThang cls = new clsNgayThang();
            dteTuNgay.EditValue = cls.GetFistDayInMonth(DateTime.Today.Year, DateTime.Today.Month);
            Load_Data(dteTuNgay.DateTime, dteDenNgay.DateTime);
            Cursor.Current = Cursors.Default;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            UCThanhPham_XuatKho_Khac_Load( sender,  e);
            Cursor.Current = Cursors.Default;
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            if (dteDenNgay.EditValue != null & dteTuNgay.EditValue != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                Load_Data(dteTuNgay.DateTime, dteDenNgay.DateTime);
                Cursor.Current = Cursors.Default;
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clID_XuatKho_ThanhPham).ToString() != "")
            {
                mbThemMoi_XuatKho = false;
                mbSua = true;
                mbCopy = false;
                miID_XuatKho = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_XuatKho_ThanhPham).ToString());
                KhoThanhPham_ChiTiet_XuatKho_Khac ff = new KhoThanhPham_ChiTiet_XuatKho_Khac();
                //_frmQLKTP.Hide();
                ff.Show();
                //_frmQLKTP.Show();
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool category = Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["DaXuatKho"]));
                if (category == false)
                {
                    e.Appearance.BackColor = Color.Bisque;

                }
            }
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            mbThemMoi_XuatKho = true;            
            mbSua = false;
            mbCopy = false;
            KhoThanhPham_ChiTiet_XuatKho_Khac ff = new KhoThanhPham_ChiTiet_XuatKho_Khac();
            //_frmQLKTP.Hide();
            ff.Show();
            //_frmQLKTP.Show();
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clID_XuatKho_ThanhPham).ToString() != "")
            {
                int iiIDnhapKhp = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clID_XuatKho_ThanhPham).ToString());
                HienThiGridControl_2(iiIDnhapKhp);
            }
        }

        private void gridView4_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT2)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void dteTuNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dteDenNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dteTuNgay_Leave(object sender, EventArgs e)
        {
            try
            {
                if (dteTuNgay.DateTime.Year < 1900)
                    dteTuNgay.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                if (dteDenNgay.DateTime.Year < 1900)
                    dteDenNgay.DateTime = DateTime.Now;

                Load_Data(dteTuNgay.DateTime, dteDenNgay.DateTime);
            }
            catch
            {

            }
        }

        private void dteDenNgay_Leave(object sender, EventArgs e)
        {
            try
            {
                if (dteTuNgay.DateTime.Year < 1900)
                    dteTuNgay.DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                if (dteDenNgay.DateTime.Year < 1900)
                    dteDenNgay.DateTime = DateTime.Now;

                Load_Data(dteTuNgay.DateTime, dteDenNgay.DateTime);
            }
            catch
            {

            }
        }

        private void btXoa1_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clID_XuatKho_ThanhPham).ToString() != "")
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Xóa dữ liệu này?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    clsKhoThanhPham_tbXuatKho cls1 = new clsKhoThanhPham_tbXuatKho();
                    cls1.iID_XuatKho_ThanhPham = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clID_XuatKho_ThanhPham).ToString());


                    cls1.Delete();
                    clsKhoThanhPham_tbChiTietXuatKho cls2 = new clsKhoThanhPham_tbChiTietXuatKho();
                    cls2.iID_XuatKho_ThanhPham = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clID_XuatKho_ThanhPham).ToString());
                    cls2.Delete_ALL_ID_XuatKho_ThanhPham();

                    Load_Data(dteTuNgay.DateTime, dteDenNgay.DateTime);
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Đã xóa");
                }


            }
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellValue(clID_XuatKho_ThanhPham).ToString() != "")
            {
                mbThemMoi_XuatKho = false;
                mbSua = false;
                mbCopy = true;
                miID_XuatKho = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_XuatKho_ThanhPham).ToString());
                KhoThanhPham_ChiTiet_XuatKho_Khac ff = new KhoThanhPham_ChiTiet_XuatKho_Khac();
                //_frmQLKTP.Hide();
                ff.Show();
                //_frmQLKTP.Show();
            }
        }
    }
}
