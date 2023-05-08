
namespace Final_Project_WinForm
{
    partial class Show_Diem_TongKet
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
            this.listView_ds_Diem_TB_TK = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lable_namhoc = new System.Windows.Forms.Label();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.lable_lop = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Show = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_ds_Diem_TB_TK
            // 
            this.listView_ds_Diem_TB_TK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_ds_Diem_TB_TK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_ds_Diem_TB_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_ds_Diem_TB_TK.FullRowSelect = true;
            this.listView_ds_Diem_TB_TK.GridLines = true;
            this.listView_ds_Diem_TB_TK.HideSelection = false;
            this.listView_ds_Diem_TB_TK.Location = new System.Drawing.Point(0, 109);
            this.listView_ds_Diem_TB_TK.Name = "listView_ds_Diem_TB_TK";
            this.listView_ds_Diem_TB_TK.Size = new System.Drawing.Size(800, 341);
            this.listView_ds_Diem_TB_TK.TabIndex = 125;
            this.listView_ds_Diem_TB_TK.UseCompatibleStateImageBehavior = false;
            this.listView_ds_Diem_TB_TK.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "MSSV";
            this.columnHeader2.Width = 122;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Họ và Tên";
            this.columnHeader3.Width = 137;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 26);
            this.label1.TabIndex = 105;
            this.label1.Text = "BẢNG ĐIỂM TỔNG KẾT";
            // 
            // lable_namhoc
            // 
            this.lable_namhoc.AutoSize = true;
            this.lable_namhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_namhoc.ForeColor = System.Drawing.Color.Red;
            this.lable_namhoc.Location = new System.Drawing.Point(726, 52);
            this.lable_namhoc.Name = "lable_namhoc";
            this.lable_namhoc.Size = new System.Drawing.Size(60, 26);
            this.lable_namhoc.TabIndex = 110;
            this.lable_namhoc.Text = "2020";
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLop.Location = new System.Drawing.Point(12, 52);
            this.txt_MaLop.Multiline = true;
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(124, 39);
            this.txt_MaLop.TabIndex = 88;
            // 
            // lable_lop
            // 
            this.lable_lop.AutoSize = true;
            this.lable_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_lop.ForeColor = System.Drawing.Color.Red;
            this.lable_lop.Location = new System.Drawing.Point(387, 52);
            this.lable_lop.Name = "lable_lop";
            this.lable_lop.Size = new System.Drawing.Size(79, 26);
            this.lable_lop.TabIndex = 109;
            this.lable_lop.Text = "HS200";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 26);
            this.label12.TabIndex = 89;
            this.label12.Text = "Mã Lớp:";
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.Location = new System.Drawing.Point(153, 52);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(95, 39);
            this.btn_Show.TabIndex = 104;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(552, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 26);
            this.label6.TabIndex = 107;
            this.label6.Text = "Năm Nhập Học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(327, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 26);
            this.label4.TabIndex = 106;
            this.label4.Text = "Lớp:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lable_namhoc);
            this.panel1.Controls.Add(this.txt_MaLop);
            this.panel1.Controls.Add(this.lable_lop);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btn_Show);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 109);
            this.panel1.TabIndex = 124;
            // 
            // Show_Diem_TongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView_ds_Diem_TB_TK);
            this.Controls.Add(this.panel1);
            this.Name = "Show_Diem_TongKet";
            this.Text = "Show_Diem_TongKet";
            this.Load += new System.EventHandler(this.Show_Diem_TongKet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_ds_Diem_TB_TK;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable_namhoc;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.Label lable_lop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}