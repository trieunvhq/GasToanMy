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
    public partial class frmChiTietKhachHang : Form
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
                    cls.sCreateUser = frmDangNhap._sCode_NhanSu;
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

                    cls.iID = frmNhapHang.miID;
                    cls.daCreateDate = Convert.ToDateTime(dateNgayThang.EditValue.ToString());
                    cls.daUpdateDate = DateTime.Now;
                    cls.sCreateUser = frmNhapHang.msCreateUser;
                    cls.sUpdateUser = frmDangNhap._sCode_NhanSu;
                    cls.sCode = txtCode.Text.Trim();
                    cls.sNhaCungCap = txtNhaCungCap.Text.Trim();
                    cls.sTenSanPham = tensp;
                    cls.sDonViTinh = txtDonVi.Text.Trim();
                    cls.fSoLuong = CheckString.ConvertToDouble_My(txtSLNhap.Text);
                    cls.fGiaVon = CheckString.ConvertToDouble_My(txtGiaVon.Text);
                    cls.fGiaBan = CheckString.ConvertToDouble_My(txtGiaban.Text);
                    cls.sRecordStatus = "Y";
                    cls.sDescription = ghichu;

                    if (cls.Update()) return true;
                    else return false;
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
       
   
        private void Load_frmEdit()
        {
            try
            {
                if (frmNhapHang.mbCopy_SanPham)
                {
                    dateNgayThang.EditValue = DateTime.Now;
                    txtCode.Text = CheckString.creatCodeSanPham();
                }
                else
                {
                    txtCode.Text = frmNhapHang.msCode;
                    txtSLXuat.Text = frmNhapHang.mfSLXuat.ToString();
                    txtSLTon.Text = frmNhapHang.mfSLTon.ToString();
                    dateNgayThang.EditValue = frmNhapHang.mdaCreateDate;
                }

                txtTenSanPham.Text = frmNhapHang.msTenSanPham;
                txtDonVi.Text = frmNhapHang.msDonViTinh;
                txtNhaCungCap.Text = frmNhapHang.msNhaCungCap;
                txtSLNhap.Text = frmNhapHang.mfSLNhap.ToString();
                txtGiaVon.Text = frmNhapHang.mfGiaVon.ToString();
                txtGiaban.Text = frmNhapHang.mfGiaBan.ToString();
                txtGhiChu.Text = frmNhapHang.msDescription;
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        public frmChiTietKhachHang(frmNhapHang ucBBKTDM)
        {
            _ucBBKTDM = ucBBKTDM;
            InitializeComponent();

            dateNgayThang.EditValue = DateTime.Now;

            txtDonVi.Properties.Items.Add("Bộ");
            txtDonVi.Properties.Items.Add("Bình");
            txtDonVi.Properties.Items.Add("Cái");
            txtDonVi.Properties.Items.Add("Chiếc");
            txtDonVi.Properties.Items.Add("tấn");
            txtDonVi.Properties.Items.Add("tạ");
            txtDonVi.Properties.Items.Add("kg");
            txtDonVi.Properties.Items.Add("km");
            txtDonVi.Properties.Items.Add("m");
            txtDonVi.Properties.Items.Add("cm");
            txtDonVi.Text = "Chiếc";

            if (frmNhapHang.mbCopy_SanPham || frmNhapHang.mb_Sua_SanPham)
            {
                Load_frmEdit();
            }
            else if (frmNhapHang.mbAdd_SanPham)
            {
                txtCode.Text = CheckString.creatCodeSanPham();
            }

            txtTenSanPham.Focus();
        }

        private void frmChiTietKhachHang_Load(object sender, EventArgs e)
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
                if (frmNhapHang.mbAdd_SanPham || frmNhapHang.mbCopy_SanPham)
                {
                    if (CheckDataInput())
                    {
                        if (Insert_SanPham())
                        {
                            this.Close();
                            _ucBBKTDM.btRefresh_Click(null, null);
                            //MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        //MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
