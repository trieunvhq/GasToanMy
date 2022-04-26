using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasToanMy
{
    public partial class frmPrintChiTietDonHang : Form
    {

        private string _MaDonHang;
        private string _TenKhachHang;
        private string _DienThoai;
        private string _DiaChi;
        private double _TongTien;
        private double _TienDaThanhToan;
        DataTable _data;

        public frmPrintChiTietDonHang(string MaDonHang, string TenKhachHang, string DienThoai, string DiaChi, double TongTien, double TienDaThanhToan, DataTable data)
        {
            _data = data;
            _MaDonHang = MaDonHang;
            _TenKhachHang = TenKhachHang;
            _DienThoai = DienThoai;
            _DiaChi = DiaChi;
            _TongTien = TongTien;
            _TienDaThanhToan = TienDaThanhToan;

            InitializeComponent();
        }

        private void Tr_frmBTTL_TBX_TQ_Load(object sender, EventArgs e)
        {
            XtrpPrintChiTietDonHang xtr111 = new XtrpPrintChiTietDonHang(_MaDonHang, _TenKhachHang, _DienThoai, _DiaChi, _TongTien, _TienDaThanhToan);
            DataSet_TinLuong ds = new DataSet_TinLuong();

            for (int i = 0; i < _data.Rows.Count -1; ++i)
            {
                DataRow _ravi = ds.tbChiTietDonHang.NewRow();

                _ravi["STT"] = _data.Rows[i]["STT"].ToString();
                _ravi["TenSanPham"] = _data.Rows[i]["TenSanPham"].ToString();
                _ravi["DonGia"] = CheckString.ConvertToDouble_My(_data.Rows[i]["DonGia"].ToString());       
                _ravi["SoLuong"] = CheckString.ConvertToDouble_My(_data.Rows[i]["SoLuong"].ToString());
                _ravi["ThanhTien"] = CheckString.ConvertToDouble_My(_data.Rows[i]["ThanhTien"].ToString());

                ds.tbChiTietDonHang.Rows.Add(_ravi);
            }

            xtr111.DataSource = null;
            xtr111.DataSource = ds.tbChiTietDonHang;
            xtr111.DataMember = "tbChiTietDonHang";
            xtr111.CreateDocument();
            documentViewer1.DocumentSource = xtr111;
        }
    }
}
