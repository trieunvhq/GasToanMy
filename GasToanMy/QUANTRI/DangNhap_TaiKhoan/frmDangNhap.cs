using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace GasToanMy
{
  
    public partial class frmDangNhap : Form
    {
        public static int _miID_DangNhap;
        public static int _iID_NhanSu;
        public static bool _bIsQuanTri;
        public static string _TenNhanVien;
        public static string _ChucVu;


        private void KiemTraDangNhap()
        {
        }
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _miID_DangNhap = 1;
            txtTen.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;

            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUsers cls = new clsUsers();
            cls.sAcountName = txtTen.Text.Trim();
            cls.sPassword = CheckString.EncodeMD5(txtMatKhau.Text.Trim());
            DataTable dt = cls.Users_Login();

            if (dt.Rows.Count > 0)
            {
                _miID_DangNhap = Convert.ToInt16(dt.Rows[0]["ID_NhanSu"].ToString());
                _iID_NhanSu = Convert.ToInt16(dt.Rows[0]["ID_NhanSu"].ToString());
                _bIsQuanTri = Convert.ToBoolean(dt.Rows[0]["Type"].ToString());
                _TenNhanVien = dt.Rows[0]["FullName"].ToString();
                _ChucVu = dt.Rows[0]["ChucVu"].ToString();


                this.Hide();
                frmMain ff = new frmMain();
                ff.Show();
            }
            else
            {
             
                MessageBox.Show("Kiểm tra lại Tên đăng nhập hoặc mật khẩu");
                txtTen.ResetText();
                txtMatKhau.ResetText();
                txtTen.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        } 

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogin_Click(null, null);
            }
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtMatKhau.Focus();
            }
            else
            {

            }


        }
    }
}
