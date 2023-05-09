
namespace Final_Project_WinForm
{
    partial class Nhap_Lop
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
            this.btn_Fix_Lop = new System.Windows.Forms.Button();
            this.btn_Xoa_Lop = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Ma_Lop = new System.Windows.Forms.TextBox();
            this.btn_Add_Lop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ten_Lop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nam_hoc = new System.Windows.Forms.TextBox();
            this.listView_DS_Lop = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ds_non = new System.Windows.Forms.Button();
            this.btn_in_ds = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NienKhoa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Fix_Lop
            // 
            this.btn_Fix_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fix_Lop.Location = new System.Drawing.Point(143, 253);
            this.btn_Fix_Lop.Name = "btn_Fix_Lop";
            this.btn_Fix_Lop.Size = new System.Drawing.Size(117, 39);
            this.btn_Fix_Lop.TabIndex = 86;
            this.btn_Fix_Lop.Text = "Sửa";
            this.btn_Fix_Lop.UseVisualStyleBackColor = true;
            this.btn_Fix_Lop.Click += new System.EventHandler(this.btn_Fix_Lop_Click);
            // 
            // btn_Xoa_Lop
            // 
            this.btn_Xoa_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_Lop.Location = new System.Drawing.Point(285, 253);
            this.btn_Xoa_Lop.Name = "btn_Xoa_Lop";
            this.btn_Xoa_Lop.Size = new System.Drawing.Size(98, 39);
            this.btn_Xoa_Lop.TabIndex = 85;
            this.btn_Xoa_Lop.Text = "Xóa";
            this.btn_Xoa_Lop.UseVisualStyleBackColor = true;
            this.btn_Xoa_Lop.Click += new System.EventHandler(this.btn_Xoa_Lop_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 26);
            this.label12.TabIndex = 81;
            this.label12.Text = "Mã Lớp:";
            // 
            // txt_Ma_Lop
            // 
            this.txt_Ma_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma_Lop.Location = new System.Drawing.Point(143, 57);
            this.txt_Ma_Lop.Multiline = true;
            this.txt_Ma_Lop.Name = "txt_Ma_Lop";
            this.txt_Ma_Lop.Size = new System.Drawing.Size(166, 39);
            this.txt_Ma_Lop.TabIndex = 80;
            // 
            // btn_Add_Lop
            // 
            this.btn_Add_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Lop.Location = new System.Drawing.Point(23, 253);
            this.btn_Add_Lop.Name = "btn_Add_Lop";
            this.btn_Add_Lop.Size = new System.Drawing.Size(98, 39);
            this.btn_Add_Lop.TabIndex = 79;
            this.btn_Add_Lop.Text = "Thêm";
            this.btn_Add_Lop.UseVisualStyleBackColor = true;
            this.btn_Add_Lop.Click += new System.EventHandler(this.btn_Add_Lop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 88;
            this.label2.Text = "Tên Lớp:";
            // 
            // txt_Ten_Lop
            // 
            this.txt_Ten_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten_Lop.Location = new System.Drawing.Point(143, 114);
            this.txt_Ten_Lop.Multiline = true;
            this.txt_Ten_Lop.Name = "txt_Ten_Lop";
            this.txt_Ten_Lop.Size = new System.Drawing.Size(166, 39);
            this.txt_Ten_Lop.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 90;
            this.label3.Text = "Năm Học:";
            // 
            // txt_Nam_hoc
            // 
            this.txt_Nam_hoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nam_hoc.Location = new System.Drawing.Point(143, 175);
            this.txt_Nam_hoc.Multiline = true;
            this.txt_Nam_hoc.Name = "txt_Nam_hoc";
            this.txt_Nam_hoc.Size = new System.Drawing.Size(166, 39);
            this.txt_Nam_hoc.TabIndex = 89;
            // 
            // listView_DS_Lop
            // 
            this.listView_DS_Lop.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_DS_Lop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_DS_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_DS_Lop.FullRowSelect = true;
            this.listView_DS_Lop.GridLines = true;
            this.listView_DS_Lop.HideSelection = false;
            this.listView_DS_Lop.LabelEdit = true;
            this.listView_DS_Lop.Location = new System.Drawing.Point(3, 22);
            this.listView_DS_Lop.Name = "listView_DS_Lop";
            this.listView_DS_Lop.Size = new System.Drawing.Size(608, 587);
            this.listView_DS_Lop.TabIndex = 93;
            this.listView_DS_Lop.UseCompatibleStateImageBehavior = false;
            this.listView_DS_Lop.View = System.Windows.Forms.View.Details;
            this.listView_DS_Lop.SelectedIndexChanged += new System.EventHandler(this.listView_DS_Lop_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Lớp";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Lớp";
            this.columnHeader2.Width = 154;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Năm Học";
            this.columnHeader3.Width = 149;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 52);
            this.panel1.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 26);
            this.label4.TabIndex = 82;
            this.label4.Text = "Quản Lý Lớp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ds_non);
            this.groupBox1.Controls.Add(this.btn_in_ds);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_NienKhoa);
            this.groupBox1.Controls.Add(this.btn_Xoa_Lop);
            this.groupBox1.Controls.Add(this.btn_Add_Lop);
            this.groupBox1.Controls.Add(this.txt_Ma_Lop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_Nam_hoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Ten_Lop);
            this.groupBox1.Controls.Add(this.btn_Fix_Lop);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 612);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin:";
            // 
            // btn_ds_non
            // 
            this.btn_ds_non.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ds_non.Location = new System.Drawing.Point(185, 463);
            this.btn_ds_non.Name = "btn_ds_non";
            this.btn_ds_non.Size = new System.Drawing.Size(98, 39);
            this.btn_ds_non.TabIndex = 94;
            this.btn_ds_non.Text = "In ds ";
            this.btn_ds_non.UseVisualStyleBackColor = true;
            this.btn_ds_non.Click += new System.EventHandler(this.btn_ds_non_Click);
            // 
            // btn_in_ds
            // 
            this.btn_in_ds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in_ds.Location = new System.Drawing.Point(185, 394);
            this.btn_in_ds.Name = "btn_in_ds";
            this.btn_in_ds.Size = new System.Drawing.Size(124, 39);
            this.btn_in_ds.TabIndex = 93;
            this.btn_in_ds.Text = "in_ds_NK";
            this.btn_in_ds.UseVisualStyleBackColor = true;
            this.btn_in_ds.Click += new System.EventHandler(this.btn_in_ds_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 92;
            this.label1.Text = "Niên khóa:";
            // 
            // txt_NienKhoa
            // 
            this.txt_NienKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NienKhoa.Location = new System.Drawing.Point(159, 334);
            this.txt_NienKhoa.Multiline = true;
            this.txt_NienKhoa.Name = "txt_NienKhoa";
            this.txt_NienKhoa.Size = new System.Drawing.Size(166, 39);
            this.txt_NienKhoa.TabIndex = 91;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView_DS_Lop);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(418, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 612);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách lớp:";
            // 
            // Nhap_Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 664);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Nhap_Lop";
            this.Text = "NhapLop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Fix_Lop;
        private System.Windows.Forms.Button btn_Xoa_Lop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Ma_Lop;
        private System.Windows.Forms.Button btn_Add_Lop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ten_Lop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nam_hoc;
        private System.Windows.Forms.ListView listView_DS_Lop;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NienKhoa;
        private System.Windows.Forms.Button btn_in_ds;
        private System.Windows.Forms.Button btn_ds_non;
    }
}