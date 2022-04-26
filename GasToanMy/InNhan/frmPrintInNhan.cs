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
    public partial class frmPrintInNhan : Form
    {

        DataTable _data;

        public frmPrintInNhan(DataTable data)
        {
            _data = data;

            InitializeComponent();
        }

        private void Tr_frmBTTL_TBX_TQ_Load(object sender, EventArgs e)
        {
            Print_InNhan xtr111 = new Print_InNhan();
            DataSet_TinLuong ds = new DataSet_TinLuong();

            for (int i = 0; i < _data.Rows.Count; ++i)
            {
                int SoLuongNhan_ = Convert.ToInt32(_data.Rows[i]["SoLuongNhan"].ToString());

                for (int k = 0; k < SoLuongNhan_; k++)
                {
                    DataRow _ravi = ds.tbInNhan.NewRow();

                    _ravi["TenSanPham"] = _data.Rows[i]["TenSanPham"];
                    _ravi["Code"] = _data.Rows[i]["Code"];
                    _ravi["GiaNY"] = CheckString.ConvertToDouble_My(_data.Rows[i]["GiaNY"].ToString()).ToString("N0") + " đ";
                    _ravi["GiaHT"] = CheckString.ConvertToDouble_My(_data.Rows[i]["GiaHT"].ToString()).ToString("N0") + " đ";

                    ds.tbInNhan.Rows.Add(_ravi);
                }
            }

            xtr111.DataSource = null;
            xtr111.DataSource = ds.tbInNhan;
            xtr111.DataMember = "tbInNhan";
            xtr111.CreateDocument();
            documentViewer1.DocumentSource = xtr111;
        }
    }
}
