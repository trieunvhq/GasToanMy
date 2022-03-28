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
        private bool Insert_KhachHang()
        {
            try
            {
                using (clsKhachHang cls = new clsKhachHang())
                {
                    string DiaChi = txtAddress.Text.Trim();
                    string ghichu = txtGhiChu.Text.Trim();

                    while (DiaChi.IndexOf("  ") >= 0)
                    {
                        DiaChi = DiaChi.Replace("  ", " ");
                    }

                    while (ghichu.IndexOf("  ") >= 0)
                    {
                        ghichu = ghichu.Replace("  ", " ");
                    }

                    cls.daCreateDate = Convert.ToDateTime(dateNgayThang.EditValue.ToString());
                    cls.sCreateUser = frmDangNhap._sCode_NhanSu;
                    cls.sCode = txtCode.Text.Trim();
                    cls.sFullName = txtFullName.Text.Trim();
                    cls.sAddress = DiaChi;
                    cls.sPhone= txtPhone.Text.Trim();
                    cls.sEmail = txtEmail.Text.Trim();
                    cls.fScore = CheckString.ConvertToDouble_My(txtScore.Text);
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
                using (clsKhachHang cls = new clsKhachHang())
                {
                    string DiaChi = txtAddress.Text.Trim();
                    string ghichu = txtGhiChu.Text.Trim();

                    while (DiaChi.IndexOf("  ") >= 0)
                    {
                        DiaChi = DiaChi.Replace("  ", " ");
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
                    cls.sFullName = txtFullName.Text.Trim();
                    cls.sAddress = DiaChi;
                    cls.sPhone = txtPhone.Text.Trim();
                    cls.sEmail = txtEmail.Text.Trim();
                    cls.fScore = CheckString.ConvertToDouble_My(txtScore.Text);
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
                    dateNgayThang.EditValue = frmKhachHang.mdaCreateDate;
                }

                txtFullName.Text = frmKhachHang.msFullName;
                txtAddress.Text = frmKhachHang.msAddress;
                txtPhone.Text = frmKhachHang.msPhone;
                txtScore.Text = frmKhachHang.msScore.ToString();
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
                MessageBox.Show("Kiểm tra lại địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAddress.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtScore.Text))
            {
                MessageBox.Show("Kiểm tra lại điểm tích luỹ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtScore.Focus();
                return false;
            }
            else if (!CheckIsNumber(txtScore.Text))
            {
                MessageBox.Show("Kiểm tra lại điểm tích luỹ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtScore.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Kiểm tra lại số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhone.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Kiểm tra lại số email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (Insert_KhachHang())
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
                txtScore.Focus();
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
