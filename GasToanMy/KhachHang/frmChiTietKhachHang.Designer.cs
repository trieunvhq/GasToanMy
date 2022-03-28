namespace GasToanMy
{
    partial class frmChiTietKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietKhachHang));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.layoutControl4 = new DevExpress.XtraLayout.LayoutControl();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dateNgayThang = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem53 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem51 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btChiLuu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).BeginInit();
            this.layoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThang.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.layoutControl4);
            this.groupBox4.Location = new System.Drawing.Point(22, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.groupBox4.Size = new System.Drawing.Size(636, 302);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // layoutControl4
            // 
            this.layoutControl4.Controls.Add(this.txtScore);
            this.layoutControl4.Controls.Add(this.txtEmail);
            this.layoutControl4.Controls.Add(this.txtPhone);
            this.layoutControl4.Controls.Add(this.txtFullName);
            this.layoutControl4.Controls.Add(this.txtCode);
            this.layoutControl4.Controls.Add(this.txtGhiChu);
            this.layoutControl4.Controls.Add(this.txtAddress);
            this.layoutControl4.Controls.Add(this.dateNgayThang);
            this.layoutControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl4.Location = new System.Drawing.Point(5, 23);
            this.layoutControl4.Name = "layoutControl4";
            this.layoutControl4.Root = this.layoutControlGroup4;
            this.layoutControl4.Size = new System.Drawing.Size(626, 274);
            this.layoutControl4.TabIndex = 0;
            this.layoutControl4.Text = "layoutControl4";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(68, 146);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(556, 20);
            this.txtScore.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(68, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(556, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(68, 98);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(556, 20);
            this.txtPhone.TabIndex = 14;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(68, 50);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(556, 20);
            this.txtFullName.TabIndex = 13;
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhaCungCap_KeyPress);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(68, 2);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(556, 20);
            this.txtCode.TabIndex = 10;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(68, 170);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(556, 102);
            this.txtGhiChu.TabIndex = 7;
            this.txtGhiChu.Text = "";
            this.txtGhiChu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGhiChu_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(68, 74);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(556, 20);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSanPham_KeyPress);
            // 
            // dateNgayThang
            // 
            this.dateNgayThang.EditValue = null;
            this.dateNgayThang.Location = new System.Drawing.Point(68, 26);
            this.dateNgayThang.Name = "dateNgayThang";
            this.dateNgayThang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dateNgayThang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayThang.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayThang.Properties.DisplayFormat.FormatString = "HH:mm - dd/MM/yyyy";
            this.dateNgayThang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateNgayThang.Properties.EditFormat.FormatString = "HH:mm - dd/MM/yyyy";
            this.dateNgayThang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateNgayThang.Properties.Mask.EditMask = "HH:mm - dd/MM/yyyy";
            this.dateNgayThang.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateNgayThang.Size = new System.Drawing.Size(556, 20);
            this.dateNgayThang.StyleController = this.layoutControl4;
            this.dateNgayThang.TabIndex = 0;
            this.dateNgayThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateNgayThang_KeyPress);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem53,
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem51,
            this.layoutControlItem6,
            this.layoutControlItem2,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup4.Name = "layoutControlGroup1";
            this.layoutControlGroup4.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup4.Size = new System.Drawing.Size(626, 274);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // layoutControlItem53
            // 
            this.layoutControlItem53.Control = this.txtAddress;
            this.layoutControlItem53.CustomizationFormText = "Số KG/Bao";
            this.layoutControlItem53.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem53.Name = "layoutControlItem53";
            this.layoutControlItem53.Size = new System.Drawing.Size(626, 24);
            this.layoutControlItem53.Text = "Địa chỉ";
            this.layoutControlItem53.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtGhiChu;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(626, 106);
            this.layoutControlItem1.Text = "Ghi chú";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtCode;
            this.layoutControlItem4.CustomizationFormText = "Mã khách hàng";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(626, 24);
            this.layoutControlItem4.Text = "Mã sản phẩm";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem51
            // 
            this.layoutControlItem51.Control = this.dateNgayThang;
            this.layoutControlItem51.CustomizationFormText = "Ngày sản xuất";
            this.layoutControlItem51.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem51.Name = "layoutControlItem51";
            this.layoutControlItem51.Size = new System.Drawing.Size(626, 24);
            this.layoutControlItem51.Text = "Ngày nhập";
            this.layoutControlItem51.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtFullName;
            this.layoutControlItem6.CustomizationFormText = "Họ tên";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(626, 24);
            this.layoutControlItem6.Text = "Họ tên";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtPhone;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(626, 24);
            this.layoutControlItem2.Text = "Điện thoại";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtEmail;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(626, 24);
            this.layoutControlItem7.Text = "Mail";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(63, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtScore;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(626, 24);
            this.layoutControlItem8.Text = "Điểm";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(63, 13);
            // 
            // btThoat
            // 
            this.btThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Appearance.Options.UseFont = true;
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.ImageOptions.Image = global::GasToanMy.Properties.Resources.ico_Abort;
            this.btThoat.Location = new System.Drawing.Point(829, 599);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(82, 22);
            this.btThoat.TabIndex = 113;
            this.btThoat.Text = "Thoát";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btChiLuu
            // 
            this.btChiLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChiLuu.Appearance.Options.UseFont = true;
            this.btChiLuu.ImageOptions.Image = global::GasToanMy.Properties.Resources.ico_Save;
            this.btChiLuu.Location = new System.Drawing.Point(731, 599);
            this.btChiLuu.Name = "btChiLuu";
            this.btChiLuu.Size = new System.Drawing.Size(92, 22);
            this.btChiLuu.TabIndex = 114;
            this.btChiLuu.Text = "Lưu";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton1.ImageOptions.Image = global::GasToanMy.Properties.Resources.ico_Abort;
            this.simpleButton1.Location = new System.Drawing.Point(591, 329);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(67, 22);
            this.simpleButton1.TabIndex = 19;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Appearance.Options.UseFont = true;
            this.btSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btSave.ImageOptions.Image")));
            this.btSave.Location = new System.Drawing.Point(518, 328);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(67, 23);
            this.btSave.TabIndex = 18;
            this.btSave.Text = "Lưu";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // frmChiTietKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 360);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btChiLuu);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChiTietKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết sản phẩm";
            this.Load += new System.EventHandler(this.frmChiTietKhachHang_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl4)).EndInit();
            this.layoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThang.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraLayout.LayoutControl layoutControl4;
        private System.Windows.Forms.TextBox txtAddress;
        private DevExpress.XtraEditors.DateEdit dateNgayThang;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem53;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem51;
        private DevExpress.XtraEditors.SimpleButton btThoat;
        private DevExpress.XtraEditors.SimpleButton btChiLuu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btSave;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.TextBox txtCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.TextBox txtFullName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}