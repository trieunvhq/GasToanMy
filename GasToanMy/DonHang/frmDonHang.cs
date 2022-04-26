using System;
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
    public partial class frmDonHang : Form
    {
        public static bool mbAdd = false;
        public static bool mb_Sua = false;
        public static bool mbCopy = false;

        public static DateTime mdaCreateDate;
        public static DateTime mdaUpdateDate;
        public static int miID;
        public static string msType;
        public static string msCode;
        public static string msPaymentStatus;
        public static string msFullName;
        public static string msCodeKhachHang;
        public static Double mfTongTienDonHang;
        public static Double mfTienDaThanhToan;
        public static string msRecordStatus;
        public static string msDescription;
        public static string msCreateUser;
        public static string msUpdateUser;
        public string _sSearch;
        private int _SoTrang = 1;
        private bool isload = false;
        private int _STT = 1;
        private int _RowPage_curent = 0;
        private int _TongSoTrang = 0;
        private const int _SoHang = 30;
        private DataTable _dataChiTiet;

        public void LoadData(int sotrang, bool isLoadLanDau)
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
                _sSearch = txtTimKiem.Text;
                //_ngay_batdau = (DateTime)dteTuNgay.EditValue;
                //_ngay_ketthuc = dteDenNgay.DateTime;
                _SoTrang = sotrang;

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



                using (clsDonHang cls_ = new clsDonHang())
                {
                    DataTable dt_;
                    
                    if (checkAll.Checked)
                        dt_ = cls_.SelecPage_DonHang_All(_SoHang, _SoTrang, _sSearch);
                    else
                        dt_ = cls_.SelecPage_DonHang_DaThanhToan(_SoHang, _SoTrang, _sSearch);

                    _RowPage_curent = dt_.Rows.Count;

                    if (dt_ != null && dt_.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt_.Rows.Count; i++)
                        {
                            DataRow _ravi = dt2.NewRow();

                            _ravi["ID"] = Convert.ToInt32(dt_.Rows[i]["ID"].ToString());
                            _ravi["STT"] = _STT.ToString(); _STT++;
                            _ravi["CreateDate"] = dt_.Rows[i]["CreateDate"];
                            _ravi["UpdateDate"] = dt_.Rows[i]["UpdateDate"];
                            _ravi["Type"] = dt_.Rows[i]["Type"];
                            _ravi["Code"] = dt_.Rows[i]["Code"];
                            _ravi["CodeKhachHang"] = dt_.Rows[i]["CodeKhachHang"];
                            _ravi["PaymentStatus"] = dt_.Rows[i]["PaymentStatus"];
                            _ravi["FullName"] = dt_.Rows[i]["FullName"];
                            _ravi["TongTienDonHang"] = dt_.Rows[i]["TongTienDonHang"];
                            _ravi["TienDaThanhToan"] = dt_.Rows[i]["TienDaThanhToan"];
                            _ravi["TienNo"] = CheckString.ConvertToDouble_My(dt_.Rows[i]["TongTienDonHang"].ToString()) - CheckString.ConvertToDouble_My(dt_.Rows[i]["TienDaThanhToan"].ToString());
                            _ravi["RecordStatus"] = dt_.Rows[i]["RecordStatus"];
                            _ravi["Description"] = dt_.Rows[i]["Description"];
                            _ravi["CreateUser"] = dt_.Rows[i]["CreateUser"];
                            _ravi["UpdateUser"] = dt_.Rows[i]["UpdateUser"];
                            _ravi["Address"] = dt_.Rows[i]["Address"];
                            _ravi["Phone"] = dt_.Rows[i]["Phone"];


                            dt2.Rows.Add(_ravi);
                        }
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

                
        private Double _tongtien = 0;
        public void LoadDataDonHangChiTiet(string CodeDonHang_)
        {
            _dataChiTiet.Clear();
            _tongtien = 0;
            try
            { 
                using (clsDonHangChiTiet cls_ = new clsDonHangChiTiet())
                {
                    DataTable dt_ = cls_.DonHangChiTiet_SelectWithCodeDonHang(CodeDonHang_);

                    _RowPage_curent = dt_.Rows.Count;
                    int stt_ = 0;
                    if (dt_ != null && dt_.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt_.Rows.Count; i++)
                        {
                            DataRow _ravi = _dataChiTiet.NewRow();
                            stt_++;
                            _ravi["ID"] = Convert.ToInt32(dt_.Rows[i]["ID"].ToString());
                            _ravi["STT"] = stt_;
                            _ravi["CreateDate"] = dt_.Rows[i]["CreateDate"];
                            _ravi["UpdateDate"] = dt_.Rows[i]["UpdateDate"];
                            _ravi["Type"] = dt_.Rows[i]["Type"];
                            _ravi["Code"] = dt_.Rows[i]["Code"];
                            _ravi["CodeDonHang"] = dt_.Rows[i]["CodeDonHang"];
                            _ravi["CodeSanPham"] = dt_.Rows[i]["CodeSanPham"];

                            if (CheckString.ConvertToDouble_My(dt_.Rows[i]["ThanhTien"].ToString()) > 0)
                                _ravi["TenSanPham"] = dt_.Rows[i]["TenSanPham"];
                            else
                                _ravi["TenSanPham"] = dt_.Rows[i]["TenSanPham"].ToString() + " (quà tặng)";

                            _ravi["SoLuong"] = dt_.Rows[i]["SoLuong"];
                            _ravi["DonGia"] = dt_.Rows[i]["DonGia"];
                            _ravi["ThanhTien"] = dt_.Rows[i]["ThanhTien"];
                            _ravi["RecordStatus"] = dt_.Rows[i]["RecordStatus"];
                            _ravi["Description"] = dt_.Rows[i]["Description"];
                            _ravi["CreateUser"] = dt_.Rows[i]["CreateUser"];
                            _ravi["UpdateUser"] = dt_.Rows[i]["UpdateUser"];
                            _tongtien += CheckString.ConvertToDouble_My(dt_.Rows[i]["ThanhTien"].ToString());
                            _dataChiTiet.Rows.Add(_ravi);
                        }

                        if (dt_.Rows.Count > 0)
                        {
                            DataRow _raviTong = _dataChiTiet.NewRow();
                            _raviTong["TenSanPham"] = "Tổng";
                            _raviTong["ThanhTien"] = _tongtien;
                            _dataChiTiet.Rows.Add(_raviTong);
                        } 
                    }
                }
                gridControl2.DataSource = _dataChiTiet;
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public frmDonHang()
        {
            InitializeComponent();

            //Khởi tạo bảng chi tiết đơn hàng:
            _dataChiTiet = new DataTable();
            _dataChiTiet.Columns.Add("ID", typeof(int));
            _dataChiTiet.Columns.Add("STT", typeof(int));
            _dataChiTiet.Columns.Add("CreateDate", typeof(DateTime));
            _dataChiTiet.Columns.Add("UpdateDate", typeof(DateTime));
            _dataChiTiet.Columns.Add("Type", typeof(string));
            _dataChiTiet.Columns.Add("Code", typeof(string));
            _dataChiTiet.Columns.Add("CodeDonHang", typeof(string));
            _dataChiTiet.Columns.Add("CodeSanPham", typeof(string));
            _dataChiTiet.Columns.Add("TenSanPham", typeof(string));
            _dataChiTiet.Columns.Add("SoLuong", typeof(Double));
            _dataChiTiet.Columns.Add("DonGia", typeof(Double));
            _dataChiTiet.Columns.Add("ThanhTien", typeof(Double));
            _dataChiTiet.Columns.Add("RecordStatus", typeof(string));
            _dataChiTiet.Columns.Add("Description", typeof(string));
            _dataChiTiet.Columns.Add("CreateUser", typeof(string));
            _dataChiTiet.Columns.Add("UpdateUser", typeof(string));
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _STT = 1;
            LoadData(1, true);
            ResetSoTrang_BB();
            Cursor.Current = Cursors.Default;
        }

        public void btRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmDonHang_Load(sender, e);
            Cursor.Current = Cursors.Default;
        }

     

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            //if (e.Column == clSTT)
            //{
            //    e.DisplayText = (e.RowHandle + 1).ToString();
            //}
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (bandedGridView1.GetFocusedRowCellValue(ID).ToString() != "")
                {
                    Cursor.Current = Cursors.WaitCursor;

                    string CodeDH_ = bandedGridView1.GetFocusedRowCellValue(Code).ToString().Trim();
                    string CodeKhachHang_ = bandedGridView1.GetFocusedRowCellValue(CodeKhachHang).ToString().Trim();
                    string FullName_ = bandedGridView1.GetFocusedRowCellValue(FullName).ToString().Trim();

                    frmThemMoiDonHang ff = new frmThemMoiDonHang(CodeDH_, CodeKhachHang_, FullName_);
                    ff.Show();

                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                clsDonHang cls = new clsDonHang();
                cls.sCode = bandedGridView1.GetFocusedRowCellValue(Code).ToString();
                cls.sUpdateUser = frmDangNhap._sCode_NhanSu;
                cls.daUpdateDate = DateTime.Now;

                DialogResult traloi;
                traloi = MessageBox.Show("Xóa dữ liệu tại dòng: \n"
                    + "STT: " + bandedGridView1.GetFocusedRowCellValue(clSTT).ToString() + " | "
                    + "Ngày: " + Convert.ToDateTime(bandedGridView1.GetFocusedRowCellValue(CreateDate).ToString()).ToString("dd/MM/yyyy") + " | "
                    + "Mã đơn: " + bandedGridView1.GetFocusedRowCellValue(Code).ToString() + " | "
                    + "Tên khách hàng: " + bandedGridView1.GetFocusedRowCellValue(FullName).ToString()
                    + "...", "Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    if (cls.DonHang_DeleteWithCode())
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _STT -= _RowPage_curent;
                        LoadData(_SoTrang, false);
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thất bại. Kiểm tra lại kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //try
            //{

            //    clsPhieu_tbPhieu cls = new clsPhieu_tbPhieu();
            //    cls.iID_SoPhieu = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_BienBan).ToString());
            //    cls.bNgungTheoDoi = Convert.ToBoolean(gridView1.GetFocusedRowCellValue(clLoaiGiay).ToString());
            //    cls.Update_NgungTheoDoi();
            //}
            //catch
            //{

            //}
        }

     
        private void btChiTiet_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (gridView1.GetFocusedRowCellValue(clID_BienBan).ToString() != "")
            //    {
            //        msTenSoPhieu = gridView1.GetFocusedRowCellValue(clLoaiHang).ToString();
            //        mID_iD_SoPhieu = Convert.ToInt16(gridView1.GetFocusedRowCellValue(clID_BienBan).ToString());
            //        SanXuat_frmChiTietSoPhieu_RutGon ff = new GasToanMy.SanXuat_frmChiTietSoPhieu_RutGon();
            //        ff.Show();
            //    }
            //}
            //catch
            //{

            //}
        }

        private void btThemMoi_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                mbAdd = true;
                mbCopy = false;
                mb_Sua = false;

                //if (!CheckString.FormIsOpened("frmChiTietNhapHang"))
                //{
                //    frmChiTietNhapHang ff = new frmChiTietNhapHang(this);
                //    ff.Show();
                //}

                //frmChiTietNhapHang ff = new frmChiTietNhapHang(this);
                //ff.Show();

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (isload)
                return;
            _sSearch = txtTimKiem.Text;
            ResetSoTrang_BB();
            _STT = 1;
            LoadData(1, false);
        }    

        private void btCopY_Click(object sender, EventArgs e)
        {
            try
            {
                if (bandedGridView1.GetFocusedRowCellValue(ID).ToString() != "")
                {
                    Cursor.Current = Cursors.WaitCursor;

                    mbAdd = false;
                    mb_Sua = false;
                    mbCopy = true;

                    mdaCreateDate = Convert.ToDateTime(bandedGridView1.GetFocusedRowCellValue(CreateDate).ToString());
                    msType = bandedGridView1.GetFocusedRowCellValue(Type).ToString().Trim();
                    msCode = bandedGridView1.GetFocusedRowCellValue(Code).ToString().Trim();
                    miID = Convert.ToInt32(bandedGridView1.GetFocusedRowCellValue(ID).ToString());
                    msPaymentStatus = bandedGridView1.GetFocusedRowCellValue(PaymentStatus).ToString().Trim();
                    msCodeKhachHang = bandedGridView1.GetFocusedRowCellValue(CodeKhachHang).ToString().Trim();
                    msFullName = bandedGridView1.GetFocusedRowCellValue(FullName).ToString().Trim();
                    mfTongTienDonHang = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(TongTienDonHang).ToString());
                    mfTienDaThanhToan = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(TienDaThanhToan).ToString());
                    msRecordStatus = bandedGridView1.GetFocusedRowCellValue(RecordStatus).ToString().Trim();
                    msDescription = bandedGridView1.GetFocusedRowCellValue(Description).ToString().Trim();
                    msCreateUser = bandedGridView1.GetFocusedRowCellValue(CreateUser).ToString();

                    //frmChiTietNhapHang ff = new frmChiTietNhapHang(this);
                    //ff.Show();

                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //
        public void ResetSoTrang_BB()
        {
            try
            {
                btnTrangSau.Visible = true;
                btnTrangTiep.Visible = true;
                lbTongSoTrang.Visible = true;
                txtSoTrang.Visible = true;
                btnTrangSau.LinkColor = Color.Black;
                btnTrangTiep.LinkColor = Color.Blue;
                txtSoTrang.Text = "1";

                using (clsDonHang cls = new clsDonHang())
                {
                    DataTable dt_;
                    if (checkAll.Checked)
                        dt_ = cls.TongSoDonHang_All(_sSearch);
                    else
                        dt_ = cls.TongSoDonHang_DaThanhToan(_sSearch);

                    if (dt_ != null && dt_.Rows.Count > 0)
                    {
                        _TongSoTrang = Convert.ToInt32(Math.Ceiling(CheckString.ConvertToDouble_My(dt_.Rows[0]["tongso"].ToString()) / (double)_SoHang));
                        lbTongSoTrang.Text = "/" + _TongSoTrang.ToString();

                        double TongTienHang = CheckString.ConvertToDouble_My(dt_.Rows[0]["TongTienDH"].ToString());
                        double TongTienDaThanhToan = CheckString.ConvertToDouble_My(dt_.Rows[0]["TongTienDaTT"].ToString());

                        txtTongTienHang.Text = String.Format("{0:#,##0.00}", TongTienHang);
                        txtTongTienDaThanhToan.Text = String.Format("{0:#,##0.00}", TongTienDaThanhToan);
                        txtTongTienKhachNo.Text = String.Format("{0:#,##0.00}", TongTienHang - TongTienDaThanhToan);
                    }
                    else
                    {
                        lbTongSoTrang.Text = "/1";
                    }
                }
                if (lbTongSoTrang.Text == "0")
                    lbTongSoTrang.Text = "/1";
                if (lbTongSoTrang.Text == "/1")
                {
                    btnTrangSau.LinkColor = Color.Black;
                    btnTrangTiep.LinkColor = Color.Black;
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTrangTiep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isload)
                return;
            if (btnTrangTiep.LinkColor == Color.Black)
                return;
            if (btnTrangSau.LinkColor == Color.Black)
                btnTrangSau.LinkColor = Color.Blue;

            int sotrang_;
            try
            {
                sotrang_ = Convert.ToInt32(txtSoTrang.Text);
                int max_ = Convert.ToInt32(lbTongSoTrang.Text.Replace(" ", "").Replace("/", ""));
                if (sotrang_ < max_)
                {
                    txtSoTrang.Text = (sotrang_ + 1).ToString();
                    if (sotrang_ + 1 == _TongSoTrang)
                    {
                        btnTrangTiep.LinkColor = Color.Black;
                    }

                    Load_SanPham(false);
                }
                else
                {
                    txtSoTrang.Text = (max_).ToString();
                    btnTrangTiep.LinkColor = Color.Black;
                }
            }
            catch
            {
                btnTrangTiep.LinkColor = Color.Black;
                sotrang_ = 1;
                txtSoTrang.Text = "1";
            }
        }

        private void btnTrangSau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isload)
                return;
            if (btnTrangSau.LinkColor == Color.Black)
                return;
            if (btnTrangTiep.LinkColor == Color.Black)
                btnTrangTiep.LinkColor = Color.Blue;

            int sotrang_;
            try
            {
                sotrang_ = Convert.ToInt32(txtSoTrang.Text);
                if (sotrang_ <= 1)
                {
                    txtSoTrang.Text = "1";
                    btnTrangSau.LinkColor = Color.Black;
                    _STT = 1;

                }
                else
                {
                    txtSoTrang.Text = (sotrang_ - 1).ToString();

                    _STT -= (_SoHang + _RowPage_curent);

                    if (sotrang_ - 1 == 1)
                    {
                        btnTrangSau.LinkColor = Color.Black;
                    }

                    Load_SanPham(false);
                }
            }
            catch
            {
                btnTrangSau.LinkColor = Color.Black;
                sotrang_ = 1;
                txtSoTrang.Text = "1";
                _STT = 1;
            }
        }

        private void Load_SanPham(bool islandau)
        {
            int sotrang_ = 1;
            try
            {
                sotrang_ = Convert.ToInt32(txtSoTrang.Text);
            }
            catch
            {
                sotrang_ = 1;
                txtSoTrang.Text = "1";
            }
            LoadData(sotrang_, islandau);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_dataChiTiet.Rows.Count > 0)
            {
                if (!CheckString.FormIsOpened("frmPrintChiTietDonHang"))
                {
                    frmPrintChiTietDonHang ff = new frmPrintChiTietDonHang(_CodeDH, _TenKhach, _DienThoai, _DiaChi, _tongtien, 
                        CheckString.ConvertToDouble_My(txtSoTienThanhToan.Text.Trim()), _dataChiTiet);
                    ff.Show();
                }
            }
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (isload)
                return;
            _sSearch = txtTimKiem.Text;
            ResetSoTrang_BB();
            _STT = 1;
            LoadData(1, false);
        }

        private void bandedGridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "SLTon")
            {
                double xx = CheckString.ConvertToDouble_My(bandedGridView1.GetRowCellValue(e.RowHandle, bandedGridView1.Columns["SLTon"]).ToString());
                if (xx == 0)
                {
                    e.Appearance.ForeColor = Color.FromArgb(150, Color.Red);
                    //e.Appearance.ForeColor = Color.FromArgb(150, Color.Salmon);
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private string _CodeDH;
        private string _TenKhach;
        private string _DienThoai;
        private string _DiaChi;


        private void bandedGridView1_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                if (bandedGridView1.GetFocusedRowCellValue(Code) != null)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    _CodeDH = bandedGridView1.GetFocusedRowCellValue(Code).ToString().Trim();
                    _TenKhach = bandedGridView1.GetFocusedRowCellValue(FullName).ToString().Trim();
                    _DienThoai = bandedGridView1.GetFocusedRowCellValue(Phone).ToString().Trim();
                    _DiaChi = bandedGridView1.GetFocusedRowCellValue(Address).ToString().Trim();

                    txtMaDonHang.Text = "Mã đơn hàng: " + _CodeDH;
                    txtKhachHang.Text = "Khách hàng: " + bandedGridView1.GetFocusedRowCellValue(FullName).ToString().Trim();

                    if (CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(TongTienDonHang).ToString()) 
                        > CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(TienDaThanhToan).ToString()))
                    {
                        checkThanhToanAll.Enabled = true;
                        txtSoTienThanhToan.ReadOnly = false;
                        btnThanhToan.Enabled = true;
                    }
                    else
                    {
                        checkThanhToanAll.Enabled = false;
                        txtSoTienThanhToan.ReadOnly = true;
                        btnThanhToan.Enabled = false;
                    }

                    txtSoTienThanhToan.Text = String.Format("{0:#,##0.00}", CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(TienDaThanhToan).ToString()));

                    LoadDataDonHangChiTiet(_CodeDH);
                    
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bandedGridView2_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string ten = View.GetRowCellValue(e.RowHandle, View.Columns["TenSanPham"]).ToString();
                if (ten == "Tổng")
                {
                    e.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
                }
            }
        }

        private void txtSoTienThanhToan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoTienThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)42 || e.KeyChar == (char)43 || e.KeyChar == (char)45 || e.KeyChar == (char)47)
            {

            }
            else
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSoTienThanhToan_Leave(object sender, EventArgs e)
        {
            double vlaue_ = CheckString.ConvertToDouble_My(txtSoTienThanhToan.Text);

            txtSoTienThanhToan.Text = String.Format("{0:#,##0.00}", vlaue_);
        }

        private void txtSoTienThanhToan_MouseHover(object sender, EventArgs e)
        {
            double vlaue_ = CheckString.ConvertToDouble_My(txtSoTienThanhToan.Text);

            txtSoTienThanhToan.Text = String.Format("{0:#,##0.00}", vlaue_);
        }

        private void txtSoTienThanhToan_MouseLeave(object sender, EventArgs e)
        {
            double vlaue_ = CheckString.ConvertToDouble_My(txtSoTienThanhToan.Text);

            txtSoTienThanhToan.Text = String.Format("{0:#,##0.00}", vlaue_);
        }

        private void checkThanhToanAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkThanhToanAll.Checked)
            {
                txtSoTienThanhToan.Text = String.Format("{0:#,##0.00}", _tongtien);
            }
            else
            {
                txtSoTienThanhToan.Text = String.Format("{0:#,##0.00}", 0);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (_CodeDH == null)
                    return;

                using (clsDonHang cls = new clsDonHang())
                {
                    cls.sCode = _CodeDH;
                    cls.fTienDaThanhToan = CheckString.ConvertToDouble_My(txtSoTienThanhToan.Text);
                    cls.sUpdateUser = frmDangNhap._sCode_NhanSu;
                    cls.daUpdateDate = DateTime.Now;
                    cls.DonHang_UpdateThanhToan();

                    if (cls.DonHang_UpdateThanhToan())
                    {
                        LoadData(_SoTrang, false);
                        MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán thất bại. Kiểm tra lại kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi thanh toán. " + ea.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
