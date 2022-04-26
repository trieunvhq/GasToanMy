using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmDonHangCuaMoiKhach : Form
    {
        private bool isload = false;
        private string _CodeKhachHang;

        public void LoadData(bool isLoadLanDau)
        {
            try
            {
                isload = true;
                if (isLoadLanDau)
                {
                    //dteTuNgay.EditValue = DateTime.Now.AddDays(-30);
                    //dteDenNgay.EditValue = DateTime.Now;
                    txtTimKiem.Text = "";
                }
                else { }
                //_ngay_batdau = (DateTime)dteTuNgay.EditValue;
                //_ngay_ketthuc = dteDenNgay.DateTime;

                DataTable dt2 = new DataTable();
                dt2.Columns.Add("ID", typeof(int));
                dt2.Columns.Add("STT", typeof(int));
                dt2.Columns.Add("CreateDate", typeof(DateTime));
                dt2.Columns.Add("UpdateDate", typeof(DateTime));
                dt2.Columns.Add("Type", typeof(string));
                dt2.Columns.Add("Code", typeof(string));
                dt2.Columns.Add("CodeKhachHang", typeof(string));
                dt2.Columns.Add("PaymentStatus", typeof(string));
                dt2.Columns.Add("FullName", typeof(string));
                dt2.Columns.Add("TongTienDonHang", typeof(Double));
                dt2.Columns.Add("TienDaThanhToan", typeof(Double));
                dt2.Columns.Add("TienNo", typeof(Double));
                dt2.Columns.Add("RecordStatus", typeof(string));
                dt2.Columns.Add("Description", typeof(string));
                dt2.Columns.Add("CreateUser", typeof(string));
                dt2.Columns.Add("UpdateUser", typeof(string));
                dt2.Columns.Add("Address", typeof(string));
                dt2.Columns.Add("Phone", typeof(string));

                dt2.Columns.Add("CodeSanPham", typeof(string));
                dt2.Columns.Add("TenSanPham", typeof(string));
                dt2.Columns.Add("SoLuong", typeof(Double));
                dt2.Columns.Add("DonGia", typeof(Double));
                dt2.Columns.Add("ThanhTien", typeof(Double));

                double TongTienDH_ = 0;
                double TongTienDaThanhToanDH_ = 0;
                double TongTienNoDH_ = 0;
                double TongThanhTienCTD_ = 0;



                using (clsDonHang cls_ = new clsDonHang())
                {
                    DataTable dt_;
                    if (checked_ALL.Checked)
                        dt_ = cls_.SelecPage_DonHang_TheoKhachHang(_CodeKhachHang, txtTimKiem.Text.Trim());
                    else
                        dt_ = cls_.SelecPage_DonHang_TheoKhachHang_No(_CodeKhachHang, txtTimKiem.Text.Trim());

                    string tmp_MaDH = "XXX";
                    for (int i = 0; i < dt_.Rows.Count; i++)
                    {
                        if (dt_.Rows[i]["Code"].ToString() != tmp_MaDH)
                        {
                            tmp_MaDH = dt_.Rows[i]["Code"].ToString();
                            TongTienDH_ += CheckString.ConvertToDouble_My(dt_.Rows[i]["TongTienDonHang"].ToString());
                            TongTienDaThanhToanDH_ += CheckString.ConvertToDouble_My(dt_.Rows[i]["TienDaThanhToan"].ToString());
                            TongTienNoDH_ += CheckString.ConvertToDouble_My(dt_.Rows[i]["TienNo"].ToString());
                        }
                    }

                    if (dt_ != null && dt_.Rows.Count > 0)
                    {
                        int stt = 1;
                        for (int i = 0; i < dt_.Rows.Count; i++)
                        {
                            DataRow _ravi = dt2.NewRow();

                            _ravi["ID"] = Convert.ToInt32(dt_.Rows[i]["ID"].ToString());
                            _ravi["STT"] = stt.ToString(); stt++;
                            _ravi["CreateDate"] = dt_.Rows[i]["CreateDate"];
                            _ravi["UpdateDate"] = dt_.Rows[i]["UpdateDate"];
                            _ravi["Type"] = dt_.Rows[i]["Type"];
                            _ravi["Code"] = dt_.Rows[i]["Code"];
                            _ravi["CodeKhachHang"] = dt_.Rows[i]["CodeKhachHang"];
                            _ravi["PaymentStatus"] = dt_.Rows[i]["PaymentStatus"];
                            _ravi["FullName"] = dt_.Rows[i]["FullName"];
                            _ravi["TongTienDonHang"] = dt_.Rows[i]["TongTienDonHang"];
                            _ravi["TienDaThanhToan"] = dt_.Rows[i]["TienDaThanhToan"];
                            _ravi["TienNo"] = dt_.Rows[i]["TienNo"]; ;
                            _ravi["RecordStatus"] = dt_.Rows[i]["RecordStatus"];
                            _ravi["Description"] = dt_.Rows[i]["Description"];
                            _ravi["CreateUser"] = dt_.Rows[i]["CreateUser"];
                            _ravi["UpdateUser"] = dt_.Rows[i]["UpdateUser"];
                            _ravi["Address"] = dt_.Rows[i]["Address"];
                            _ravi["Phone"] = dt_.Rows[i]["Phone"];

                            _ravi["CodeSanPham"] = dt_.Rows[i]["CodeSanPham"];

                            if (CheckString.ConvertToDouble_My(dt_.Rows[i]["ThanhTien"].ToString()) > 0)
                                _ravi["TenSanPham"] = dt_.Rows[i]["TenSanPham"];
                            else
                                _ravi["TenSanPham"] = dt_.Rows[i]["TenSanPham"].ToString() + " (quà tặng)";

                            _ravi["SoLuong"] = dt_.Rows[i]["SoLuong"];
                            _ravi["DonGia"] = dt_.Rows[i]["DonGia"];
                            _ravi["ThanhTien"] = dt_.Rows[i]["ThanhTien"];

                            TongThanhTienCTD_ += CheckString.ConvertToDouble_My(dt_.Rows[i]["ThanhTien"].ToString());

                            dt2.Rows.Add(_ravi);
                        }
                        //====== Add row trống
                        DataRow _ravinull = dt2.NewRow();
                        _ravinull["Code"] = "";
                        dt2.Rows.Add(_ravinull);
                        //======
                        DataRow _raviTong = dt2.NewRow();
                        _raviTong["Code"] = "Tổng";
                        _raviTong["TongTienDonHang"] = TongTienDH_;
                        _raviTong["TienDaThanhToan"] = TongTienDaThanhToanDH_;
                        _raviTong["TienNo"] = TongTienNoDH_;
                        _raviTong["ThanhTien"] = TongThanhTienCTD_;
                        dt2.Rows.Add(_raviTong);
                    }
                }
                gridControl1.DataSource = dt2;

                isload = false;
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmDonHangCuaMoiKhach()
        {
            InitializeComponent();
        }

        public frmDonHangCuaMoiKhach(string TenKhach, string MaKH)
        {
            _CodeKhachHang = MaKH;
            InitializeComponent();

            this.Text = "Lịch sử mua hàng của khách: " + TenKhach + " - " + MaKH;
        }

        
        private void frmDonHangCuaMoiKhach_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadData(true);
            Cursor.Current = Cursors.Default;
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string ten = View.GetRowCellValue(e.RowHandle, View.Columns["Code"]).ToString();
                if (ten == "Tổng")
                {
                    e.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (isload)
                return;
            LoadData(false);
        }

        private void checked_ALL_CheckedChanged(object sender, EventArgs e)
        {
            if (isload)
                return;
            LoadData(false);
        }
    }
}
