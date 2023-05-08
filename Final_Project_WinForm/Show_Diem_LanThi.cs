using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_WinForm
{
    public partial class Show_Diem_LanThi : Form
    {
        public Show_Diem_LanThi()
        {
            InitializeComponent();
        }
   
        
        private void btn_Show_Click(object sender, EventArgs e)
        {
            listView_ds_Diem_Lanthi.Items.Clear();
            string malop = txt_MaLop.Text;
            string maMH = txt_maMH.Text;
            string lanThi = txt_LanThi.Text;

            Nhap_Lop.DS_Lop.getSinhvien(listView_ds_Diem_Lanthi, malop, maMH, int.Parse(lanThi));


            lable_lop.Text = Nhap_Lop.DS_Lop.Ten_Lop_from_MaLop(malop);
            lable_lanthi.Text = lanThi;
            lable_MH.Text = Nhap_MonHoc.DS_MonHoc.Find_MonHoc_by_MaMH(maMH);


            lable_MH.Show();
            lable_lop.Show();
            lable_lanthi.Show();
        }

        private void Show_Diem_LanThi_Load(object sender, EventArgs e)
        {
            lable_lanthi.Hide();
            lable_lop.Hide();
            lable_MH.Hide();
            
        }
    }
}
