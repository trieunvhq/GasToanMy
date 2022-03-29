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
    public partial class frmKhachHang : Form
    {
        public static bool mbAdd_SanPham = false;
        public static bool mb_Sua_SanPham = false;
        public static bool mbCopy_SanPham = false;

        public static DateTime mdaCreateDate;
        public static DateTime mdaUpdateDate;
        public static int miID;
        public static string msType;
        public static string msCode;
        public static string msPhone;
        public static string msEmail;
        public static string msAddress;
        public static string msFullName;
        public static Double msScore; 
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
                dt2.Columns.Add("FullName", typeof(string));
                dt2.Columns.Add("Address", typeof(string));
                dt2.Columns.Add("Phone", typeof(string));
                dt2.Columns.Add("Email", typeof(string));
                dt2.Columns.Add("Score", typeof(Double));
                dt2.Columns.Add("RecordStatus", typeof(string));
                dt2.Columns.Add("Description", typeof(string));
                dt2.Columns.Add("CreateUser", typeof(string));
                dt2.Columns.Add("UpdateUser", typeof(string));


                using (clsKhachHang cls_ = new clsKhachHang())
                {
                    DataTable dt_ = cls_.SelecPage_KhachHangAll(_SoHang, _SoTrang, _sSearch);


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
                            _ravi["FullName"] = dt_.Rows[i]["FullName"];
                            _ravi["Address"] = dt_.Rows[i]["Address"];
                            _ravi["Phone"] = dt_.Rows[i]["Phone"];
                            _ravi["Email"] = dt_.Rows[i]["Email"];
                            _ravi["Score"] = dt_.Rows[i]["Score"];
                            _ravi["RecordStatus"] = dt_.Rows[i]["RecordStatus"];
                            _ravi["Description"] = dt_.Rows[i]["Description"];
                            _ravi["CreateUser"] = dt_.Rows[i]["CreateUser"];
                            _ravi["UpdateUser"] = dt_.Rows[i]["UpdateUser"];

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

       

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
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
            frmKhachHang_Load(sender, e);
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

                    mbAdd_SanPham = false;
                    mb_Sua_SanPham = true;
                    mbCopy_SanPham = false;

                    msPhone = bandedGridView1.GetFocusedRowCellValue(Phone).ToString().Trim();
                    msEmail = bandedGridView1.GetFocusedRowCellValue(Email).ToString().Trim();
                    mdaCreateDate = Convert.ToDateTime(bandedGridView1.GetFocusedRowCellValue(CreateDate).ToString());
                    msType = bandedGridView1.GetFocusedRowCellValue(Type).ToString().Trim();
                    msCode = bandedGridView1.GetFocusedRowCellValue(Code).ToString().Trim();
                    miID = Convert.ToInt32(bandedGridView1.GetFocusedRowCellValue(ID).ToString());
                    msAddress = bandedGridView1.GetFocusedRowCellValue(Address).ToString().Trim();
                    msFullName = bandedGridView1.GetFocusedRowCellValue(FullName).ToString().Trim();
                    msScore = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(Score).ToString());
                    msRecordStatus = bandedGridView1.GetFocusedRowCellValue(RecordStatus).ToString().Trim();
                    msDescription = bandedGridView1.GetFocusedRowCellValue(Description).ToString().Trim();
                    msCreateUser = bandedGridView1.GetFocusedRowCellValue(CreateUser).ToString();

                    frmChiTietKhachHang ff = new frmChiTietKhachHang(this);
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

                clsKhachHang cls = new clsKhachHang();
                cls.sCode = bandedGridView1.GetFocusedRowCellValue(Code).ToString();
                cls.sUpdateUser = frmDangNhap._sCode_NhanSu;
                cls.daUpdateDate = DateTime.Now;

                DialogResult traloi;
                traloi = MessageBox.Show("Xóa dữ liệu tại dòng: \n"
                    + "STT: " + bandedGridView1.GetFocusedRowCellValue(clSTT).ToString() + " | "
                    + "Ngày: " + Convert.ToDateTime(bandedGridView1.GetFocusedRowCellValue(CreateDate).ToString()).ToString("dd/MM/yyyy") + " | "
                    + "Mã khách hàng: " + bandedGridView1.GetFocusedRowCellValue(Code).ToString() + " | "
                    + "Họ tên: " + bandedGridView1.GetFocusedRowCellValue(FullName).ToString()
                    + "...", "Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    if (cls.KhachHang_DeleteWithCode())
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


        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //GridView View = sender as GridView;
            //if (e.RowHandle >= 0)
            //{
            //    bool category = Convert.ToBoolean(View.GetRowCellValue(e.RowHandle, View.Columns["GuiDuLieu"]));
            //    if (category == false)
            //    {
            //        e.Appearance.BackColor = Color.Bisque;
                  
            //    }
            //}
        }

        private void btThemMoi_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                mbAdd_SanPham = true;
                mbCopy_SanPham = false;
                mb_Sua_SanPham = false;

                //if (!CheckString.FormIsOpened("frmChiTietKhachHang"))
                //{
                //    frmChiTietKhachHang ff = new frmChiTietKhachHang(this);
                //    ff.Show();
                //}

                frmChiTietKhachHang ff = new frmChiTietKhachHang(this);
                ff.Show();

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

                    mbAdd_SanPham = false;
                    mb_Sua_SanPham = false;
                    mbCopy_SanPham = true;

                    msPhone = bandedGridView1.GetFocusedRowCellValue(Phone).ToString().Trim();
                    msEmail = bandedGridView1.GetFocusedRowCellValue(Email).ToString().Trim();
                    mdaCreateDate = Convert.ToDateTime(bandedGridView1.GetFocusedRowCellValue(CreateDate).ToString());
                    msType = bandedGridView1.GetFocusedRowCellValue(Type).ToString().Trim();
                    msCode = bandedGridView1.GetFocusedRowCellValue(Code).ToString().Trim();
                    miID = Convert.ToInt32(bandedGridView1.GetFocusedRowCellValue(ID).ToString());
                    msAddress = bandedGridView1.GetFocusedRowCellValue(Address).ToString().Trim();
                    msFullName = bandedGridView1.GetFocusedRowCellValue(FullName).ToString().Trim();
                    msScore = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(Score).ToString());
                    msRecordStatus = bandedGridView1.GetFocusedRowCellValue(RecordStatus).ToString().Trim();
                    msDescription = bandedGridView1.GetFocusedRowCellValue(Description).ToString().Trim();
                    msCreateUser = bandedGridView1.GetFocusedRowCellValue(CreateUser).ToString();

                    frmChiTietKhachHang ff = new frmChiTietKhachHang(this);
                    ff.Show();

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

                using (clsKhachHang cls = new clsKhachHang())
                {
                    DataTable dt_ = cls.TongSoKhachHangAll(_sSearch);

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
            LoadData(sotrang_, islandau);
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
    }
}
