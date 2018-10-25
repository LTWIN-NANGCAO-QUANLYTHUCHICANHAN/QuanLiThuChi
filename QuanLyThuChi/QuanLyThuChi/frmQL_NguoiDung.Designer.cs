namespace QuanLyThuChi
{
    partial class frmQL_NguoiDung
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
            this.components = new System.ComponentModel.Container();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tenDN = new DevExpress.XtraEditors.TextEdit();
            this.txt_MK = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hoatdongChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NGUOI_DUNGTableAdapter1 = new QuanLyThuChi.QLTC_DataSetTableAdapters.QL_NGUOI_DUNGTableAdapter();
            this.qltC_DataSet1 = new QuanLyThuChi.QLTC_DataSet();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.cT_HANG_MUC_CHITableAdapter1 = new QuanLyThuChi.QLTC_DataSetTableAdapters.CT_HANG_MUC_CHITableAdapter();
            this.tableAdapterManager1 = new QuanLyThuChi.QLTC_DataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qltC_DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(336, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(336, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(336, 99);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Hoạt động";
            // 
            // txt_tenDN
            // 
            this.txt_tenDN.Location = new System.Drawing.Point(445, 36);
            this.txt_tenDN.Name = "txt_tenDN";
            this.txt_tenDN.Size = new System.Drawing.Size(206, 20);
            this.txt_tenDN.TabIndex = 0;
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(445, 66);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(206, 20);
            this.txt_MK.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(117, 135);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(628, 346);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.hoatdongChecked});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
           
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên đăng nhập";
            this.gridColumn1.FieldName = "MANGUOIDUNG";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mật khẩu";
            this.gridColumn2.FieldName = "MATKHAU";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // hoatdongChecked
            // 
            this.hoatdongChecked.Caption = "Hoạt động";
            this.hoatdongChecked.ColumnEdit = this.repositoryItemCheckEdit1;
            this.hoatdongChecked.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.hoatdongChecked.FieldName = "HOATDONG";
            this.hoatdongChecked.Name = "hoatdongChecked";
            this.hoatdongChecked.Visible = true;
            this.hoatdongChecked.VisibleIndex = 2;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(445, 99);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Có hoạt động?";
            this.checkEdit1.Size = new System.Drawing.Size(101, 19);
            this.checkEdit1.TabIndex = 2;
            // 
            // qL_NGUOI_DUNGTableAdapter1
            // 
            this.qL_NGUOI_DUNGTableAdapter1.ClearBeforeFill = true;
            // 
            // qltC_DataSet1
            // 
            this.qltC_DataSet1.DataSetName = "QLTC_DataSet";
            this.qltC_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_them
            // 
            this.btn_them.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources._07_plus_128;
            this.btn_them.Location = new System.Drawing.Point(13, 135);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 41);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.save1;
            this.btn_Luu.Location = new System.Drawing.Point(13, 200);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 41);
            this.btn_Luu.TabIndex = 4;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.xoa;
            this.btn_xoa.Location = new System.Drawing.Point(12, 264);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 41);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources.revert;
            this.btn_sua.Location = new System.Drawing.Point(13, 333);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 41);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Sửa";
            // 
            // btn_thoat
            // 
            this.btn_thoat.ImageOptions.Image = global::QuanLyThuChi.Properties.Resources._010_x_5121;
            this.btn_thoat.Location = new System.Drawing.Point(13, 397);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 41);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            // 
            // cT_HANG_MUC_CHITableAdapter1
            // 
            this.cT_HANG_MUC_CHITableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CT_HANG_MUC_CHITableAdapter = this.cT_HANG_MUC_CHITableAdapter1;
            this.tableAdapterManager1.CT_HANG_MUC_THUTableAdapter = null;
            this.tableAdapterManager1.DM_MANHINHTableAdapter = null;
            this.tableAdapterManager1.HANG_MUC_CHITableAdapter = null;
            this.tableAdapterManager1.HANG_MUC_THUTableAdapter = null;
            this.tableAdapterManager1.PHIEU_CHITableAdapter = null;
            this.tableAdapterManager1.PHIEU_THUTableAdapter = null;
            this.tableAdapterManager1.QL_NGUOI_DUNGTableAdapter = this.qL_NGUOI_DUNGTableAdapter1;
            this.tableAdapterManager1.QL_NGUOIDUNG_NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager1.QL_NHOM_NDTableAdapter = null;
            this.tableAdapterManager1.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager1.TAI_KHOANTableAdapter = null;
            this.tableAdapterManager1.TIEN_TETableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = QuanLyThuChi.QLTC_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyThuChi.Properties.Resources.mem___Copy;
            this.pictureBox1.Location = new System.Drawing.Point(180, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 126);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmQL_NguoiDung
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 493);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_tenDN);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQL_NguoiDung";
            this.Text = "Người sử dụng";
            this.Load += new System.EventHandler(this.frmQL_NguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qltC_DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_tenDN;
        private DevExpress.XtraEditors.TextEdit txt_MK;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn hoatdongChecked;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private QLTC_DataSetTableAdapters.QL_NGUOI_DUNGTableAdapter qL_NGUOI_DUNGTableAdapter1;
        private QLTC_DataSet qltC_DataSet1;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private QLTC_DataSetTableAdapters.CT_HANG_MUC_CHITableAdapter cT_HANG_MUC_CHITableAdapter1;
        private QLTC_DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}