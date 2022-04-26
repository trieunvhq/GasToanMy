using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;


namespace GasToanMy
{
    public partial class XtrpPrintChiTietDonHang : DevExpress.XtraReports.UI.XtraReport
    {
        private string _MaDonHang;
        private string _TenKhachHang;
        private string _DienThoai;
        private string _DiaChi;
        private double _TongTien;
        private double _TienDaThanhToan;

        public XtrpPrintChiTietDonHang(string MaDonHang, string TenKhachHang, string DienThoai, string DiaChi, double TongTien, double TienDaThanhToan)
        {
            _MaDonHang = MaDonHang;
            _TenKhachHang = TenKhachHang;
            _DienThoai = DienThoai;
            _DiaChi = DiaChi;
            _TongTien = TongTien;
            _TienDaThanhToan = TienDaThanhToan;

            InitializeComponent();

            pNgay.Value = DateTime.Now;
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lbMaDon.Text = "Mã: "  + _MaDonHang;
            lbHoTenKhach.Text = "Họ tên khách hàng: " + _TenKhachHang;

            if (_DienThoai == null || _DienThoai == "")
                lbDienThoaiKhach.Text = "Điện thoại:...................... ";
            else
                lbDienThoaiKhach.Text = "Điện thoại: " + _DienThoai;

            if (_DienThoai == null || _DienThoai == "")
                lbDiaChiKhach.Text = "Địa chỉ:..............................................................................";
            else
                lbDiaChiKhach.Text = "Địa chỉ: " + _DiaChi;

            lbHoTenKHfoot.Text = _TenKhachHang;

            xrDaThanhToan.Text = _TienDaThanhToan.ToString("N2");
            xrTienConLai.Text = (_TongTien - _TienDaThanhToan).ToString("N2");

            if ((_TongTien - _TienDaThanhToan) > 0)
            {
                lbThanhTienBangChu.Text = "Số tiền (viết bằng chữ): " + CheckString.NumberToText(_TongTien - _TienDaThanhToan) + "./.";
            }
            else
            {
                lbThanhTienBangChu.Text = "Ghi chú: Đã thanh toán xong./.";
            }

            //if (_TienDaThanhToan >= _TongTien)
            //{
            //    lbGhiChu.Text = "Ghi chú: Đã thanh toán xong./.";
            //}
            //else if (_TienDaThanhToan == 0)
            //{
            //    lbGhiChu.Text = "Ghi chú: Khách hàng còn nợ " + _TongTien.ToString("N0") + "đ (" + CheckString.NumberToText(_TongTien) + ")./.";
            //}
            //else
            //{
            //    lbGhiChu.Text = "Ghi chú: Khách hàng đã thanh toán " + _TienDaThanhToan.ToString("N0") + "đ (" + CheckString.NumberToText(_TienDaThanhToan) + ")" 
            //        + "; còn nợ " + (_TongTien - _TienDaThanhToan).ToString("N0") + "đ (" + CheckString.NumberToText(_TongTien - _TienDaThanhToan) + ")./.";
            //}

            //Load label ngay ky footer:
            DateTime d = Convert.ToDateTime(pNgay.Value);
            if (d.Day > 9)
            {
                if (d.Month > 9)
                {
                    lbNgayThangNam.Text = "Ngày " + d.Day
                                        + " tháng " + d.Month
                                        + " năm " + d.Year;
                }
                else
                {
                    lbNgayThangNam.Text = "Ngày " + d.Day
                                        + " tháng 0" + d.Month
                                        + " năm " + d.Year;
                }

            }
            else
            {
                if (d.Month > 9)
                {
                    lbNgayThangNam.Text = "Ngày 0" + d.Day
                                        + " tháng " + d.Month
                                        + " năm " + d.Year;
                }
                else
                {
                    lbNgayThangNam.Text = "Ngày 0" + d.Day
                                        + " tháng 0" + d.Month
                                        + " năm " + d.Year;
                }
            }
        }

       
    }
}
