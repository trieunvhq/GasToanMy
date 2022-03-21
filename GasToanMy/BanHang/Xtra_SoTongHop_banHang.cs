﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Windows.Forms;

namespace GasToanMy
{
    public partial class Xtra_SoTongHop_banHang : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtra_SoTongHop_banHang()
        {
            InitializeComponent();
        }

        private void TopMargin_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                using (clsAaatbMacDinhNguoiKy cls = new GasToanMy.clsAaatbMacDinhNguoiKy())
                {
                    cls.iID_DangNhap = frmDangNhap._miID_DangNhap;
                    DataTable dt = cls.SelectAll_ID_DangNhap();
                    if (dt.Rows.Count > 0)
                    {
                        pNguoiLap.Value = dt.Rows[1]["HoTen"].ToString();
                        pTruongPhong.Value = dt.Rows[5]["HoTen"].ToString();
                        pThuKho.Value = dt.Rows[3]["HoTen"].ToString();
                        pPhoGiamDoc.Value = dt.Rows[8]["HoTen"].ToString();
                    }
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pNgayThang.Value = "Từ ngày " + BanHang_SoTongHopbanHang.mdatungay.ToString("dd/MM/yyyy") + " đến ngày " + BanHang_SoTongHopbanHang.mdadenngay.ToString("dd/MM/yyyy") + "";
        }
    }
}