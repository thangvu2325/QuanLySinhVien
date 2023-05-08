
namespace Final_Project_WinForm
{
    partial class Main_Form
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
            this.btn_Nhap_Lop = new System.Windows.Forms.Button();
            this.btn_Nhap_SV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Nhap_Diem = new System.Windows.Forms.Button();
            this.btn_Nhap_MonHoc = new System.Windows.Forms.Button();
            this.btn_Show_Diem_lanthi = new System.Windows.Forms.Button();
            this.btn_Show_Diem_TB = new System.Windows.Forms.Button();
            this.btn_add_MH_LT = new System.Windows.Forms.Button();
            this.btn_Tong_Ket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Nhap_Lop
            // 
            this.btn_Nhap_Lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhap_Lop.Location = new System.Drawing.Point(422, 124);
            this.btn_Nhap_Lop.Name = "btn_Nhap_Lop";
            this.btn_Nhap_Lop.Size = new System.Drawing.Size(134, 39);
            this.btn_Nhap_Lop.TabIndex = 94;
            this.btn_Nhap_Lop.Text = "Nhập Lớp";
            this.btn_Nhap_Lop.UseVisualStyleBackColor = true;
            this.btn_Nhap_Lop.Click += new System.EventHandler(this.btn_Nhap_Lop_Click);
            // 
            // btn_Nhap_SV
            // 
            this.btn_Nhap_SV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhap_SV.Location = new System.Drawing.Point(397, 169);
            this.btn_Nhap_SV.Name = "btn_Nhap_SV";
            this.btn_Nhap_SV.Size = new System.Drawing.Size(180, 39);
            this.btn_Nhap_SV.TabIndex = 93;
            this.btn_Nhap_SV.Text = "Nhập Sinh Viên";
            this.btn_Nhap_SV.UseVisualStyleBackColor = true;
            this.btn_Nhap_SV.Click += new System.EventHandler(this.btn_Nhap_SV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 92;
            this.label1.Text = "Sự lựa chọn của bạn là?";
            // 
            // btn_Nhap_Diem
            // 
            this.btn_Nhap_Diem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhap_Diem.Location = new System.Drawing.Point(397, 306);
            this.btn_Nhap_Diem.Name = "btn_Nhap_Diem";
            this.btn_Nhap_Diem.Size = new System.Drawing.Size(186, 45);
            this.btn_Nhap_Diem.TabIndex = 90;
            this.btn_Nhap_Diem.Text = "Nhập Điểm";
            this.btn_Nhap_Diem.UseVisualStyleBackColor = true;
            this.btn_Nhap_Diem.Click += new System.EventHandler(this.btn_Nhap_Diem_Click);
            // 
            // btn_Nhap_MonHoc
            // 
            this.btn_Nhap_MonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhap_MonHoc.Location = new System.Drawing.Point(390, 214);
            this.btn_Nhap_MonHoc.Name = "btn_Nhap_MonHoc";
            this.btn_Nhap_MonHoc.Size = new System.Drawing.Size(204, 39);
            this.btn_Nhap_MonHoc.TabIndex = 87;
            this.btn_Nhap_MonHoc.Text = "Nhập Môn Học";
            this.btn_Nhap_MonHoc.UseVisualStyleBackColor = true;
            this.btn_Nhap_MonHoc.Click += new System.EventHandler(this.btn_Nhap_MonHoc_Click);
            // 
            // btn_Show_Diem_lanthi
            // 
            this.btn_Show_Diem_lanthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Diem_lanthi.Location = new System.Drawing.Point(390, 357);
            this.btn_Show_Diem_lanthi.Name = "btn_Show_Diem_lanthi";
            this.btn_Show_Diem_lanthi.Size = new System.Drawing.Size(229, 45);
            this.btn_Show_Diem_lanthi.TabIndex = 95;
            this.btn_Show_Diem_lanthi.Text = "In Điểm Theo Lần Thi";
            this.btn_Show_Diem_lanthi.UseVisualStyleBackColor = true;
            this.btn_Show_Diem_lanthi.Click += new System.EventHandler(this.btn_Show_Diem_lanthi_Click);
            // 
            // btn_Show_Diem_TB
            // 
            this.btn_Show_Diem_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show_Diem_TB.Location = new System.Drawing.Point(375, 417);
            this.btn_Show_Diem_TB.Name = "btn_Show_Diem_TB";
            this.btn_Show_Diem_TB.Size = new System.Drawing.Size(261, 45);
            this.btn_Show_Diem_TB.TabIndex = 96;
            this.btn_Show_Diem_TB.Text = "In Điểm Trung Bình";
            this.btn_Show_Diem_TB.UseVisualStyleBackColor = true;
            this.btn_Show_Diem_TB.Click += new System.EventHandler(this.btn_Show_Diem_TB_Click);
            // 
            // btn_add_MH_LT
            // 
            this.btn_add_MH_LT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_MH_LT.Location = new System.Drawing.Point(303, 261);
            this.btn_add_MH_LT.Name = "btn_add_MH_LT";
            this.btn_add_MH_LT.Size = new System.Drawing.Size(369, 39);
            this.btn_add_MH_LT.TabIndex = 97;
            this.btn_add_MH_LT.Text = "Nhập Môn Học và Lần Thi cho Lớp";
            this.btn_add_MH_LT.UseVisualStyleBackColor = true;
            this.btn_add_MH_LT.Click += new System.EventHandler(this.btn_add_MH_LT_Click);
            // 
            // btn_Tong_Ket
            // 
            this.btn_Tong_Ket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tong_Ket.Location = new System.Drawing.Point(356, 479);
            this.btn_Tong_Ket.Name = "btn_Tong_Ket";
            this.btn_Tong_Ket.Size = new System.Drawing.Size(261, 45);
            this.btn_Tong_Ket.TabIndex = 98;
            this.btn_Tong_Ket.Text = "In Điểm Tổng Kết";
            this.btn_Tong_Ket.UseVisualStyleBackColor = true;
            this.btn_Tong_Ket.Click += new System.EventHandler(this.btn_Tong_Ket_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 595);
            this.Controls.Add(this.btn_Tong_Ket);
            this.Controls.Add(this.btn_add_MH_LT);
            this.Controls.Add(this.btn_Show_Diem_TB);
            this.Controls.Add(this.btn_Show_Diem_lanthi);
            this.Controls.Add(this.btn_Nhap_Lop);
            this.Controls.Add(this.btn_Nhap_SV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Nhap_Diem);
            this.Controls.Add(this.btn_Nhap_MonHoc);
            this.Name = "Main_Form";
            this.Text = "Final_Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Nhap_Lop;
        private System.Windows.Forms.Button btn_Nhap_SV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Nhap_Diem;
        private System.Windows.Forms.Button btn_Nhap_MonHoc;
        private System.Windows.Forms.Button btn_Show_Diem_lanthi;
        private System.Windows.Forms.Button btn_Show_Diem_TB;
        private System.Windows.Forms.Button btn_add_MH_LT;
        private System.Windows.Forms.Button btn_Tong_Ket;
    }
}

