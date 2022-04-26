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
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace GasToanMy
{
    public partial class frmThemMoiDonHang : Form
    {
        public static bool mbAdd = false;
        public static bool mb_Sua = false;
        public static bool mbCopy = false;

        public static DateTime mdaCreateDate;
        public static DateTime mdaUpdateDate;
        public static int miID;
        public static string msType;
        public static string msCode;
        public static string msPhanNhom;
        public static string msTenSanPham;
        public static string msDonViTinh;
        public static string msNhaCungCap;
        public static Double mfSLNhap;
        public static Double mfSLXuat;
        public static Double mfSLTon;
        public static Double mfGiaVon;
        public static Double mfGiaBan;
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

        //Khách hàng:
        public string _sSearch_KH;
        private int _SoTrang_KH = 1;
        private bool isload_KH = false;
        private int _STT_KH = 1;
        private int _RowPage_curent_KH = 0;
        private int _TongSoTrang_KH = 0;
        private const int _SoHang = 30;
        private DataTable _spdata = new DataTable();
        private DataTable _DHCTdata = new DataTable();

        //Socket Server:
        const int MAX_CONNECTION = 1000;
        const int PORT_NUMBER = 8899;
        int dem = 0;
        private const int BUFFER_SIZE = 1024 * 100;
        private Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private byte[] _buffer = new byte[BUFFER_SIZE];

        List<Socket> DanhSachClient = new List<Socket>();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public void LoadData_SP(int sotrang, bool isLoadLanDau)
        {
            _spdata.Clear();
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

                using (clsSanPham cls_ = new clsSanPham())
                {
                    DataTable dt_ = cls_.SelecPage_SanPham_ConHang(_SoHang, _SoTrang, _sSearch);


                    _RowPage_curent = dt_.Rows.Count;

                    if (dt_ != null && dt_.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt_.Rows.Count; i++)
                        {
                            DataRow _ravi = _spdata.NewRow();

                            _ravi["spID"] = Convert.ToInt32(dt_.Rows[i]["ID"].ToString());
                            _ravi["spSTT"] = _STT.ToString(); _STT++;
                            _ravi["spCreateDate"] = dt_.Rows[i]["CreateDate"];
                            _ravi["spUpdateDate"] = dt_.Rows[i]["UpdateDate"];
                            _ravi["spType"] = dt_.Rows[i]["Type"];
                            _ravi["spCode"] = dt_.Rows[i]["Code"];
                            _ravi["PhanNhom"] = dt_.Rows[i]["PhanNhom"];
                            _ravi["spTenSanPham"] = dt_.Rows[i]["TenSanPham"];
                            _ravi["DonViTinh"] = dt_.Rows[i]["DonViTinh"];
                            _ravi["NhaCungCap"] = dt_.Rows[i]["NhaCungCap"];
                            _ravi["SLNhap"] = dt_.Rows[i]["SLNhap"];
                            _ravi["SLXuat"] = dt_.Rows[i]["SLXuat"];
                            _ravi["SLTon"] = dt_.Rows[i]["SLTon"];
                            _ravi["GiaVon"] = dt_.Rows[i]["GiaVon"];
                            _ravi["GiaBan"] = dt_.Rows[i]["GiaBan"];
                            _ravi["spRecordStatus"] = dt_.Rows[i]["RecordStatus"];
                            _ravi["spDescription"] = dt_.Rows[i]["Description"];
                            _ravi["spCreateUser"] = dt_.Rows[i]["CreateUser"];
                            _ravi["spUpdateUser"] = dt_.Rows[i]["UpdateUser"];

                            _spdata.Rows.Add(_ravi);
                        }
                    }
                }
                gridControl1.DataSource = _spdata;

                isload = false;
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData_KH(int sotrang, bool isLoadLanDau)
        {
            try
            {
                isload_KH = true;
                if (isLoadLanDau)
                {
                    //dteTuNgay.EditValue = DateTime.Now.AddDays(-30);
                    //dteDenNgay.EditValue = DateTime.Now;
                    txtSearch_KH.Text = "";
                }
                else { }
                _sSearch_KH = txtSearch_KH.Text;
                //_ngay_batdau = (DateTime)dteTuNgay.EditValue;
                //_ngay_ketthuc = dteDenNgay.DateTime;
                _SoTrang_KH = sotrang;

                DataTable dt2 = new DataTable();
                dt2.Columns.Add("khID", typeof(int));
                dt2.Columns.Add("khSTT", typeof(int));
                dt2.Columns.Add("khCreateDate", typeof(DateTime));
                dt2.Columns.Add("khUpdateDate", typeof(DateTime));
                dt2.Columns.Add("khType", typeof(string));
                dt2.Columns.Add("khCode", typeof(string));
                dt2.Columns.Add("khFullName", typeof(string));
                dt2.Columns.Add("khAddress", typeof(string));
                dt2.Columns.Add("Phone", typeof(string));
                dt2.Columns.Add("Email", typeof(string));
                dt2.Columns.Add("khScore", typeof(Double));
                dt2.Columns.Add("khRecordStatus", typeof(string));
                dt2.Columns.Add("khDescription", typeof(string));
                dt2.Columns.Add("khCreateUser", typeof(string));
                dt2.Columns.Add("khUpdateUser", typeof(string));


                using (clsKhachHang cls_ = new clsKhachHang())
                {
                    DataTable dt_ = cls_.SelecPage_KhachHangAll(_SoHang, _SoTrang_KH, _sSearch_KH);


                    _RowPage_curent_KH = dt_.Rows.Count;

                    if (dt_ != null && dt_.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt_.Rows.Count; i++)
                        {
                            DataRow _ravi = dt2.NewRow();

                            _ravi["khID"] = Convert.ToInt32(dt_.Rows[i]["ID"].ToString());
                            _ravi["khSTT"] = _STT_KH.ToString(); _STT_KH++;
                            _ravi["khCreateDate"] = dt_.Rows[i]["CreateDate"];
                            _ravi["khUpdateDate"] = dt_.Rows[i]["UpdateDate"];
                            _ravi["khType"] = dt_.Rows[i]["Type"];
                            _ravi["khCode"] = dt_.Rows[i]["Code"];
                            _ravi["khFullName"] = dt_.Rows[i]["FullName"];
                            _ravi["khAddress"] = dt_.Rows[i]["Address"];
                            _ravi["Phone"] = dt_.Rows[i]["Phone"];
                            _ravi["Email"] = dt_.Rows[i]["Email"];
                            _ravi["khScore"] = dt_.Rows[i]["Score"];
                            _ravi["khRecordStatus"] = dt_.Rows[i]["RecordStatus"];
                            _ravi["khDescription"] = dt_.Rows[i]["Description"];
                            _ravi["khCreateUser"] = dt_.Rows[i]["CreateUser"];
                            _ravi["khUpdateUser"] = dt_.Rows[i]["UpdateUser"];

                            dt2.Rows.Add(_ravi);
                        }
                    }
                }
                gridControl3.DataSource = dt2;

                isload_KH = false;
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Double _tongtien = 0;

        public void Load_Data_DonHangChiTiet(string CodeDonHang_)
        {
            _DHCTdata.Clear();
            _tongtien = 0;

            try
            { 

                using (clsDonHangChiTiet cls_ = new clsDonHangChiTiet())
                {
                    DataTable dt_ = cls_.DonHangChiTiet_SelectWithCodeDonHang(CodeDonHang_);

                    _RowPage_curent = dt_.Rows.Count;
                    int stt_ = 0;
                    if (dt_ != null && dt_.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt_.Rows.Count; i++)
                        {
                            DataRow _ravi = _DHCTdata.NewRow();
                            stt_++;
                            _ravi["ID"] = Convert.ToInt32(dt_.Rows[i]["ID"].ToString());
                            _ravi["STT"] = stt_;
                            _ravi["CreateDate"] = dt_.Rows[i]["CreateDate"];
                            _ravi["UpdateDate"] = dt_.Rows[i]["UpdateDate"];
                            _ravi["Type"] = dt_.Rows[i]["Type"];
                            _ravi["Code"] = dt_.Rows[i]["Code"];
                            _ravi["CodeDonHang"] = dt_.Rows[i]["CodeDonHang"];
                            _ravi["CodeSanPham"] = dt_.Rows[i]["CodeSanPham"];

                            if (CheckString.ConvertToDouble_My(dt_.Rows[i]["ThanhTien"].ToString()) > 0)
                                _ravi["TenSanPham"] = dt_.Rows[i]["TenSanPham"];
                            else
                                _ravi["TenSanPham"] = dt_.Rows[i]["TenSanPham"].ToString() + " (quà tặng)";

                            _ravi["SoLuong"] = dt_.Rows[i]["SoLuong"];
                            _ravi["DonGia"] = dt_.Rows[i]["DonGia"];
                            _ravi["ThanhTien"] = dt_.Rows[i]["ThanhTien"];
                            _ravi["RecordStatus"] = dt_.Rows[i]["RecordStatus"];
                            _ravi["Description"] = dt_.Rows[i]["Description"];
                            _ravi["CreateUser"] = dt_.Rows[i]["CreateUser"];
                            _ravi["UpdateUser"] = dt_.Rows[i]["UpdateUser"];
                            _tongtien += CheckString.ConvertToDouble_My(dt_.Rows[i]["ThanhTien"].ToString());
                            _DHCTdata.Rows.Add(_ravi);
                        }

                        if (dt_.Rows.Count > 0)
                        {
                            DataRow _raviTong = _DHCTdata.NewRow();
                            _raviTong["TenSanPham"] = "Tổng";
                            _raviTong["ThanhTien"] = _tongtien;
                            _DHCTdata.Rows.Add(_raviTong);
                        }
                    }
                }
                gridControl2.DataSource = _DHCTdata;

                if (checkThanhToanAll.Checked)
                {
                    txtSoTienThanhToan.Text = String.Format("{0:#,##0.00}", _tongtien);
                }
                else
                    txtSoTienThanhToan.Text = "0.00";
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Connect()
        {
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT_NUMBER));
            _serverSocket.Listen(1000);
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
        }

        private void AcceptCallback(IAsyncResult AR)
        {
            Socket socket = _serverSocket.EndAccept(AR);
            try
            {
                socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
                _serverSocket.BeginAccept(new AsyncCallback(AcceptCallback), null);
            }
            catch { }
        }

         byte[] Serialize(object o)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, o);
            return stream.ToArray();
        }

        //Ghép data
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void ReceiveCallback(IAsyncResult AR)
        {
            try
            {
                //Thread th = Thread.CurrentThread;
                Socket _client = (Socket)AR.AsyncState;
                byte[] data = new byte[BUFFER_SIZE];
                _client.Receive(data);
                string message = (string)Deserialize(data);
                DonHangs myJson;
                myJson = JsonConvert.DeserializeObject<DonHangs>(message);
                dem++;
                DanhSachClient.Add(_client);
                

                //CheckAcountB29(myJson.TaiKhoan, myJson.MatKhau, _client);


                for (int i = 0; i < DanhSachClient.Count; i++)
                {
                    if (SocketConnected(DanhSachClient[i]))
                    {
                        DanhSachClient[i].Close();
                        DanhSachClient.RemoveAt(i);
                    }
                }
                //_client.Dispose();
            }
            catch (Exception e)
            {
                return;
            }
        }

         //kiem tra is conecting
        bool SocketConnected(Socket s)
        {
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            bool part2 = (s.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }

        private void SendCallback(IAsyncResult AR)
        {
            try
            {
                Socket socket = (Socket)AR.AsyncState;
                if (socket.Connected)
                    socket.EndSend(AR);
            }
            catch { }

        }

        void Send(Socket _client, string Message_)
        {
            if (_client.Connected)
            {
                try
                {
                    if (Message_ != null && Message_ != "")
                    {
                        byte[] data = Serialize(Message_);
                        if (_client.Connected)
                            _client.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), _client);
                    }
                }
                catch
                {

                }
            }
        }

        public frmThemMoiDonHang(string MaDH, string MaKH, string TenKH)
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
            Connect();

            _CodeDH = MaDH;
            txtMaDonHang.Text = "Mã đơn hàng: " + _CodeDH;
            _TenKH = TenKH;
            _CodeKH = MaKH;
            txtKhachHang.Text = "Khách hàng: " + _TenKH + " - " + _CodeKH;


            //Khởi tạo bảng sản phẩm:
            _spdata.Columns.Add("spID", typeof(int));
            _spdata.Columns.Add("spSTT", typeof(int));
            _spdata.Columns.Add("spCreateDate", typeof(DateTime));
            _spdata.Columns.Add("spUpdateDate", typeof(DateTime));
            _spdata.Columns.Add("spType", typeof(string));
            _spdata.Columns.Add("spCode", typeof(string));
            _spdata.Columns.Add("PhanNhom", typeof(string));
            _spdata.Columns.Add("spTenSanPham", typeof(string));
            _spdata.Columns.Add("DonViTinh", typeof(string));
            _spdata.Columns.Add("NhaCungCap", typeof(string));
            _spdata.Columns.Add("SLNhap", typeof(Double));
            _spdata.Columns.Add("SLXuat", typeof(Double));
            _spdata.Columns.Add("SLTon", typeof(Double));
            _spdata.Columns.Add("GiaVon", typeof(Double));
            _spdata.Columns.Add("GiaBan", typeof(Double));
            _spdata.Columns.Add("spRecordStatus", typeof(string));
            _spdata.Columns.Add("spDescription", typeof(string));
            _spdata.Columns.Add("spCreateUser", typeof(string));
            _spdata.Columns.Add("spUpdateUser", typeof(string));


            //Khởi tạo bảng đơn hàng chi tiết:
            _DHCTdata.Columns.Add("ID", typeof(int));
            _DHCTdata.Columns.Add("STT", typeof(int));
            _DHCTdata.Columns.Add("CreateDate", typeof(DateTime));
            _DHCTdata.Columns.Add("UpdateDate", typeof(DateTime));
            _DHCTdata.Columns.Add("Type", typeof(string));
            _DHCTdata.Columns.Add("Code", typeof(string));
            _DHCTdata.Columns.Add("CodeDonHang", typeof(string));
            _DHCTdata.Columns.Add("CodeSanPham", typeof(string));
            _DHCTdata.Columns.Add("TenSanPham", typeof(string));
            _DHCTdata.Columns.Add("SoLuong", typeof(Double));
            _DHCTdata.Columns.Add("DonGia", typeof(Double));
            _DHCTdata.Columns.Add("ThanhTien", typeof(Double));
            _DHCTdata.Columns.Add("RecordStatus", typeof(string));
            _DHCTdata.Columns.Add("Description", typeof(string));
            _DHCTdata.Columns.Add("CreateUser", typeof(string));
            _DHCTdata.Columns.Add("UpdateUser", typeof(string));

            Load_Data_DonHangChiTiet(_CodeDH);
        }

        public frmThemMoiDonHang()
        {
            InitializeComponent();
            _CodeDH = CheckString.CreateCodeDonHang();
            txtMaDonHang.Text = "Mã đơn hàng: " + _CodeDH;

            //Khởi tạo bảng sản phẩm:
            _spdata.Columns.Add("spID", typeof(int));
            _spdata.Columns.Add("spSTT", typeof(int));
            _spdata.Columns.Add("spCreateDate", typeof(DateTime));
            _spdata.Columns.Add("spUpdateDate", typeof(DateTime));
            _spdata.Columns.Add("spType", typeof(string));
            _spdata.Columns.Add("spCode", typeof(string));
            _spdata.Columns.Add("PhanNhom", typeof(string));
            _spdata.Columns.Add("spTenSanPham", typeof(string));
            _spdata.Columns.Add("DonViTinh", typeof(string));
            _spdata.Columns.Add("NhaCungCap", typeof(string));
            _spdata.Columns.Add("SLNhap", typeof(Double));
            _spdata.Columns.Add("SLXuat", typeof(Double));
            _spdata.Columns.Add("SLTon", typeof(Double));
            _spdata.Columns.Add("GiaVon", typeof(Double));
            _spdata.Columns.Add("GiaBan", typeof(Double));
            _spdata.Columns.Add("spRecordStatus", typeof(string));
            _spdata.Columns.Add("spDescription", typeof(string));
            _spdata.Columns.Add("spCreateUser", typeof(string));
            _spdata.Columns.Add("spUpdateUser", typeof(string));


            //Khởi tạo bảng đơn hàng chi tiết:
            _DHCTdata.Columns.Add("ID", typeof(int));
            _DHCTdata.Columns.Add("STT", typeof(int));
            _DHCTdata.Columns.Add("CreateDate", typeof(DateTime));
            _DHCTdata.Columns.Add("UpdateDate", typeof(DateTime));
            _DHCTdata.Columns.Add("Type", typeof(string));
            _DHCTdata.Columns.Add("Code", typeof(string));
            _DHCTdata.Columns.Add("CodeDonHang", typeof(string));
            _DHCTdata.Columns.Add("CodeSanPham", typeof(string));
            _DHCTdata.Columns.Add("TenSanPham", typeof(string));
            _DHCTdata.Columns.Add("SoLuong", typeof(Double));
            _DHCTdata.Columns.Add("DonGia", typeof(Double));
            _DHCTdata.Columns.Add("ThanhTien", typeof(Double));
            _DHCTdata.Columns.Add("RecordStatus", typeof(string));
            _DHCTdata.Columns.Add("Description", typeof(string));
            _DHCTdata.Columns.Add("CreateUser", typeof(string));
            _DHCTdata.Columns.Add("UpdateUser", typeof(string));
        }

        private void frmThemMoiDonHang_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _STT = 1;
            _STT_KH = 1;
            LoadData_SP(1, true);
            LoadData_KH(1, true);
            ResetSoTrang_BB();
            ResetSoTrang_KH();
            Cursor.Current = Cursors.Default;
        }

        public void btRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            frmThemMoiDonHang_Load(sender, e);
            Cursor.Current = Cursors.Default;
        }


        private void RefreshPage()
        {
            //_STT = 1;
            _STT_KH = 1;
            //ResetSoTrang_BB();
            ResetSoTrang_KH();
            //LoadData_SP(1, true);
            LoadData_KH(1, true);
            Load_Data_DonHangChiTiet(_CodeDH);
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
            //    if (bandedGridView1.GetFocusedRowCellValue(spID).ToString() != "")
            //    {
            //        Cursor.Current = Cursors.WaitCursor;

            //        mbAdd = false;
            //        mb_Sua = true;
            //        mbCopy = false;

            //        mdaCreateDate = Convert.ToDateTime(bandedGridView1.GetFocusedRowCellValue(spCreateDate).ToString());
            //        msType = bandedGridView1.GetFocusedRowCellValue(spType).ToString().Trim();
            //        msCode = bandedGridView1.GetFocusedRowCellValue(spCode).ToString().Trim();
            //        miID = Convert.ToInt32(bandedGridView1.GetFocusedRowCellValue(spID).ToString());
            //        msPhanNhom = bandedGridView1.GetFocusedRowCellValue(PhanNhom).ToString().Trim();
            //        msTenSanPham = bandedGridView1.GetFocusedRowCellValue(TenSanPham).ToString().Trim();
            //        msDonViTinh = bandedGridView1.GetFocusedRowCellValue(DonViTinh).ToString().Trim();
            //        msNhaCungCap = bandedGridView1.GetFocusedRowCellValue(NhaCungCap).ToString().Trim();
            //        mfSLNhap = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(SLNhap).ToString());
            //        mfSLXuat = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(SLXuat).ToString());
            //        mfSLTon = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(SLTon).ToString());
            //        mfGiaVon = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(GiaVon).ToString());
            //        mfGiaBan = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(GiaBan).ToString());
            //        msRecordStatus = bandedGridView1.GetFocusedRowCellValue(spRecordStatus).ToString().Trim();
            //        msDescription = bandedGridView1.GetFocusedRowCellValue(spDescription).ToString().Trim();
            //        msCreateUser = bandedGridView1.GetFocusedRowCellValue(spCreateUser).ToString();

            //        //frmChiTietNhapHang ff = new frmChiTietNhapHang(this);
            //        //ff.Show();

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
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                clsDonHang cls = new clsDonHang();
                cls.sCode = bandedGridView1.GetFocusedRowCellValue(spCode).ToString();
                cls.sUpdateUser = frmDangNhap._sCode_NhanSu;
                cls.daUpdateDate = DateTime.Now;

                DialogResult traloi;
                traloi = MessageBox.Show("Xóa dữ liệu tại dòng: \n"
                    + "STT: " + bandedGridView1.GetFocusedRowCellValue(spSTT).ToString() + " | "
                    + "Ngày: " + Convert.ToDateTime(bandedGridView1.GetFocusedRowCellValue(spCreateDate).ToString()).ToString("dd/MM/yyyy") + " | "
                    + "Mã đơn: " + bandedGridView1.GetFocusedRowCellValue(spCode).ToString() + " | "
                    + "Tên khách hàng: " + bandedGridView1.GetFocusedRowCellValue(PhanNhom).ToString()
                    + "...", "Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                {
                    if (cls.DonHang_DeleteWithCode())
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _STT -= _RowPage_curent;
                        LoadData_SP(_SoTrang, false);
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

        private void btThemMoi_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                mbAdd = true;
                mbCopy = false;
                mb_Sua = false;

                //if (!CheckString.FormIsOpened("frmChiTietNhapHang"))
                //{
                //    frmChiTietNhapHang ff = new frmChiTietNhapHang(this);
                //    ff.Show();
                //}

                //frmChiTietNhapHang ff = new frmChiTietNhapHang(this);
                //ff.Show();

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
            LoadData_SP(1, false);
        }    

        private void btCopY_Click(object sender, EventArgs e)
        {
            try
            {
                if (bandedGridView1.GetFocusedRowCellValue(spID).ToString() != "")
                {
                    Cursor.Current = Cursors.WaitCursor;

                    mbAdd = false;
                    mb_Sua = false;
                    mbCopy = true;

                    mdaCreateDate = Convert.ToDateTime(bandedGridView1.GetFocusedRowCellValue(spCreateDate).ToString());
                    msType = bandedGridView1.GetFocusedRowCellValue(spType).ToString().Trim();
                    msCode = bandedGridView1.GetFocusedRowCellValue(spCode).ToString().Trim();
                    miID = Convert.ToInt32(bandedGridView1.GetFocusedRowCellValue(spID).ToString());
                    msPhanNhom = bandedGridView1.GetFocusedRowCellValue(PhanNhom).ToString().Trim();
                    msTenSanPham = bandedGridView1.GetFocusedRowCellValue(spTenSanPham).ToString().Trim();
                    msDonViTinh = bandedGridView1.GetFocusedRowCellValue(DonViTinh).ToString().Trim();
                    msNhaCungCap = bandedGridView1.GetFocusedRowCellValue(NhaCungCap).ToString().Trim();
                    mfSLNhap = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(SLNhap).ToString());
                    mfSLXuat = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(SLXuat).ToString());
                    mfSLTon = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(SLTon).ToString());
                    mfGiaVon = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(GiaVon).ToString());
                    mfGiaBan = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(GiaBan).ToString());
                    msRecordStatus = bandedGridView1.GetFocusedRowCellValue(spRecordStatus).ToString().Trim();
                    msDescription = bandedGridView1.GetFocusedRowCellValue(spDescription).ToString().Trim();
                    msCreateUser = bandedGridView1.GetFocusedRowCellValue(spCreateUser).ToString();

                    //frmChiTietNhapHang ff = new frmChiTietNhapHang(this);
                    //ff.Show();

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

                using (clsSanPham cls = new clsSanPham())
                {
                    DataTable dt_ = cls.TongSoSanPham_ConHang(_sSearch);

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
            LoadData_SP(sotrang_, islandau);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_DHCTdata.Rows.Count > 0)
            {
                if (!CheckString.FormIsOpened("frmPrintChiTietDonHang"))
                {
                    frmPrintChiTietDonHang ff = new frmPrintChiTietDonHang(_CodeDH, _TenKH, _DienThoai, _DiaChi, _tongtien,
                        CheckString.ConvertToDouble_My(txtSoTienThanhToan.Text.Trim()), _DHCTdata);
                    ff.Show();
                }
            }
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
            LoadData_SP(1, false);
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        

        private void bandedGridView2_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0 && View.GetRowCellValue(e.RowHandle, View.Columns["TenSanPham"]) != null)
            {
                string ten = View.GetRowCellValue(e.RowHandle, View.Columns["TenSanPham"]).ToString();
                if (ten == "Tổng")
                {
                    e.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
                }
            }
        }

        //Khách hàng:
        public void ResetSoTrang_KH()
        {
            try
            {
                llbTrangTruoc_KH.Visible = true;
                llbTrangTiep_KH.Visible = true;
                lbTongSoTrang_KH.Visible = true;
                lbSoTrang_KH.Visible = true;
                llbTrangTruoc_KH.LinkColor = Color.Black;
                llbTrangTiep_KH.LinkColor = Color.Blue;
                lbSoTrang_KH.Text = "1";

                using (clsKhachHang cls = new clsKhachHang())
                {
                    DataTable dt_ = cls.TongSoKhachHangAll(_sSearch_KH);

                    if (dt_ != null && dt_.Rows.Count > 0)
                    {
                        _TongSoTrang_KH = Convert.ToInt32(Math.Ceiling(CheckString.ConvertToDouble_My(dt_.Rows[0]["tongso"].ToString()) / (double)_SoHang));
                        lbTongSoTrang_KH.Text = "/" + _TongSoTrang_KH.ToString();
                    }
                    else
                    {
                        lbTongSoTrang_KH.Text = "/1";
                    }
                }
                if (lbTongSoTrang_KH.Text == "0")
                    lbTongSoTrang_KH.Text = "/1";
                if (lbTongSoTrang_KH.Text == "/1")
                {
                    llbTrangTruoc_KH.LinkColor = Color.Black;
                    llbTrangTiep_KH.LinkColor = Color.Black;
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_KhachHang(bool islandau)
        {
            int sotrang_ = 1;
            try
            {
                sotrang_ = Convert.ToInt32(lbSoTrang_KH.Text);
            }
            catch
            {
                sotrang_ = 1;
                lbSoTrang_KH.Text = "1";
            }
            LoadData_KH(sotrang_, islandau);
        }

        private void llbTrangTruoc_KH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isload_KH)
                return;
            if (llbTrangTruoc_KH.LinkColor == Color.Black)
                return;
            if (llbTrangTiep_KH.LinkColor == Color.Black)
                llbTrangTiep_KH.LinkColor = Color.Blue;

            int sotrang_;
            try
            {
                sotrang_ = Convert.ToInt32(lbSoTrang_KH.Text);
                if (sotrang_ <= 1)
                {
                    lbSoTrang_KH.Text = "1";
                    llbTrangTruoc_KH.LinkColor = Color.Black;
                    _STT_KH = 1;

                }
                else
                {
                    lbSoTrang_KH.Text = (sotrang_ - 1).ToString();

                    _STT_KH -= (_SoHang + _RowPage_curent_KH);

                    if (sotrang_ - 1 == 1)
                    {
                        llbTrangTruoc_KH.LinkColor = Color.Black;
                    }

                    Load_KhachHang(false);
                }
            }
            catch
            {
                llbTrangTruoc_KH.LinkColor = Color.Black;
                sotrang_ = 1;
                lbSoTrang_KH.Text = "1";
                _STT_KH = 1;
            }
        }

        private void llbTrangTiep_KH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isload_KH)
                return;
            if (llbTrangTiep_KH.LinkColor == Color.Black)
                return;
            if (llbTrangTruoc_KH.LinkColor == Color.Black)
                llbTrangTruoc_KH.LinkColor = Color.Blue;

            int sotrang_;
            try
            {
                sotrang_ = Convert.ToInt32(lbSoTrang_KH.Text);
                int max_ = Convert.ToInt32(lbTongSoTrang_KH.Text.Replace(" ", "").Replace("/", ""));
                if (sotrang_ < max_)
                {
                    lbSoTrang_KH.Text = (sotrang_ + 1).ToString();
                    if (sotrang_ + 1 == _TongSoTrang_KH)
                    {
                        llbTrangTiep_KH.LinkColor = Color.Black;
                    }

                    Load_KhachHang(false);
                }
                else
                {
                    lbSoTrang_KH.Text = (max_).ToString();
                    llbTrangTiep_KH.LinkColor = Color.Black;
                }
            }
            catch
            {
                llbTrangTiep_KH.LinkColor = Color.Black;
                sotrang_ = 1;
                lbSoTrang_KH.Text = "1";
            }
        }

        private void txtSearch_KH_TextChanged(object sender, EventArgs e)
        {
            if (isload_KH)
                return;
            _sSearch_KH = txtSearch_KH.Text;
            ResetSoTrang_KH();
            _STT_KH = 1;
            LoadData_KH(1, false);
        }

        private string _CodeDH;
        private string _CodeSP;
        private string _CodeKH;
        private string _TenKH;
        private Double _SoLuong = 0;
        private Double _GiaBan;

        private void bandedGridView1_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                if (_CodeKH == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng trước!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (bandedGridView1.GetFocusedRowCellValue(spCode) != null)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    _CodeSP = bandedGridView1.GetFocusedRowCellValue(spCode).ToString().Trim();
                    _GiaBan = CheckString.ConvertToDouble_My(bandedGridView1.GetFocusedRowCellValue(GiaBan).ToString().Trim());

                    using (clsDonHangChiTiet cls = new clsDonHangChiTiet())
                    {
                        DataTable dt = cls.DonHangChiTiet_SelectSoLuongWithCode(_CodeDH, _CodeSP);

                        if (dt.Rows.Count > 0)
                        {
                            _SoLuong = CheckString.ConvertToDouble_My(dt.Rows[0]["SoLuong"].ToString()) + 1;
                        }
                        else
                        {
                            _SoLuong = 1;
                        }

                        Insert_DonHangChiTiet();
                        checkKhuyenMai.Checked = false;

                        for (int i = 0; i < _spdata.Rows.Count; i++)
                        {
                            if (_spdata.Rows[i]["spCode"].ToString() == _CodeSP)
                            {
                                Double sl = CheckString.ConvertToDouble_My(_spdata.Rows[i]["SLTon"].ToString());
                                if (sl > 1)
                                    _spdata.Rows[i]["SLTon"] = sl - 1;
                                else
                                {
                                    _STT = 1;
                                    ResetSoTrang_BB();
                                    LoadData_SP(1, true);
                                }

                                break;
                            }
                        }
                    }

                    RefreshPage();

                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string _DienThoai, _DiaChi;

        private void bandedGridView3_RowClick(object sender, RowClickEventArgs e)
        {
            try
            {
                if (bandedGridView3.GetFocusedRowCellValue(khCode) != null)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    _CodeKH = bandedGridView3.GetFocusedRowCellValue(khCode).ToString().Trim();
                    _TenKH = bandedGridView3.GetFocusedRowCellValue(khFullName).ToString().Trim();
                    _DienThoai = bandedGridView3.GetFocusedRowCellValue(Phone).ToString().Trim();
                    _DiaChi = bandedGridView3.GetFocusedRowCellValue(khAddress).ToString().Trim();

                    txtKhachHang.Text = "Khách hàng: " + _TenKH + " - " + _CodeKH;

                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private bool Insert_DonHang()
        //{
        //    //try
        //    //{
        //    //    using (clsDonHang cls = new clsDonHang())
        //    //    {
        //    //        cls.daCreateDate = DateTime.Now;
        //    //        cls.sCreateUser = frmDangNhap._sCode_NhanSu;
        //    //        cls.sCode = _CodeDH;
        //    //        cls.s = _CodeDH;
        //    //        cls.sCodeSanPham = _CodeSP;
        //    //        cls.fSoLuong = _SoLuong;
        //    //        cls.fDonGia = _GiaBan;
        //    //        cls.fThanhTien = _SoLuong * _GiaBan;
        //    //        cls.sRecordStatus = "Y";

        //    //        if (cls.Insert()) return true;
        //    //        else return false;
        //    //    }
        //    //}
        //    //catch (Exception ea)
        //    //{
        //    //    MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //    return false;
        //    //}
        //}

        private bool Insert_DonHangChiTiet()
        {
            try
            {
                using (clsDonHangChiTiet cls = new clsDonHangChiTiet())
                {
                    cls.daCreateDate = DateTime.Now;
                    cls.sCreateUser = frmDangNhap._sCode_NhanSu;
                    cls.sCode = CheckString.CreateCodeDonHangChiTiet();
                    cls.sCodeDonHang = _CodeDH;
                    cls.sCodeSanPham = _CodeSP;
                    cls.fSoLuong = _SoLuong;
                    cls.fDonGia = _GiaBan;

                    if (checkKhuyenMai.Checked)
                    {
                        cls.fThanhTien = 0;
                    }
                    else
                    {
                        cls.fThanhTien = _SoLuong * _GiaBan;
                    }

                    cls.sRecordStatus = "Y";

                    if (cls.DonHangChiTiet_DonHang_Insert(_CodeKH)) return true;
                    else return false;
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void bandedGridView2_RowClick(object sender, RowClickEventArgs e)
        {

            try
            {
                if (bandedGridView2.GetFocusedRowCellValue(clCode) != null)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    _CodeDH = bandedGridView2.GetFocusedRowCellValue(CodeDonHang).ToString().Trim();
                    string codedhct = bandedGridView2.GetFocusedRowCellValue(clCode).ToString().Trim();
                    _CodeSP = bandedGridView2.GetFocusedRowCellValue(CodeSanPham).ToString().Trim();
                    _GiaBan = CheckString.ConvertToDouble_My(bandedGridView2.GetFocusedRowCellValue(DonGia).ToString().Trim());

                    using (clsDonHangChiTiet cls = new clsDonHangChiTiet())
                    {
                        DataTable dt = cls.DonHangChiTiet_SelectSoLuongWithCode(_CodeDH, _CodeSP);

                        if (dt.Rows.Count > 0)
                        {
                            double sl = CheckString.ConvertToDouble_My(dt.Rows[0]["SoLuong"].ToString());
                            if (sl > 1)
                            {
                                _SoLuong = sl - 1;
                                Insert_DonHangChiTiet();

                                for (int i = 0; i < _DHCTdata.Rows.Count - 1; i++)
                                { 
                                    if (_DHCTdata.Rows[i]["Code"].ToString() == codedhct)
                                    {
                                        _DHCTdata.Rows[i]["SoLuong"] = _SoLuong;
                                        _DHCTdata.Rows[i]["ThanhTien"] = _SoLuong * _GiaBan;
                                        break;
                                    }
                                }

                                double TongTien_ = 0;

                                for (int i = 0; i < _DHCTdata.Rows.Count - 1; i++)
                                {
                                    TongTien_ += CheckString.ConvertToDouble_My(_DHCTdata.Rows[i]["ThanhTien"].ToString());
                                }

                                _DHCTdata.Rows[_DHCTdata.Rows.Count -1]["ThanhTien"] = TongTien_;
                                _tongtien = TongTien_;

                            }
                            else
                            {
                                cls.DeleteDonHangChiTiet_UpDateDonHang(_CodeDH, codedhct, _CodeKH, DateTime.Now, frmDangNhap._sCode_NhanSu);
                                Load_Data_DonHangChiTiet(_CodeDH);
                            }
                        } 
                    }

                    _STT = 1;
                    ResetSoTrang_BB();
                    LoadData_SP(1, true);

                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaDonHangChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (bandedGridView2.GetFocusedRowCellValue(clCode) != null)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    _CodeDH = bandedGridView2.GetFocusedRowCellValue(CodeDonHang).ToString().Trim();
                    string codedhct = bandedGridView2.GetFocusedRowCellValue(clCode).ToString().Trim();
                    _CodeSP = bandedGridView2.GetFocusedRowCellValue(CodeSanPham).ToString().Trim();
                    _GiaBan = CheckString.ConvertToDouble_My(bandedGridView2.GetFocusedRowCellValue(DonGia).ToString().Trim());

                    using (clsDonHangChiTiet cls = new clsDonHangChiTiet())
                    {
                        cls.DeleteDonHangChiTiet_UpDateDonHang(_CodeDH, codedhct, _CodeKH, DateTime.Now, frmDangNhap._sCode_NhanSu);
                        Load_Data_DonHangChiTiet(_CodeDH);
                    }

                    _STT = 1;
                    ResetSoTrang_BB();
                    LoadData_SP(1, true);

                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Lỗi: ... " + ea.Message.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSoTienThanhToan_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSoTienThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)42 || e.KeyChar == (char)43 || e.KeyChar == (char)45 || e.KeyChar == (char)47)
            {

            }
            else
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSoTienThanhToan_Leave(object sender, EventArgs e)
        {
            double vlaue_ = CheckString.ConvertToDouble_My(txtSoTienThanhToan.Text);

            txtSoTienThanhToan.Text = String.Format("{0:#,##0.00}", vlaue_);
        }

        private void txtSoTienThanhToan_MouseHover(object sender, EventArgs e)
        {
            double vlaue_ = CheckString.ConvertToDouble_My(txtSoTienThanhToan.Text);

            txtSoTienThanhToan.Text = String.Format("{0:#,##0.00}", vlaue_);
        }

        private void txtSoTienThanhToan_MouseLeave(object sender, EventArgs e)
        {
            double vlaue_ = CheckString.ConvertToDouble_My(txtSoTienThanhToan.Text);

            txtSoTienThanhToan.Text = String.Format("{0:#,##0.00}", vlaue_);
        }

        private void checkThanhToanAll_CheckedChanged(object sender, EventArgs e)
        {
            if(checkThanhToanAll.Checked)
            {
                txtSoTienThanhToan.Text = String.Format("{0:#,##0.00}", _tongtien);
            }
            else
            {
                txtSoTienThanhToan.Text = String.Format("{0:#,##0.00}", 0);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                using (clsDonHang cls = new clsDonHang())
                {
                    cls.sCode = _CodeDH;
                    cls.fTienDaThanhToan = CheckString.ConvertToDouble_My(txtSoTienThanhToan.Text);
                    cls.sUpdateUser = frmDangNhap._sCode_NhanSu;
                    cls.daUpdateDate = DateTime.Now;
                    cls.DonHang_UpdateThanhToan();

                    if (cls.DonHang_UpdateThanhToan())
                    {
                        MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán thất bại. Kiểm tra lại kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ea)
            {
                MessageBox.Show("Lỗi thanh toán. " + ea.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
