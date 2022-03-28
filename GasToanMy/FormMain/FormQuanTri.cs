using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasToanMy.FormMain
{
    public partial class FormQuanTri : Form
    {
        public FormQuanTri()
        {
            InitializeComponent();
        }

        private void FormQuanTri_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void btnQuanTriTaiKhoan_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            frmQuanLyTaiKhoan ff = new GasToanMy.frmQuanLyTaiKhoan();
            ff.Show();

            Cursor.Current = Cursors.Default;
        }
    }
}
