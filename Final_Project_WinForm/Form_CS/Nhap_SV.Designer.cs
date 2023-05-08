
namespace Final_Project_WinForm
{
    partial class Nhap_SV
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
            this.checkBox_NU = new System.Windows.Forms.CheckBox();
            this.checkBox_Nam = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Fix_SV = new System.Windows.Forms.Button();
            this.btn_Xoa_SV = new System.Windows.Forms.Button();
            this.txt_Ma_Lop = new System.Windows.Forms.TextBox();
            this.btn_Them_SV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView_DSSV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_NU
            // 
            this.checkBox_NU.AutoSize = true;
            this.checkBox_NU.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_NU.Location = new System.Drawing.Point(281, 286);
            this.checkBox_NU.Name = "checkBox_NU";
            this.checkBox_NU.Size = new System.Drawing.Size(62, 30);
            this.checkBox_NU.TabIndex = 113;
            this.checkBox_NU.Text = "Nữ";
            this.checkBox_NU.UseVisualStyleBackColor = true;
            this.checkBox_NU.CheckedChanged += new System.EventHandler(this.checkBox_NU_CheckedChanged);
            // 
            // checkBox_Nam
            // 
            this.checkBox_Nam.AutoSize = true;
            this.checkBox_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Nam.Location = new System.Drawing.Point(194, 286);
            this.checkBox_Nam.Name = "checkBox_Nam";
            this.checkBox_Nam.Size = new System.Drawing.Size(81, 30);
            this.checkBox_Nam.TabIndex = 112;
            this.checkBox_Nam.Text = "Nam";
            this.checkBox_Nam.UseVisualStyleBackColor = true;
            this.checkBox_Nam.CheckedChanged += new System.EventHandler(this.checkBox_Nam_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 26);
            this.label8.TabIndex = 111;
            this.label8.Text = "SĐT:";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(200, 333);
            this.txt_SDT.Multiline = true;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(143, 39);
            this.txt_SDT.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(111, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 26);
            this.label7.TabIndex = 109;
            this.label7.Text = "Phái:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 26);
            this.label6.TabIndex = 108;
            this.label6.Text = "Tên:";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten.Location = new System.Drawing.Point(200, 226);
            this.txt_Ten.Multiline = true;
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(143, 43);
            this.txt_Ten.TabIndex = 107;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 26);
            this.label5.TabIndex = 106;
            this.label5.Text = "Họ:";
            // 
            // txt_HO
            // 
            this.txt_HO.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HO.Location = new System.Drawing.Point(200, 177);
            this.txt_HO.Multiline = true;
            this.txt_HO.Name = "txt_HO";
            this.txt_HO.Size = new System.Drawing.Size(143, 43);
            this.txt_HO.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 26);
            this.label4.TabIndex = 104;
            this.label4.Text = "MSSV:";
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MSSV.Location = new System.Drawing.Point(200, 117);
            this.txt_MSSV.Multiline = true;
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(143, 43);
            this.txt_MSSV.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 102;
            this.label3.Text = "Mã lớp:";
            // 
            // btn_Fix_SV
            // 
            this.btn_Fix_SV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fix_SV.Location = new System.Drawing.Point(200, 387);
            this.btn_Fix_SV.Name = "btn_Fix_SV";
            this.btn_Fix_SV.Size = new System.Drawing.Size(129, 43);
            this.btn_Fix_SV.TabIndex = 101;
            this.btn_Fix_SV.Text = "Hiệu Chỉnh";
            this.btn_Fix_SV.UseVisualStyleBackColor = true;
            this.btn_Fix_SV.Click += new System.EventHandler(this.btn_Fix_SV_Click);
            // 
            // btn_Xoa_SV
            // 
            this.btn_Xoa_SV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_SV.Location = new System.Drawing.Point(335, 387);
            this.btn_Xoa_SV.Name = "btn_Xoa_SV";
            this.btn_Xoa_SV.Size = new System.Drawing.Size(75, 43);
            this.btn_Xoa_SV.TabIndex = 100;
            this.btn_Xoa_SV.Text = "Xóa";
            this.btn_Xoa_SV.UseVisualStyleBackColor = true;
            this.btn_Xoa_SV.Click += new System.EventHandler(this.btn_Xoa_SV_Click);
            // 
            // txt_Ma_Lop
            // 
            this.txt_Ma_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma_Lop.Location = new System.Drawing.Point(132, 50);
            this.txt_Ma_Lop.Multiline = true;
            this.txt_Ma_Lop.Name = "txt_Ma_Lop";
            this.txt_Ma_Lop.Size = new System.Drawing.Size(143, 43);
            this.txt_Ma_Lop.TabIndex = 98;
            // 
            // btn_Them_SV
            // 
            this.btn_Them_SV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_SV.Location = new System.Drawing.Point(119, 387);
            this.btn_Them_SV.Name = "btn_Them_SV";
            this.btn_Them_SV.Size = new System.Drawing.Size(75, 43);
            this.btn_Them_SV.TabIndex = 97;
            this.btn_Them_SV.Text = "Thêm";
            this.btn_Them_SV.UseVisualStyleBackColor = true;
            this.btn_Them_SV.Click += new System.EventHandler(this.btn_Them_SV_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 52);
            this.panel1.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 26);
            this.label1.TabIndex = 82;
            this.label1.Text = "Quản lý Sinh viên 1 Lớp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Select);
            this.groupBox1.Controls.Add(this.txt_HO);
            this.groupBox1.Controls.Add(this.btn_Them_SV);
            this.groupBox1.Controls.Add(this.txt_Ma_Lop);
            this.groupBox1.Controls.Add(this.checkBox_NU);
            this.groupBox1.Controls.Add(this.btn_Xoa_SV);
            this.groupBox1.Controls.Add(this.checkBox_Nam);
            this.groupBox1.Controls.Add(this.btn_Fix_SV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.txt_MSSV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Ten);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 579);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin:";
            // 
            // btn_Select
            // 
            this.btn_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Select.Location = new System.Drawing.Point(293, 50);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 43);
            this.btn_Select.TabIndex = 115;
            this.btn_Select.Text = "Chọn";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView_DSSV);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(466, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 579);
            this.groupBox2.TabIndex = 117;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lớp:";
            // 
            // listView_DSSV
            // 
            this.listView_DSSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_DSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_DSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_DSSV.FullRowSelect = true;
            this.listView_DSSV.GridLines = true;
            this.listView_DSSV.HideSelection = false;
            this.listView_DSSV.Location = new System.Drawing.Point(3, 22);
            this.listView_DSSV.Name = "listView_DSSV";
            this.listView_DSSV.Size = new System.Drawing.Size(758, 554);
            this.listView_DSSV.TabIndex = 94;
            this.listView_DSSV.UseCompatibleStateImageBehavior = false;
            this.listView_DSSV.View = System.Windows.Forms.View.Details;
            this.listView_DSSV.SelectedIndexChanged += new System.EventHandler(this.listView_DSSV_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MSSV";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ ";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới Tính";
            this.columnHeader4.Width = 83;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SĐT";
            this.columnHeader5.Width = 138;
            // 
            // Nhap_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 631);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Nhap_SV";
            this.Text = "Update_SV";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_NU;
        private System.Windows.Forms.CheckBox checkBox_Nam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_HO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Fix_SV;
        private System.Windows.Forms.Button btn_Xoa_SV;
        private System.Windows.Forms.TextBox txt_Ma_Lop;
        private System.Windows.Forms.Button btn_Them_SV;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView_DSSV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_Select;
    }
}