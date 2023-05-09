using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace Final_Project_WinForm
{
    public partial class Nhap_SV : Form
    {
        public Nhap_SV()
        {
            InitializeComponent();
        }
        String Phai;
        public static SingleNode<Lop> current_DS_Lop;
        SingleNode<SinhVien> current_SV;
        private void btn_Select_Click(object sender, EventArgs e)
        {

            listView_DSSV.Items.Clear();
            current_DS_Lop = Nhap_Lop.DS_Lop.Find_Lop(txt_Ma_Lop.Text);
            
            if(current_DS_Lop == null)
            {
                panel_add_sv.Hide();
                MessageBox.Show("Úi không có lớp này bạn ơi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Ma_Lop.ResetText();
                txt_Ma_Lop.Focus();
            }
            else
            {
                current_DS_Lop.data.DSSV.Traverse(listView_DSSV);
                panel_add_sv.Show();
                txt_MSSV.Focus();
            }
            
            
        }
        private void btn_Them_SV_Click(object sender, EventArgs e)
        {
            
            string mssv = txt_MSSV.Text;
            string ho = txt_HO.Text;
            string ten = txt_Ten.Text;
            string sdt = txt_SDT.Text;

            current_DS_Lop.data.DSSV.AddLast(new SinhVien(int.Parse(mssv), ho, ten, Phai, sdt, new LinkedList_Diem()));

            ListViewItem lvi = new ListViewItem(mssv);
            lvi.SubItems.Add(ho);
            lvi.SubItems.Add(ten);
            lvi.SubItems.Add(Phai);
            lvi.SubItems.Add(sdt);
            listView_DSSV.Items.Add(lvi);
            Main_Form.colListClass.DeleteMany(Builders<LinkedList_Lop>.Filter.Empty);
            Main_Form.colListClass.InsertOne(Nhap_Lop.DS_Lop);

            reset_text();
        }

        

        private void checkBox_Nam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Nam.Checked)
            {
                Phai = "Nam";
                checkBox_NU.Checked = false;
            }
        }

        private void checkBox_NU_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_NU.Checked)
            {
                Phai = "Nữ";
                checkBox_Nam.Checked = false;
            }  
        }

        private void listView_DSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_DSSV.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView_DSSV.SelectedItems[0];
                string mssv = lvi.SubItems[0].Text;
                string ho = lvi.SubItems[1].Text;
                string ten = lvi.SubItems[2].Text;
                string phai = lvi.SubItems[3].Text;
                string sdt = lvi.SubItems[4].Text;

                txt_MSSV.Text = mssv;
                txt_HO.Text = ho;
                txt_Ten.Text = ten;
                txt_SDT.Text = sdt;
                if (phai == "Nam") checkBox_Nam.Checked = true;
                else checkBox_NU.Checked = true;

                current_SV = current_DS_Lop.data.DSSV.Search(int.Parse(mssv));
            }
        }

        private void btn_Fix_SV_Click(object sender, EventArgs e)
        {
            if (listView_DSSV.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView_DSSV.SelectedItems[0];
                string mssv = txt_MSSV.Text;
                string ho = txt_HO.Text;
                string ten = txt_Ten.Text;
                string sdt = txt_SDT.Text;
                lvi.SubItems[0].Text = mssv;
                lvi.SubItems[1].Text = ho;
                lvi.SubItems[2].Text = ten;
                lvi.SubItems[3].Text = (checkBox_Nam.Checked == true ? "Nam" : "Nữ");
                lvi.SubItems[4].Text = sdt;
                current_DS_Lop.data.DSSV.Update(new SinhVien(int.Parse(mssv), ho, ten, Phai, sdt, current_SV.data.DSDiem), current_SV);
                Main_Form.colListClass.DeleteMany(Builders<LinkedList_Lop>.Filter.Empty);
                Main_Form.colListClass.InsertOne(Nhap_Lop.DS_Lop);

            }

        }

        private void btn_Xoa_SV_Click(object sender, EventArgs e)
        {
            if (listView_DSSV.SelectedItems.Count > 0)
            {
                listView_DSSV.Items.RemoveAt(listView_DSSV.SelectedItems[0].Index);
                current_DS_Lop.data.DSSV.Remove(current_SV);
                Main_Form.colListClass.DeleteMany(Builders<LinkedList_Lop>.Filter.Empty);
                Main_Form.colListClass.InsertOne(Nhap_Lop.DS_Lop);
            }
        }

        private void Nhap_SV_Load(object sender, EventArgs e)
        {
            panel_add_sv.Hide();
        }
        private void reset_text()
        {
            txt_MSSV.ResetText();
            txt_Ma_Lop.ResetText();
            txt_HO.ResetText();
            txt_Ten.ResetText();
            txt_SDT.ResetText();
            checkBox_Nam.Checked = false;
            checkBox_NU.Checked = false;
            txt_MSSV.Focus();
        }
    }
}
