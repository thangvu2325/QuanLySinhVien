
namespace Final_Project_WinForm
{
    partial class Nhap_MonHoc
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
            this.txt_TenMonHoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Add_Monhoc = new System.Windows.Forms.Button();
            this.txt_STCTH = new System.Windows.Forms.TextBox();
            this.txt_MaMonHoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_STCLT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Xoa_MH = new System.Windows.Forms.Button();
            this.btn_fix_MH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_inds = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView_DSMH = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_TenMonHoc
            // 
            this.txt_TenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenMonHoc.Location = new System.Drawing.Point(285, 129);
            this.txt_TenMonHoc.Multiline = true;
            this.txt_TenMonHoc.Name = "txt_TenMonHoc";
            this.txt_TenMonHoc.Size = new System.Drawing.Size(148, 39);
            this.txt_TenMonHoc.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 26);
            this.label4.TabIndex = 114;
            this.label4.Text = "Số tín chỉ thực hành:";
            // 
            // btn_Add_Monhoc
            // 
            this.btn_Add_Monhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Monhoc.Location = new System.Drawing.Point(86, 336);
            this.btn_Add_Monhoc.Name = "btn_Add_Monhoc";
            this.btn_Add_Monhoc.Size = new System.Drawing.Size(80, 39);
            this.btn_Add_Monhoc.TabIndex = 102;
            this.btn_Add_Monhoc.Text = "Thêm";
            this.btn_Add_Monhoc.UseVisualStyleBackColor = true;
            this.btn_Add_Monhoc.Click += new System.EventHandler(this.btn_Add_Monhoc_Click);
            // 
            // txt_STCTH
            // 
            this.txt_STCTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_STCTH.Location = new System.Drawing.Point(285, 261);
            this.txt_STCTH.Multiline = true;
            this.txt_STCTH.Name = "txt_STCTH";
            this.txt_STCTH.Size = new System.Drawing.Size(148, 39);
            this.txt_STCTH.TabIndex = 113;
            // 
            // txt_MaMonHoc
            // 
            this.txt_MaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaMonHoc.Location = new System.Drawing.Point(285, 68);
            this.txt_MaMonHoc.Multiline = true;
            this.txt_MaMonHoc.Name = "txt_MaMonHoc";
            this.txt_MaMonHoc.Size = new System.Drawing.Size(148, 39);
            this.txt_MaMonHoc.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 26);
            this.label3.TabIndex = 112;
            this.label3.Text = "Số tín chỉ lý thuyết:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 26);
            this.label12.TabIndex = 104;
            this.label12.Text = "Mã môn học:";
            // 
            // txt_STCLT
            // 
            this.txt_STCLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_STCLT.Location = new System.Drawing.Point(285, 187);
            this.txt_STCLT.Multiline = true;
            this.txt_STCLT.Name = "txt_STCLT";
            this.txt_STCLT.Size = new System.Drawing.Size(148, 39);
            this.txt_STCLT.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 110;
            this.label2.Text = "Tên môn học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 26);
            this.label1.TabIndex = 106;
            this.label1.Text = "In danh sách môn học:";
            // 
            // btn_Xoa_MH
            // 
            this.btn_Xoa_MH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_MH.Location = new System.Drawing.Point(172, 336);
            this.btn_Xoa_MH.Name = "btn_Xoa_MH";
            this.btn_Xoa_MH.Size = new System.Drawing.Size(80, 39);
            this.btn_Xoa_MH.TabIndex = 107;
            this.btn_Xoa_MH.Text = "Xóa";
            this.btn_Xoa_MH.UseVisualStyleBackColor = true;
            this.btn_Xoa_MH.Click += new System.EventHandler(this.btn_Xoa_MH_Click);
            // 
            // btn_fix_MH
            // 
            this.btn_fix_MH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fix_MH.Location = new System.Drawing.Point(258, 336);
            this.btn_fix_MH.Name = "btn_fix_MH";
            this.btn_fix_MH.Size = new System.Drawing.Size(134, 39);
            this.btn_fix_MH.TabIndex = 108;
            this.btn_fix_MH.Text = "Hiệu Chỉnh";
            this.btn_fix_MH.UseVisualStyleBackColor = true;
            this.btn_fix_MH.Click += new System.EventHandler(this.btn_fix_MH_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 52);
            this.panel1.TabIndex = 115;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 26);
            this.label5.TabIndex = 82;
            this.label5.Text = "Quản Lý Môn Học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_inds);
            this.groupBox1.Controls.Add(this.txt_TenMonHoc);
            this.groupBox1.Controls.Add(this.btn_fix_MH);
            this.groupBox1.Controls.Add(this.btn_Xoa_MH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Add_Monhoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_STCTH);
            this.groupBox1.Controls.Add(this.txt_MaMonHoc);
            this.groupBox1.Controls.Add(this.txt_STCLT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 554);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin:";
            // 
            // btn_inds
            // 
            this.btn_inds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inds.Location = new System.Drawing.Point(258, 405);
            this.btn_inds.Name = "btn_inds";
            this.btn_inds.Size = new System.Drawing.Size(80, 39);
            this.btn_inds.TabIndex = 115;
            this.btn_inds.Text = "in ds";
            this.btn_inds.UseVisualStyleBackColor = true;
            this.btn_inds.Click += new System.EventHandler(this.btn_inds_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView_DSMH);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(470, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 554);
            this.groupBox2.TabIndex = 117;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách môn học:";
            // 
            // listView_DSMH
            // 
            this.listView_DSMH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_DSMH.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView_DSMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_DSMH.FullRowSelect = true;
            this.listView_DSMH.GridLines = true;
            this.listView_DSMH.HideSelection = false;
            this.listView_DSMH.Location = new System.Drawing.Point(3, 22);
            this.listView_DSMH.Name = "listView_DSMH";
            this.listView_DSMH.Size = new System.Drawing.Size(608, 529);
            this.listView_DSMH.TabIndex = 95;
            this.listView_DSMH.UseCompatibleStateImageBehavior = false;
            this.listView_DSMH.View = System.Windows.Forms.View.Details;
            this.listView_DSMH.SelectedIndexChanged += new System.EventHandler(this.listView_DSMH_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Môn Học";
            this.columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Môn Học";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "STCLT";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STCTH";
            this.columnHeader4.Width = 89;
            // 
            // Nhap_MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Nhap_MonHoc";
            this.Text = "Nhap_MonHoc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TenMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Add_Monhoc;
        private System.Windows.Forms.TextBox txt_STCTH;
        private System.Windows.Forms.TextBox txt_MaMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_STCLT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Xoa_MH;
        private System.Windows.Forms.Button btn_fix_MH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView_DSMH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_inds;
    }
}