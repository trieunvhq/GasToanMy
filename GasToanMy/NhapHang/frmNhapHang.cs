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
    public partial class frmNhapHang : Form
    {
        public static bool mbAdd_SanPham = false;
        public static bool mb_Sua_SanPham = false;
        public static bool mbCopy_SanPham = false;
        public static DateTime mdNgayThang;
        public static string msSoHieu;
        public static int miID_BienBan;
        public static int miCaSanXuat;
        public static string msLoaiHang;
        public static string msLoaiGiay;
        public static Double mfSoLuongKiemTra;
        public static string msDonVi;
        public static Double mfTrongLuong;
        public static Double mfSoLuong;
        public static string msDonVi_;
        public static Double mfQuyRaKien;
        public static Double mfPhePham;
        public static Double mfDoCao;
        public static Double mfMotBao_kg;
        public static Double mfMotBao_SoKien;
        public static Double mfSauMuoi_BaoKien;
        public static string msGhiChu;
       

        public  DateTime _ngay_batdau;
        public  DateTime _ngay_ketthuc;
        public string _sSearch;
        private int _SoTrang = 1;
        private bool isload = false;
        private int _STT = 1;
        private int _RowPage_curent = 0;
        private int _TongSoTrang = 0;


        SanXuat_frmQuanLySanXuat _frmQLSX;


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
                dt2.Columns.Add("PhanNhom", typeof(string));
                dt2.Columns.Add("TenSanPham", typeof(string));
                dt2.Columns.Add("DonViTinh", typeof(string));
                dt2.Columns.Add("NhaCungCap", typeof(string));
                dt2.Columns.Add("SLNhap", typeof(Double));
                dt2.Columns.Add("SLXuat", typeof(Double));
                dt2.Columns.Add("SLTon", typeof(Double));
                dt2.Columns.Add("GiaVon", typeof(Decimal));
                dt2.Columns.Add("GiaBan", typeof(Decimal));
                dt2.Columns.Add("RecordStatus", typeof(string));
                dt2.Columns.Add("Description", typeof(string));
                dt2.Columns.Add("CreateUser", typeof(int));
                dt2.Columns.Add("UpdateUser", typeof(int));


                using (clsSanPham cls_ = new clsSanPham())
                {
                    DataTable dt_;
                    
                    if (checkAll.Checked)
                        dt_ = cls_.SelecPage_SanPham_All(_SoTrang, _sSearch);
                    else
                        dt_ = cls_.SelecPage_SanPham_ConHang(_SoTrang, _sSearch);


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
                            _ravi["PhanNhom"] = dt_.Rows[i]["PhanNhom"];
                            _ravi["TenSanPham"] = dt_.Rows[i]["TenSanPham"];
                            _ravi["DonViTinh"] = dt_.Rows[i]["DonViTinh"];
                            _ravi["NhaCungCap"] = dt_.Rows[i]["NhaCungCap"];
                            _ravi["SLNhap"] = dt_.Rows[i]["SLNhap"];
                            _ravi["SLXuat"] = dt_.Rows[i]["SLXuat"];
                            _ravi["SLTon"] = dt_.Rows[i]["SLTon"];
                            _ravi["GiaVon"] = dt_.Rows[i]["GiaVon"];
                            _ravi["GiaBan"] = dt_.Rows[i]["GiaBan"];
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

       

        public frmNhapHang(SanXuat_frmQuanLySanXuat frmQLSX = null)
        {
            _frmQLSX = frmQLSX;
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
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
            frmNhapHang_Load(sender, e);
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
            //try
            //{
            //    if (gridView1.GetFocusedRowCellValue(clID_BienBan).ToString() != "")
            //    {
            //        Cursor.Current = Cursors.WaitCursor;

            //        mbAdd_SanPham = false;
            //        mb_Sua_SanPham = true;
            //        mbCopy_SanPham = true;

            //        //
            //        mdNgayThang = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(clNgayThang).ToString());
            //        msSoHieu = gridView1.GetFocusedRowCellValue(clSoHieu).ToString().Trim();
            //        miID_BienBan = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clID_BienBan).ToString());
            //        miCaSanXuat = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clCaLamViec).ToString());
            //        msLoaiHang = gridView1.GetFocusedRowCellValue(clLoaiHang).ToString().Trim();
            //        msLoaiGiay = gridView1.GetFocusedRowCellValue(clLoaiGiay).ToString().Trim();
            //        mfSoLuongKiemTra = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clSoLuongKiemTra).ToString());
            //        msDonVi = gridView1.GetFocusedRowCellValue(clDonVi).ToString().Trim();
            //        mfTrongLuong = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clTrongLuong).ToString());
            //        mfSoLuong = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clSoLuong).ToString());
            //        msDonVi_ = gridView1.GetFocusedRowCellValue(clDonVi_).ToString().Trim();
            //        mfQuyRaKien = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clQuyRaKien).ToString());
            //        mfPhePham = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clPhePham).ToString());
            //        mfDoCao = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clDoCao).ToString());
            //        mfMotBao_kg = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clMotBao_kg).ToString());
            //        mfMotBao_SoKien = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clMotBao_SoKien).ToString());
            //        mfSauMuoi_BaoKien = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clSauMuoi_BaoKien).ToString());
            //        msGhiChu = gridView1.GetFocusedRowCellValue(clGhiChu).ToString().Trim();

            //        Tr_frmChiTietBB_Ktra_DMHH ff = new Tr_frmChiTietBB_Ktra_DMHH(this);
            //        //_frmQLSX.Hide();
            //        ff.Show();
            //        //_frmQLSX.Show();

            //        Cursor.Current = Cursors.Default;
            //    }
            //}
            //catch (Exception ea)
            //{
            //    MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Cursor.Current = Cursors.WaitCursor;

            //    clsTr_SanPhamDinhMuc_HHSX cls = new clsTr_SanPhamDinhMuc_HHSX();
            //    cls.iId_BB = Convert.ToInt32(gridView1.GetFocusedRowCellValue(CreateUser).ToString());

            //    DialogResult traloi;
            //    traloi = MessageBox.Show("Xóa dữ liệu tại dòng: \n"
            //        + "STT: " + gridView1.GetFocusedRowCellValue(clSTT).ToString() + " | "
            //        + "Ngày: " + Convert.ToDateTime(gridView1.GetFocusedRowCellValue(CreateDate).ToString()).ToString("dd/MM/yyyy") + " | "
            //        + "Ca: " + gridView1.GetFocusedRowCellValue(clCaLamViec).ToString() + " | "
            //        + "Loại Hàng: " + gridView1.GetFocusedRowCellValue(clLoaiHang).ToString()
            //        + "...", "Delete",
            //            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    if (traloi == DialogResult.Yes)
            //    {
            //        if (cls.Delete())
            //        {
            //            MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            _STT -= _RowPage_curent;
            //            LoadData(_SoTrang, false);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Xóa dữ liệu thất bại. Kiểm tra lại kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }

            //    Cursor.Current = Cursors.Default;
            //}
            //catch (Exception ea)
            //{
            //    MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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

                if (!CheckString.FormIsOpened("frmChiTietNhapHang"))
                {
                    frmChiTietNhapHang ff = new frmChiTietNhapHang(this);
                    ff.Show();
                }

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
            //try
            //{
            //    if (gridView1.GetFocusedRowCellValue(clID_BienBan).ToString() != "")
            //    {
            //        Cursor.Current = Cursors.WaitCursor;

            //        mbAdd_SanPham = true;
            //        mb_Sua_SanPham = false;
            //        mbCopy_SanPham = true;

            //        mdNgayThang = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(clNgayThang).ToString());
            //        msSoHieu = gridView1.GetFocusedRowCellValue(clSoHieu).ToString().Trim();
            //        miID_BienBan = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clID_BienBan).ToString());
            //        miCaSanXuat = Convert.ToInt32(gridView1.GetFocusedRowCellValue(clCaLamViec).ToString());
            //        msLoaiHang = gridView1.GetFocusedRowCellValue(clLoaiHang).ToString().Trim();
            //        msLoaiGiay = gridView1.GetFocusedRowCellValue(clLoaiGiay).ToString().Trim();
            //        mfSoLuongKiemTra = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clSoLuongKiemTra).ToString());
            //        msDonVi = gridView1.GetFocusedRowCellValue(clDonVi).ToString().Trim();
            //        mfTrongLuong = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clTrongLuong).ToString());
            //        mfSoLuong = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clSoLuong).ToString());
            //        msDonVi_ = gridView1.GetFocusedRowCellValue(clDonVi_).ToString().Trim();
            //        mfQuyRaKien = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clQuyRaKien).ToString());
            //        mfPhePham = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clPhePham).ToString());
            //        mfDoCao = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clDoCao).ToString());
            //        mfMotBao_kg = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clMotBao_kg).ToString());
            //        mfMotBao_SoKien = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clMotBao_SoKien).ToString());
            //        mfSauMuoi_BaoKien = CheckString.ConvertToDouble_My(gridView1.GetFocusedRowCellValue(clSauMuoi_BaoKien).ToString());
            //        msGhiChu = gridView1.GetFocusedRowCellValue(clGhiChu).ToString().Trim();

            //        Tr_frmChiTietBB_Ktra_DMHH ff = new Tr_frmChiTietBB_Ktra_DMHH(this);
            //        //_frmQLSX.Hide();
            //        ff.Show();
            //        //_frmQLSX.Show();

            //        Cursor.Current = Cursors.Default;
            //    }
            //}
            //catch (Exception ea)
            //{
            //    MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
                    DataTable dt_;
                    if (checkAll.Checked)
                        dt_ = cls.TongSoSanPhamAll(_sSearch);
                    else
                        dt_ = cls.TongSoSanPham_ConHang(_sSearch);

                    if (dt_ != null && dt_.Rows.Count > 0)
                    {
                        _TongSoTrang = Convert.ToInt32(Math.Ceiling(CheckString.ConvertToDouble_My(dt_.Rows[0]["tongso"].ToString()) / (double)20));
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

                    _STT -= (20 + _RowPage_curent);

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
            Tr_frmPrintBB_Ktra_DM_HHSX ff = new Tr_frmPrintBB_Ktra_DM_HHSX(_ngay_batdau, _ngay_ketthuc);
            ff.Show();
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
    }
}
