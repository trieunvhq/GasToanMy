namespace GasToanMy
{
    partial class frmDonHangCuaMoiKhach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonHangCuaMoiKhach));
            this.checked_ALL = new DevExpress.XtraEditors.CheckEdit();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.btCHiTiet = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.checkBoTheoDoi = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.CodeKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PaymentStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTienDonHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienDaThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TienNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RecordStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UpdateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodeSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.checked_ALL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCHiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoTheoDoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // checked_ALL
            // 
            this.checked_ALL.Location = new System.Drawing.Point(556, 10);
            this.checked_ALL.Name = "checked_ALL";
            this.checked_ALL.Properties.Caption = "Tất cả";
            this.checked_ALL.Size = new System.Drawing.Size(56, 19);
            this.checked_ALL.TabIndex = 85;
            this.checked_ALL.CheckedChanged += new System.EventHandler(this.checked_ALL_CheckedChanged);
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // btCHiTiet
            // 
            this.btCHiTiet.AutoHeight = false;
            this.btCHiTiet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.btCHiTiet.Name = "btCHiTiet";
            // 
            // checkBoTheoDoi
            // 
            this.checkBoTheoDoi.AutoHeight = false;
            this.checkBoTheoDoi.Caption = "Check";
            this.checkBoTheoDoi.Name = "checkBoTheoDoi";
            // 
            // btXoa
            // 
            this.btXoa.AutoHeight = false;
            this.btXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.btXoa.Name = "btXoa";
            this.btXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // CodeKhachHang
            // 
            this.CodeKhachHang.Caption = "CodeKhachHang";
            this.CodeKhachHang.ColumnEdit = this.repositoryItemMemoEdit3;
            this.CodeKhachHang.FieldName = "CodeKhachHang";
            this.CodeKhachHang.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.CodeKhachHang.Name = "CodeKhachHang";
            this.CodeKhachHang.OptionsColumn.AllowEdit = false;
            this.CodeKhachHang.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.CodeKhachHang.Width = 120;
            // 
            // repositoryItemMemoEdit3
            // 
            this.repositoryItemMemoEdit3.Name = "repositoryItemMemoEdit3";
            // 
            // Code
            // 
            this.Code.AppearanceCell.Options.UseTextOptions = true;
            this.Code.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Code.Caption = "Mã Đơn";
            this.Code.FieldName = "Code";
            this.Code.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.Code.Name = "Code";
            this.Code.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.Code.OptionsColumn.FixedWidth = true;
            this.Code.Visible = true;
            this.Code.VisibleIndex = 1;
            this.Code.Width = 100;
            // 
            // Type
            // 
            this.Type.Caption = "Type";
            this.Type.FieldName = "Type";
            this.Type.Name = "Type";
            this.Type.Width = 93;
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.STT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.AppearanceHeader.Options.UseFont = true;
            this.STT.AppearanceHeader.Options.UseTextOptions = true;
            this.STT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.STT.Name = "STT";
            this.STT.OptionsColumn.AllowEdit = false;
            this.STT.Width = 43;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.CreateDate,
            this.UpdateDate,
            this.Type,
            this.Code,
            this.CodeKhachHang,
            this.PaymentStatus,
            this.FullName,
            this.TongTienDonHang,
            this.TienDaThanhToan,
            this.TienNo,
            this.RecordStatus,
            this.Description,
            this.CreateUser,
            this.UpdateUser,
            this.Address,
            this.Phone,
            this.CodeSanPham,
            this.TenSanPham,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien,
            this.clXoa});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm mới tại đây";
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // CreateDate
            // 
            this.CreateDate.AppearanceCell.Options.UseTextOptions = true;
            this.CreateDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CreateDate.Caption = "Ngày tháng";
            this.CreateDate.DisplayFormat.FormatString = "HH:mm - dd/MM/yyyy";
            this.CreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.CreateDate.FieldName = "CreateDate";
            this.CreateDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.CreateDate.GroupFormat.FormatString = "HH:mm - dd/MM/yyyy";
            this.CreateDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.CreateDate.OptionsColumn.FixedWidth = true;
            this.CreateDate.Visible = true;
            this.CreateDate.VisibleIndex = 0;
            this.CreateDate.Width = 120;
            // 
            // UpdateDate
            // 
            this.UpdateDate.AppearanceCell.Options.UseTextOptions = true;
            this.UpdateDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UpdateDate.Caption = "UpdateDate";
            this.UpdateDate.DisplayFormat.FormatString = "HH:mm - dd/MM/yyyy";
            this.UpdateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.UpdateDate.FieldName = "UpdateDate";
            this.UpdateDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.UpdateDate.GroupFormat.FormatString = "HH:mm - dd/MM/yyyy";
            this.UpdateDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.UpdateDate.Name = "UpdateDate";
            this.UpdateDate.OptionsColumn.AllowEdit = false;
            this.UpdateDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.UpdateDate.Width = 80;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.Caption = "PaymentStatus";
            this.PaymentStatus.FieldName = "PaymentStatus";
            this.PaymentStatus.Name = "PaymentStatus";
            // 
            // FullName
            // 
            this.FullName.Caption = "FullName";
            this.FullName.FieldName = "FullName";
            this.FullName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.FullName.Name = "FullName";
            this.FullName.OptionsColumn.AllowEdit = false;
            this.FullName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.FullName.Width = 130;
            // 
            // TongTienDonHang
            // 
            this.TongTienDonHang.AppearanceCell.Options.UseTextOptions = true;
            this.TongTienDonHang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TongTienDonHang.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TongTienDonHang.Caption = "Tổng tiền đơn";
            this.TongTienDonHang.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.TongTienDonHang.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TongTienDonHang.FieldName = "TongTienDonHang";
            this.TongTienDonHang.GroupFormat.FormatString = "{0:#,##0.00}";
            this.TongTienDonHang.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TongTienDonHang.Name = "TongTienDonHang";
            this.TongTienDonHang.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.TongTienDonHang.OptionsColumn.FixedWidth = true;
            this.TongTienDonHang.Visible = true;
            this.TongTienDonHang.VisibleIndex = 2;
            this.TongTienDonHang.Width = 120;
            // 
            // TienDaThanhToan
            // 
            this.TienDaThanhToan.AppearanceCell.Options.UseTextOptions = true;
            this.TienDaThanhToan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TienDaThanhToan.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TienDaThanhToan.Caption = "Tiền đã thanh toán";
            this.TienDaThanhToan.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.TienDaThanhToan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TienDaThanhToan.FieldName = "TienDaThanhToan";
            this.TienDaThanhToan.GroupFormat.FormatString = "{0:#,##0.00}";
            this.TienDaThanhToan.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TienDaThanhToan.Name = "TienDaThanhToan";
            this.TienDaThanhToan.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.TienDaThanhToan.OptionsColumn.FixedWidth = true;
            this.TienDaThanhToan.Visible = true;
            this.TienDaThanhToan.VisibleIndex = 3;
            this.TienDaThanhToan.Width = 120;
            // 
            // TienNo
            // 
            this.TienNo.AppearanceCell.Options.UseTextOptions = true;
            this.TienNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TienNo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TienNo.Caption = "Tiền nợ";
            this.TienNo.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.TienNo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TienNo.FieldName = "TienNo";
            this.TienNo.GroupFormat.FormatString = "{0:#,##0.00}";
            this.TienNo.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.TienNo.Name = "TienNo";
            this.TienNo.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.TienNo.OptionsColumn.FixedWidth = true;
            this.TienNo.Visible = true;
            this.TienNo.VisibleIndex = 4;
            this.TienNo.Width = 120;
            // 
            // RecordStatus
            // 
            this.RecordStatus.Caption = "RecordStatus";
            this.RecordStatus.FieldName = "RecordStatus";
            this.RecordStatus.Name = "RecordStatus";
            // 
            // Description
            // 
            this.Description.Caption = "Description";
            this.Description.FieldName = "Description";
            this.Description.Name = "Description";
            // 
            // CreateUser
            // 
            this.CreateUser.Caption = "CreateUser";
            this.CreateUser.FieldName = "CreateUser";
            this.CreateUser.Name = "CreateUser";
            // 
            // UpdateUser
            // 
            this.UpdateUser.Caption = "UpdateUser";
            this.UpdateUser.FieldName = "UpdateUser";
            this.UpdateUser.Name = "UpdateUser";
            // 
            // Address
            // 
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.Name = "Address";
            // 
            // Phone
            // 
            this.Phone.Caption = "Phone";
            this.Phone.FieldName = "Phone";
            this.Phone.Name = "Phone";
            // 
            // CodeSanPham
            // 
            this.CodeSanPham.AppearanceCell.Options.UseTextOptions = true;
            this.CodeSanPham.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CodeSanPham.Caption = "Mã hàng";
            this.CodeSanPham.FieldName = "CodeSanPham";
            this.CodeSanPham.Name = "CodeSanPham";
            this.CodeSanPham.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.CodeSanPham.OptionsColumn.FixedWidth = true;
            this.CodeSanPham.Visible = true;
            this.CodeSanPham.VisibleIndex = 5;
            this.CodeSanPham.Width = 100;
            // 
            // TenSanPham
            // 
            this.TenSanPham.Caption = "Tên hàng hoá";
            this.TenSanPham.FieldName = "TenSanPham";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.TenSanPham.Visible = true;
            this.TenSanPham.VisibleIndex = 6;
            this.TenSanPham.Width = 345;
            // 
            // SoLuong
            // 
            this.SoLuong.AppearanceCell.Options.UseTextOptions = true;
            this.SoLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SoLuong.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.SoLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.GroupFormat.FormatString = "{0:#,##0.00}";
            this.SoLuong.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.SoLuong.OptionsColumn.FixedWidth = true;
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 7;
            this.SoLuong.Width = 90;
            // 
            // DonGia
            // 
            this.DonGia.AppearanceCell.Options.UseTextOptions = true;
            this.DonGia.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.DonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DonGia.FieldName = "DonGia";
            this.DonGia.GroupFormat.FormatString = "{0:#,##0.00}";
            this.DonGia.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DonGia.Name = "DonGia";
            this.DonGia.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.DonGia.OptionsColumn.FixedWidth = true;
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 8;
            this.DonGia.Width = 100;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AppearanceCell.Options.UseTextOptions = true;
            this.ThanhTien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.DisplayFormat.FormatString = "{0:#,##0.00}";
            this.ThanhTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.GroupFormat.FormatString = "{0:#,##0.00}";
            this.ThanhTien.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.ThanhTien.OptionsColumn.FixedWidth = true;
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 9;
            this.ThanhTien.Width = 100;
            // 
            // clXoa
            // 
            this.clXoa.Caption = "Xóa";
            this.clXoa.ColumnEdit = this.btXoa;
            this.clXoa.Name = "clXoa";
            this.clXoa.OptionsColumn.FixedWidth = true;
            this.clXoa.Width = 40;
            // 
            // gridControl1
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(5, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btXoa,
            this.checkBoTheoDoi,
            this.btCHiTiet,
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoEdit2,
            this.repositoryItemMemoEdit3});
            this.gridControl1.Size = new System.Drawing.Size(1340, 666);
            this.gridControl1.TabIndex = 82;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(67, 10);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(483, 20);
            this.txtTimKiem.TabIndex = 88;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Tìm kiếm";
            // 
            // frmDonHangCuaMoiKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 711);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.checked_ALL);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDonHangCuaMoiKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử mua hàng của khách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDonHangCuaMoiKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checked_ALL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btCHiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoTheoDoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit checked_ALL;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btCHiTiet;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit checkBoTheoDoi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoa;
        private DevExpress.XtraGrid.Columns.GridColumn CodeKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn Type;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clXoa;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn TongTienDonHang;
        private DevExpress.XtraGrid.Columns.GridColumn TienDaThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn TienNo;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn CreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn UpdateDate;
        private DevExpress.XtraGrid.Columns.GridColumn FullName;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn PaymentStatus;
        private DevExpress.XtraGrid.Columns.GridColumn RecordStatus;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn CreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn UpdateUser;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn Phone;
        private DevExpress.XtraGrid.Columns.GridColumn CodeSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn TenSanPham;
    }
}