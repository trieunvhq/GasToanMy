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
    public partial class frmThemMoiDonHang : Form
    {
        public static bool mbAdd = false;
        public static bool mb_Sua = false;
        public static bool mbCopy = false;

        public static DateTime mdaCreateDate;
        public static DateTime mdaUpdateDate;
        public static int miID;
        public static string msType;
        public static string msCode;
        public static string msPhanNhom;
        public static string msTenSanPham;
        public static string msDonViTinh;
        public static string msNhaCungCap;
        public static Double mfSLNhap;
        public static Double mfSLXuat;
        public static Double mfSLTon;
        public static Double mfGiaVon;
        public static Double mfGiaBan;
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

        //Khách hàng:
        public string _sSearch_KH;
        private int _SoTrang_Kh = 1;
        private bool isload_KH = false;
        private int _STT_KH = 1;
        private int _RowPage_curent_KH = 0;
        private int _TongSoTrang_KH = 0;
        private const int _SoHang = 30;

        public void LoadData_SP(int sotrang, bool isLoadLanDau)
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
                dt2.Columns.Add("spID", typeof(int));
                dt2.Columns.Add("spSTT", typeof(int));
                dt2.Columns.Add("spCreateDate", typeof(DateTime));
                dt2.Columns.Add("spUpdateDate", typeof(DateTime));
                dt2.Columns.Add("spType", typeof(string));
                dt2.Columns.Add("spCode", typeof(string));
                dt2.Columns.Add("PhanNhom", typeof(string));
                dt2.Columns.Add("spTenSanPham", typeof(string));
                dt2.Columns.Add("DonViTinh", typeof(string));
                dt2.Columns.Add("NhaCungCap", typeof(string));
                dt2.Columns.Add("SLNhap", typeof(Double));
                dt2.Columns.Add("SLXuat", typeof(Double));
                dt2.Columns.Add("SLTon", typeof(Double));
                dt2.Columns.Add("GiaVon", typeof(Double));
                dt2.Columns.Add("GiaBan", typeof(Double));
                dt2.Columns.Add("spRecordStatus", typeof(string));
                dt2.Columns.Add("spDescription", typeof(string));
                dt2.Columns.Add("spCreateUser", typeof(string));
                dt2.Columns.Add("spUpdateUser", typeof(string));


                using (clsSanPham cls_ = new clsSanPham())
                {
                    DataTable dt_ = cls_.SelecPage_SanPham_ConHang(_SoHang, _SoTrang, _sSearch);


                    _RowPage_curent = dt_.Rows.Count;

                    if (dt_ != null && dt_.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt_.Rows.Count; i++)
                        {
                            DataRow _ravi = dt2.NewRow();

                            _ravi["spID"] = Convert.ToInt32(dt_.Rows[i]["ID"].ToString());
                            _ravi["spSTT"] = _STT.ToString(); _STT++;
                            _ravi["spCreateDate"] = dt_.Rows[i]["CreateDate"];
                            _ravi["spUpdateDate"] = dt_.Rows[i]["UpdateDate"];
                            _ravi["spType"] = dt_.Rows[i]["Type"];
                            _ravi["spCode"] = dt_.Rows[i]["Code"];
                            _ravi["PhanNhom"] = dt_.Rows[i]["PhanNhom"];
                            _ravi["spTenSanPham"] = dt_.Rows[i]["TenSanPham"];
                            _ravi["DonViTinh"] = dt_.Rows[i]["DonViTinh"];
                            _ravi["NhaCungCap"] = dt_.Rows[i]["NhaCungCap"];
                            _ravi["SLNhap"] = dt_.Rows[i]["SLNhap"];
                            _ravi["SLXuat"] = dt_.Rows[i]["SLXuat"];
                            _ravi["SLTon"] = dt_.Rows[i]["SLTon"];
                            _ravi["GiaVon"] = dt_.Rows[i]["GiaVon"];
                            _ravi["GiaBan"] = dt_.Rows[i]["GiaBan"];
                            _ravi["spRecordStatus"] = dt_.Rows[i]["RecordStatus"];
                            _ravi["spDescription"] = dt_.Rows[i]["Description"];
                            _ravi["spCreateUser"] = dt_.Rows[i]["CreateUser"];
                            _ravi["spUpdateUser"] = dt_.Rows[i]["UpdateUser"];

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

        public void LoadData_KH(int sotrang, bool isLoadLanDau)
        {
            try
            {
                isload_KH = true;
                if (isLoadLanDau)
                {
                    //dteTuNgay.EditValue = DateTime.Now.AddDays(-30);
                    //dteDenNgay.EditValue = DateTime.Now;
                    txtTimKiem.Text = "";
                }
                else { }
                _sSearch_KH = txtTimKiem.Text;
                //_ngay_batdau = (DateTime)dteTuNgay.EditValue;
                //_ngay_ketthuc = dteDenNgay.DateTime;
                _SoTrang = sotrang;

                DataTable dt2 = new DataTable();
                dt2.Columns.Add("khID", typeof(int));
                dt2.Columns.Add("khSTT", typeof(int));
                dt2.Columns.Add("khCreateDate", typeof(DateTime));
                dt2.Columns.Add("khUpdateDate", typeof(DateTime));
                dt2.Columns.Add("khType", typeof(string));
                dt2.Columns.Add("khCode", typeof(string));
                dt2.Columns.Add("khFullName", typeof(string));
                dt2.Columns.Add("khAddress", typeof(string));
                dt2.Columns.Add("Phone", typeof(string));
                dt2.Columns.Add("Email", typeof(string));
                dt2.Columns.Add("khScore", typeof(Double));
                dt2.Columns.Add("khRecordStatus", typeof(string));
                dt2.Columns.Add("khDescription", typeof(string));
                dt2.Columns.Add("khCreateUser", typeof(string));
                dt2.Columns.Add("khUpdateUser", typeof(string));


                using (clsKhachHang cls_ = new clsKhachHang())
                {
                    DataTable dt_ = cls_.SelecPage_KhachHangAll(_SoHang, _SoTrang, _sSearch);


                    _RowPage_curent = dt_.Rows.Count;

                    if (dt_ != null && dt_.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt_.Rows.Count; i++)
                        {
                            DataRow _ravi = dt2.NewRow();

                            _ravi["khID"] = Convert.ToInt32(dt_.Rows[i]["ID"].ToString());
                            _ravi["khSTT"] = _STT.ToString(); _STT++;
                            _ravi["khCreateDate"] = dt_.Rows[i]["CreateDate"];
                            _ravi["khUpdateDate"] = dt_.Rows[i]["UpdateDate"];
                            _ravi["khType"] = dt_.Rows[i]["Type"];
                            _ravi["khCode"] = dt_.Rows[i]["Code"];
                            _ravi["khFullName"] = dt_.Rows[i]["FullName"];
                            _ravi["khAddress"] = dt_.Rows[i]["Address"];
                            _ravi["Phone"] = dt_.Rows[i]["Phone"];
                            _ravi["Email"] = dt_.Rows[i]["Email"];
                            _ravi["khScore"] = dt_.Rows[i]["Score"];
                            _ravi["khRecordStatus"] = dt_.Rows[i]["RecordStatus"];
                            _ravi["khDescription"] = dt_.Rows[i]["Description"];
                            _ravi["khCreateUser"] = dt_.Rows[i]["CreateUser"];
                            _ravi["khUpdateUser"] = dt_.Rows[i]["UpdateUser"];

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

        public void Load_Data_DonHangChiTiet(string CodeDonHang_)
        {
            try
            {
                DataTable dt2 = new DataTable();
                dt2.Columns.Add("ID", typeof(int));
                dt2.Columns.Add("STT", typeof(int));
                dt2.Columns.Add("CreateDate", typeof(DateTime));
                dt2.Columns.Add("UpdateDate", typeof(DateTime));
                dt2.Columns.Add("Type", typeof(string));
                dt2.Columns.Add("Code", typeof(string));
                dt2.Columns.Add("CodeDonHang", typeof(string));
                dt2.Columns.Add("CodeSanPham", typeof(string));
                dt2.Columns.Add("TenSanPham", typeof(string));
                dt2.Columns.Add("SoLuong", typeof(Double));
                dt2.Columns.Add("DonGia", typeof(Double));
                dt2.Columns.Add("ThanhTien", typeof(Double));
                dt2.Columns.Add("RecordStatus", typeof(string));
                dt2.Columns.Add("Description", typeof(string));
                dt2.Columns.Add("CreateUser", typeof(string));
                dt2.Columns.Add("UpdateUser", typeof(string));

                Double tongtien_ = 0;

                using (clsDonHangChiTiet cls_ = new clsDonHangChiTiet())
                {
                    DataTable dt_ = cls_.DonHangChiTiet_SelectWithCodeDonHang(CodeDonHang_);

                    _RowPage_curent = dt_.Rows.Count;
                    int stt_ = 0;
                    if (dt_ != null && dt_.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt_.Rows.Count; i++)
                        {
                            DataRow _ravi = dt2.NewRow();
                            stt_++;
                            _ravi["ID"] = Convert.ToInt32(dt_.Rows[i]["ID"].ToString());
                            _ravi["STT"] = stt_;
                            _ravi["CreateDate"] = dt_.Rows[i]["CreateDate"];
                            _ravi["UpdateDate"] = dt_.Rows[i]["UpdateDate"];
                            _ravi["Type"] = dt_.Rows[i]["Type"];
                            _ravi["Code"] = dt_.Rows[i]["Code"];
                            _ravi["CodeDonHang"] = dt_.Rows[i]["CodeDonHang"];
                            _ravi["CodeSanPham"] = dt_.Rows[i]["CodeSanPham"];
                            _ravi["TenSanPham"] = dt_.Rows[i]["TenSanPham"];
                            _ravi["SoLuong"] = dt_.Rows[i]["SoLuong"];
                            _ravi["DonGia"] = dt_.Rows[i]["DonGia"];
                            _ravi["ThanhTien"] = dt_.Rows[i]["ThanhTien"];
                            _ravi["RecordStatus"] = dt_.Rows[i]["RecordStatus"];
                            _ravi["Description"] = dt_.Rows[i]["Description"];
                            _ravi["CreateUser"] = dt_.Rows[i]["CreateUser"];
                            _ravi["UpdateUser"] = dt_.Rows[i]["UpdateUser"];
                            tongtien_ += CheckString.ConvertToDouble_My(dt_.Rows[i]["ThanhTien"].ToString());
                            dt2.Rows.Add(_ravi);
                        }

                        if (dt_.Rows.Count > 0)
                        {
                            DataRow _raviTong = dt2.NewRow();
                            _raviTong["TenSanPham"] = "Tổng";
                            _raviTong["ThanhTien"] = tongtien_;
                            dt2.Rows.Add(_raviTong);
                        }
                    }
                }
                gridControl2.DataSource = dt2;
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public frmThemMoiDonHang()
        {
            InitializeComponent();
        }

        private void frmThemMoiDonHang_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _STT = 1;
            LoadData_SP(1, true);
            ResetSoTrang_BB();
            Cursor.Current = Cursors.Default;
        }

        public void btRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmThemMoiDonHang_Load(sender, e);
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
                if (bandedGridView1.GetFocusedRowCellValue(spID).ToString() != "")
                {
                    Cursor.Current = Cursors.WaitCursor;

                    mbAdd = false;
                    mb_Sua = true;
                    mbCopy = false;

                    mdaCreateDate = Convert.ToDateTime(bandedGridView1.GetFocusedRowCellValue(spCreateDate).ToString());
                    msType = bandedGridView1.GetFocusedRowCellValue(spType).ToString().Trim();
                    msCode = bandedGridView1.GetFocusedRowCellValue(spCode).ToString().Trim();
                    miID = Convert.ToInt32(bandedGridView1.GetFocusedRowCellValue(spID).ToString());
                    msPhanNhom = bandedGridView1.GetFocusedRowCellValue(PhanNhom).ToString().Trim();
                    msTenSanPham = bandedGridView1.GetFocusedRowCellValue(TenSanPham).ToString().Trim();
                    msDonViTinh = bandedGridView1.GetFocusedRowCellValue(DonViTinh).ToString().Trim();
                    msNhaCungCap = bandedGridView1.GetFocusedRowCellValue(NhaCungCap).ToString().Trim();
                    mfSLNhap = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(SLNhap).ToString());
                    mfSLXuat = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(SLXuat).ToString());
                    mfSLTon = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(SLTon).ToString());
                    mfGiaVon = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(GiaVon).ToString());
                    mfGiaBan = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(GiaBan).ToString());
                    msRecordStatus = bandedGridView1.GetFocusedRowCellValue(spRecordStatus).ToString().Trim();
                    msDescription = bandedGridView1.GetFocusedRowCellValue(spDescription).ToString().Trim();
                    msCreateUser = bandedGridView1.GetFocusedRowCellValue(spCreateUser).ToString();

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

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                clsDonHang cls = new clsDonHang();
                cls.sCode = bandedGridView1.GetFocusedRowCellValue(spCode).ToString();
                cls.sUpdateUser = frmDangNhap._sCode_NhanSu;
                cls.daUpdateDate = DateTime.Now;

                DialogResult traloi;
                traloi = MessageBox.Show("Xóa dữ liệu tại dòng: \n"
                    + "STT: " + bandedGridView1.GetFocusedRowCellValue(spSTT).ToString() + " | "
                    + "Ngày: " + Convert.ToDateTime(bandedGridView1.GetFocusedRowCellValue(spCreateDate).ToString()).ToString("dd/MM/yyyy") + " | "
                    + "Mã đơn: " + bandedGridView1.GetFocusedRowCellValue(spCode).ToString() + " | "
                    + "Tên khách hàng: " + bandedGridView1.GetFocusedRowCellValue(PhanNhom).ToString()
                    + "...", "Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    if (cls.DonHang_DeleteWithCode())
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _STT -= _RowPage_curent;
                        LoadData_SP(_SoTrang, false);
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
            LoadData_SP(1, false);
        }    

        private void btCopY_Click(object sender, EventArgs e)
        {
            try
            {
                if (bandedGridView1.GetFocusedRowCellValue(spID).ToString() != "")
                {
                    Cursor.Current = Cursors.WaitCursor;

                    mbAdd = false;
                    mb_Sua = false;
                    mbCopy = true;

                    mdaCreateDate = Convert.ToDateTime(bandedGridView1.GetFocusedRowCellValue(spCreateDate).ToString());
                    msType = bandedGridView1.GetFocusedRowCellValue(spType).ToString().Trim();
                    msCode = bandedGridView1.GetFocusedRowCellValue(spCode).ToString().Trim();
                    miID = Convert.ToInt32(bandedGridView1.GetFocusedRowCellValue(spID).ToString());
                    msPhanNhom = bandedGridView1.GetFocusedRowCellValue(PhanNhom).ToString().Trim();
                    msTenSanPham = bandedGridView1.GetFocusedRowCellValue(spTenSanPham).ToString().Trim();
                    msDonViTinh = bandedGridView1.GetFocusedRowCellValue(DonViTinh).ToString().Trim();
                    msNhaCungCap = bandedGridView1.GetFocusedRowCellValue(NhaCungCap).ToString().Trim();
                    mfSLNhap = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(SLNhap).ToString());
                    mfSLXuat = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(SLXuat).ToString());
                    mfSLTon = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(SLTon).ToString());
                    mfGiaVon = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(GiaVon).ToString());
                    mfGiaBan = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(GiaBan).ToString());
                    msRecordStatus = bandedGridView1.GetFocusedRowCellValue(spRecordStatus).ToString().Trim();
                    msDescription = bandedGridView1.GetFocusedRowCellValue(spDescription).ToString().Trim();
                    msCreateUser = bandedGridView1.GetFocusedRowCellValue(spCreateUser).ToString();

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

                using (clsSanPham cls = new clsSanPham())
                {
                    DataTable dt_ = cls.TongSoSanPham_ConHang(_sSearch);

                    if (dt_ != null && dt_.Rows.Count > 0)
                    {
                        _TongSoTrang = Convert.ToInt32(Math.Ceiling(CheckString.ConvertToDouble_My(dt_.Rows[0]["tongso"].ToString()) / (double)_SoHang));
                        lbTongSoTrang.Text = "/" + _TongSoTrang.ToString();
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
            LoadData_SP(sotrang_, islandau);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Tr_frmPrintBB_Ktra_DM_HHSX ff = new Tr_frmPrintBB_Ktra_DM_HHSX(_ngay_batdau, _ngay_ketthuc);
            //ff.Show();
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
            LoadData_SP(1, false);
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

        private void bandedGridView1_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                if (bandedGridView1.GetFocusedRowCellValue(spCode) != null)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    string codeDH_ = bandedGridView1.GetFocusedRowCellValue(spCode).ToString().Trim();
                    txtMaDonHang.Text = "Mã đơn hàng: " + codeDH_;
                    txtKhachHang.Text = "Khách hàng: " + bandedGridView1.GetFocusedRowCellValue(PhanNhom).ToString().Trim();

                    Load_Data_DonHangChiTiet(codeDH_);
                    
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

        private void llbTrangTruoc_KH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void llbTrangTiep_KH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
