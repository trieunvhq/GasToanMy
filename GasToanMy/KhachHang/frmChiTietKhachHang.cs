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
                    string tensp = txtAddress.Text.Trim();
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
                    cls.sNhaCungCap = txtFullName.Text.Trim();
                    cls.sTenSanPham = tensp;
                    cls.sDonViTinh= txtPhone.Text.Trim();
                    cls.fSoLuong = CheckString.ConvertToDouble_My(txtScore.Text);
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
                    string tensp = txtAddress.Text.Trim();
                    string ghichu = txtGhiChu.Text.Trim();

                    while (tensp.IndexOf("  ") >= 0)
                    {
                        tensp = tensp.Replace("  ", " ");
                    }

                    while (ghichu.IndexOf("  ") >= 0)
                    {
                        ghichu = ghichu.Replace("  ", " ");
                    }

                    cls.iID = frmKhachHang.miID;
                    cls.daCreateDate = Convert.ToDateTime(dateNgayThang.EditValue.ToString());
                    cls.daUpdateDate = DateTime.Now;
                    cls.sCreateUser = frmKhachHang.msCreateUser;
                    cls.sUpdateUser = frmDangNhap._sCode_NhanSu;
                    cls.sCode = txtCode.Text.Trim();
                    cls.sNhaCungCap = txtFullName.Text.Trim();
                    cls.sTenSanPham = tensp;
                    cls.sDonViTinh = txtPhone.Text.Trim();
                    cls.fSoLuong = CheckString.ConvertToDouble_My(txtScore.Text);
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
                if (frmKhachHang.mbCopy_SanPham)
                {
                    dateNgayThang.EditValue = DateTime.Now;
                    txtCode.Text = CheckString.creatCodeSanPham();
                }
                else
                {
                    txtCode.Text = frmKhachHang.msCode;
                    txtSLXuat.Text = frmKhachHang.mfSLXuat.ToString();
                    txtSLTon.Text = frmKhachHang.mfSLTon.ToString();
                    dateNgayThang.EditValue = frmKhachHang.mdaCreateDate;
                }

                txtAddress.Text = frmKhachHang.msTenSanPham;
                txtPhone.Text = frmKhachHang.msDonViTinh;
                txtFullName.Text = frmKhachHang.msNhaCungCap;
                txtScore.Text = frmKhachHang.mfSLNhap.ToString();
                txtGiaVon.Text = frmKhachHang.mfGiaVon.ToString();
                txtGiaban.Text = frmKhachHang.mfGiaBan.ToString();
                txtGhiChu.Text = frmKhachHang.msDescription;
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckDataInput()
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Kiểm tra lại tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtScore.Text))
            {
                MessageBox.Show("Kiểm tra lại số lượng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtScore.Focus();
                return false;
            }
            else if (!CheckIsNumber(txtScore.Text))
            {
                MessageBox.Show("Kiểm tra lại số lượng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtScore.Focus();
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
            else if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Kiểm tra lại đơn vị tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Focus();
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

        frmKhachHang _ucBBKTDM;
        public frmChiTietKhachHang(frmKhachHang ucBBKTDM)
        {
            _ucBBKTDM = ucBBKTDM;
            InitializeComponent();

            dateNgayThang.EditValue = DateTime.Now;

            txtPhone.Properties.Items.Add("Bộ");
            txtPhone.Properties.Items.Add("Bình");
            txtPhone.Properties.Items.Add("Cái");
            txtPhone.Properties.Items.Add("Chiếc");
            txtPhone.Properties.Items.Add("tấn");
            txtPhone.Properties.Items.Add("tạ");
            txtPhone.Properties.Items.Add("kg");
            txtPhone.Properties.Items.Add("km");
            txtPhone.Properties.Items.Add("m");
            txtPhone.Properties.Items.Add("cm");
            txtPhone.Text = "Chiếc";

            if (frmKhachHang.mbCopy_SanPham || frmKhachHang.mb_Sua_SanPham)
            {
                Load_frmEdit();
            }
            else if (frmKhachHang.mbAdd_SanPham)
            {
                txtCode.Text = CheckString.creatCodeSanPham();
            }

            txtAddress.Focus();
        }

        private void frmChiTietKhachHang_Load(object sender, EventArgs e)
        {
            txtAddress.Focus();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmKhachHang.mbAdd_SanPham || frmKhachHang.mbCopy_SanPham)
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
                else if (frmKhachHang.mbAdd_SanPham == false
                    && frmKhachHang.mb_Sua_SanPham == true)
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
