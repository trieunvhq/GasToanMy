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
    public partial class Tr_frmChonSanPhamInNhan : Form
    {
        private DataTable _data;

        private bool KiemTraLuu()
        {

            DataTable dv3 = (DataTable)gridControl1.DataSource;

            if (dv3.Rows.Count == 0)
            {
                MessageBox.Show("Chưa chọn hàng hóa ");
                return false;
            }

            else return true;
        }

        public Tr_frmChonSanPhamInNhan()
        {
            InitializeComponent();

            _data = new DataTable();

            _data.Columns.Add("Code", typeof(string));
            _data.Columns.Add("TenSanPham", typeof(string));
            _data.Columns.Add("DonViTinh", typeof(string));
            _data.Columns.Add("GiaNY", typeof(double));
            _data.Columns.Add("GiaHT", typeof(double));
            _data.Columns.Add("SoLuongNhan", typeof(int));

            gridControl1.DataSource = _data;
        }

        private DataTable _dtsp = new DataTable();

        private void Tr_frmChonSanPhamInNhan_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            using (clsSanPham cls = new clsSanPham())
            {
                _dtsp = cls.Selec_SanPham_ConHang("");
                sleSanPham.DataSource = _dtsp;
                sleSanPham.ValueMember = "Code";
                sleSanPham.DisplayMember = "Code";

                //Thay caption:
                sleSanPham.View.Columns.Clear();//xóa caption cũ
                sleSanPham.View.Columns.AddVisible("Code", "Mã");
                sleSanPham.View.Columns.AddVisible("TenSanPham", "Tên");
                sleSanPham.View.Columns.AddVisible("SoLuong", "SL");
                sleSanPham.View.Columns.AddVisible("SLTon", "Tồn");
                sleSanPham.View.Columns.AddVisible("GiaVon", "Giá vốn");
                sleSanPham.View.Columns.AddVisible("GiaBan", "Giá bán");


                sleSanPham.View.Columns["TenSanPham"].Width = 320;
                sleSanPham.View.Columns["Code"].Width = 90;
                sleSanPham.View.Columns["SoLuong"].Width = 35;
                sleSanPham.View.Columns["SLTon"].Width = 35;
                sleSanPham.View.Columns["GiaVon"].Width = 90;
                sleSanPham.View.Columns["GiaBan"].Width = 90;
            }
            Cursor.Current = Cursors.Default;
        }

        private string _TenSP = "";
        private string _MaSP = "";
        private string _DVT = "";
        private int _SL = 0;
        private int _Ton = 0;
        private double _GiaVon = 0;
        private double _GiaBan = 0;

        void getSPwithCode(string Code_)
        {
            for(int i = 0; i < _dtsp.Rows.Count; i++)
            {
                if (Code_ == _dtsp.Rows[i]["Code"].ToString().Trim())
                {
                    _TenSP = _dtsp.Rows[i]["TenSanPham"].ToString().Trim();
                    _MaSP = _dtsp.Rows[i]["Code"].ToString().Trim();
                    _DVT = _dtsp.Rows[i]["DonViTinh"].ToString().Trim();
                    _SL = Convert.ToInt32(_dtsp.Rows[i]["SoLuong"].ToString().Trim());
                    _Ton = Convert.ToInt32(_dtsp.Rows[i]["SLTon"].ToString().Trim());
                    _GiaVon = Convert.ToInt32(_dtsp.Rows[i]["GiaVon"].ToString().Trim());
                    _GiaBan = Convert.ToInt32(_dtsp.Rows[i]["GiaBan"].ToString().Trim());
                    break;
                }
                else
                {
                    _TenSP = "";
                    _MaSP = "";
                    _SL = 0;
                    _Ton = 0;
                    _GiaVon = 0;
                    _GiaBan = 0;
                }
            }
        }

        private void gridView4_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == clSTT)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void btXoa2_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (gridView4.GetFocusedRowCellValue(Code) == null || gridView4.GetFocusedRowCellValue(Code).ToString() == "")
                    return;

                string Code_ = gridView4.GetFocusedRowCellValue(Code).ToString();

                DialogResult traloi;
                traloi = MessageBox.Show("Xóa dữ liệu tại dòng: \n"
                    + "Mã: " + gridView4.GetFocusedRowCellValue(Code).ToString() + " | "
                    + "Tên sản phẩm: " + gridView4.GetFocusedRowCellValue(TenSanPham).ToString()
                    + "...", "Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    bool deleted = false;
                    DataRow[] rows = _data.Select("Code='" + Code_ + "'");
                    foreach (DataRow row in rows)
                    {
                        _data.Rows.Remove(row);
                        deleted = true;
                        break;
                    }
                    _data.AcceptChanges();

                    //if (deleted)
                    //{
                    //    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void gridView4_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == Code)
            {
                string code_ = gridView4.GetRowCellValue(e.RowHandle, e.Column).ToString().Trim();
                getSPwithCode(code_);

                gridView4.SetRowCellValue(e.RowHandle, TenSanPham, _TenSP);
                gridView4.SetRowCellValue(e.RowHandle, SoLuongNhan, _Ton);
                gridView4.SetRowCellValue(e.RowHandle, DonViTinh, _DVT);
                gridView4.SetRowCellValue(e.RowHandle, GiaNY, _GiaBan + (_GiaBan*40)/100);
                gridView4.SetRowCellValue(e.RowHandle, GiaHT, _GiaBan);
            }
        }

        private void gridView4_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            //GridView view = sender as GridView;
            //DataView dv = view.DataSource as DataView;
            //if (dv[e.ListSourceRow]["HienThi"].ToString().Trim() == "0")
            //{
            //    e.Visible = false;
            //    e.Handled = true;
            //}
        }

        private void btnInNhan_Click(object sender, EventArgs e)
        {
            if (_data.Rows.Count == 0)
                return;

            frmPrintInNhanA4 ff = new frmPrintInNhanA4(_data);
            ff.Show();

            //if (_data.Rows.Count == 0)
            //    return;

            //frmPrintInNhan ff = new frmPrintInNhan(_data);
            //ff.Show();
        }
    }
}
