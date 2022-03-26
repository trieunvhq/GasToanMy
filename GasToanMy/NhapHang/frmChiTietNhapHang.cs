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
    public partial class frmChiTietNhapHang : Form
    {
        private bool Insert_SanPham()
        {
            try
            {
                using (clsSanPham cls = new clsSanPham())
                {
                    string tensp = txtTenSanPham.Text.Trim();
                    string ghichu = txtGhiChu.Text.Trim();

                    while (tensp.IndexOf("  ") >= 0)
                    {
                        tensp = tensp.Replace("  ", " ");
                    }

                    while (ghichu.IndexOf("  ") >= 0)
                    {
                        ghichu = ghichu.Replace("  ", " ");
                    }

                    cls.daCreateDate = Convert.ToDateTime(dateNgayThang.EditValue.ToString());
                    cls.iCreateUser = frmDangNhap._iID_NhanSu;
                    cls.sCode = txtCode.Text.Trim();
                    cls.sNhaCungCap = txtNhaCungCap.Text.Trim();
                    cls.sTenSanPham = tensp;
                    cls.sDonViTinh= txtDonVi.Text.Trim();
                    cls.fSoLuong = CheckString.ConvertToDouble_My(txtSLNhap.Text);
                    cls.fGiaVon = CheckString.ConvertToDouble_My(txtGiaVon.Text);
                    cls.fGiaBan = CheckString.ConvertToDouble_My(txtGiaban.Text);
                    cls.sRecordStatus = "Y";
                    cls.sDescription = ghichu;

                    if (cls.Insert()) return true;
                    else return false;
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        // 
        private bool Update_SanPham()
        {
            //try
            //{
            //    using (clsTr_SanPhamDinhMuc_HHSX cls = new clsTr_SanPhamDinhMuc_HHSX())
            //    {
            //        cls.iId_BB = Tr_UC_SanPham_DM_HHSX.miID_BienBan;
            //        cls.daNgayThang = Convert.ToDateTime(dateNgayThang.EditValue.ToString());
            //        cls.sSoHieu = txtTenSanPham.Text.ToString().Trim();
            //        cls.iCa = Convert.ToInt32(txtSoLuong.Text.ToString());
            //        cls.sLoaiHang = txtGiaVon.Text.ToString().Trim();
            //        cls.sLoaiGiay = txtGiaban.Text.ToString().Trim();
            //        cls.fSoLuongKtra = CheckString.ConvertToDouble_My(txtSoLuongKtra.Text.ToString());
            //        cls.sDonVi_first = txtDonVi_in.Text.ToString().Trim();
            //        cls.fTrongLuong = CheckString.ConvertToDouble_My(txtTrongLuong.Text.ToString());
            //        cls.fSoLuong = CheckString.ConvertToDouble_My(txtSoLuongd.Text.ToString());
            //        cls.sDonVi_Second = txtDonVi_Out.Text.ToString().Trim();
            //        cls.fQuyRaKien = CheckString.ConvertToDouble_My(txtQuyRaKien.Text.ToString());
            //        cls.fPhePham = CheckString.ConvertToDouble_My(txtPhePham.Text.ToString());
            //        cls.fDoCao = CheckString.ConvertToDouble_My(txtDoCao.Text.ToString());
            //        cls.fMotBao_kg = CheckString.ConvertToDouble_My(txt1Bao_kg.Text.ToString());
            //        cls.fMotBao_SoKien = CheckString.ConvertToDouble_My(txt1Bao_SoKien.Text.ToString());
            //        cls.fSauMuoi_BaoKien = CheckString.ConvertToDouble_My(txt60Bao_Kien.Text.ToString());
            //        cls.sGhiChu = txtGhiChu.Text.ToString().Trim();

            //        if (cls.Update()) return true;
            //        else return false;
            //    }
            //}
            //catch (Exception ea)
            //{
            //    MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            return true;
        }
       
   
        private void Load_frmEdit()
        {
            //try
            //{
            //    dateNgayThang.EditValue = Tr_UC_SanPham_DM_HHSX.mdNgayThang;
            //    txtTenSanPham.Text = Tr_UC_SanPham_DM_HHSX.msSoHieu;
            //    txtSoLuong.Text = Tr_UC_SanPham_DM_HHSX.miCaSanXuat.ToString();
            //    txtGiaVon.Text = Tr_UC_SanPham_DM_HHSX.msLoaiHang.ToString();
            //    txtGiaban.Text = Tr_UC_SanPham_DM_HHSX.msLoaiGiay.ToString();
            //    txtSoLuongKtra.Text = Tr_UC_SanPham_DM_HHSX.mfSoLuongKiemTra.ToString();
            //    txtDonVi_in.Text = Tr_UC_SanPham_DM_HHSX.msDonVi;
            //    txtTrongLuong.Text = Tr_UC_SanPham_DM_HHSX.mfTrongLuong.ToString();
            //    txtSoLuongd.Text = Tr_UC_SanPham_DM_HHSX.mfSoLuong.ToString();
            //    txtDonVi_Out.Text = Tr_UC_SanPham_DM_HHSX.msDonVi_;
            //    txtQuyRaKien.Text = Tr_UC_SanPham_DM_HHSX.mfQuyRaKien.ToString();
            //    txtPhePham.Text = Tr_UC_SanPham_DM_HHSX.mfPhePham.ToString();
            //    txtDoCao.Text = Tr_UC_SanPham_DM_HHSX.mfDoCao.ToString();
            //    txt1Bao_kg.Text = Tr_UC_SanPham_DM_HHSX.mfMotBao_kg.ToString();
            //    txt1Bao_SoKien.Text = Tr_UC_SanPham_DM_HHSX.mfMotBao_SoKien.ToString();
            //    txt60Bao_Kien.Text = Tr_UC_SanPham_DM_HHSX.mfSauMuoi_BaoKien.ToString();
            //    txtGhiChu.Text = Tr_UC_SanPham_DM_HHSX.msGhiChu;
            //}
            //catch (Exception ea)
            //{
            //    MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private bool CheckDataInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
            {
                MessageBox.Show("Kiểm tra lại tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSanPham.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtSLNhap.Text))
            {
                MessageBox.Show("Kiểm tra lại số lượng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSLNhap.Focus();
                return false;
            }
            else if (!CheckIsNumber(txtSLNhap.Text))
            {
                MessageBox.Show("Kiểm tra lại số lượng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSLNhap.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtGiaVon.Text))
            {
                MessageBox.Show("Kiểm tra lại giá vốn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaVon.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtGiaban.Text))
            {
                MessageBox.Show("Kiểm tra lại giá bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaban.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtDonVi.Text))
            {
                MessageBox.Show("Kiểm tra lại đơn vị tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonVi.Focus();
                return false;
            }
            else return true;
        }

        //
        public static bool CheckIsNumber(string Value)
        {
            double OutVal;
            if (Double.TryParse(Value, out OutVal))
            {
                // it is a number
                return true;
            }
            else
            {
                // it is not a number
                return false;
            }
        }

        frmNhapHang _ucBBKTDM;
        public frmChiTietNhapHang(frmNhapHang ucBBKTDM)
        {
            _ucBBKTDM = ucBBKTDM;
            InitializeComponent();

            dateNgayThang.EditValue = DateTime.Now;

            txtDonVi.Properties.Items.Add("Bộ");
            txtDonVi.Properties.Items.Add("Cái");
            txtDonVi.Properties.Items.Add("Chiếc");
            txtDonVi.Properties.Items.Add("tấn");
            txtDonVi.Properties.Items.Add("tạ");
            txtDonVi.Properties.Items.Add("kg");
            txtDonVi.Properties.Items.Add("km");
            txtDonVi.Properties.Items.Add("m");
            txtDonVi.Properties.Items.Add("cm");
            txtDonVi.Text = "Chiếc";

            if (frmNhapHang.mbCopy_SanPham)
            {
                Load_frmEdit();
            }
            else if (frmNhapHang.mbAdd_SanPham)
            {
                txtCode.Text = CheckString.creatCodeSanPham();
            }

            txtTenSanPham.Focus();
        }

        private void frmChiTietNhapHang_Load(object sender, EventArgs e)
        {
            txtTenSanPham.Focus();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmNhapHang.mbAdd_SanPham == true
               && frmNhapHang.mb_Sua_SanPham == false)
                {
                    if (CheckDataInput())
                    {
                        if (Insert_SanPham())
                        {
                            this.Close();
                            _ucBBKTDM.btRefresh_Click(null, null);
                            MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lưu dữ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else if (frmNhapHang.mbAdd_SanPham == false
                    && frmNhapHang.mb_Sua_SanPham == true)
                {
                    if (Update_SanPham())
                    {
                        this.Close();
                        _ucBBKTDM.btRefresh_Click(null, null);
                        MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lưu dữ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void dateNgayThang_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)13)
        //    {
        //        SendKeys.Send("{TAB}");
        //    }
        //}

       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGhiChu_KeyPress(object sender, KeyPressEventArgs e)
        {
            btSave.Focus();
        }

        private void dateNgayThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtNhaCungCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtTenSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDonVi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtSLNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                txtGiaVon.Focus();
            }
        }

        private void txtGiaVon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtGiaban_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtSLNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
