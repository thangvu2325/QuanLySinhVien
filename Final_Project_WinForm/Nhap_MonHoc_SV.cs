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
    public partial class Nhap_MonHoc_SV : Form
    {
        public Nhap_MonHoc_SV()
        {
            InitializeComponent();
        }
        SingleNode<Lop> current_lop;
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string malop = txt_MaLop.Text;
            string maMH = txt_MaMH.Text;
            string LanThi = txt_LanThi.Text;

            ListViewItem lvi = new ListViewItem(malop);
            lvi.SubItems.Add(maMH);
            lvi.SubItems.Add(LanThi);
            listView_DS_MH_LT.Items.Add(lvi);

            current_lop = Nhap_Lop.DS_Lop.Find_Lop(malop);

            current_lop.data.DSSV.Add_MonHoc(maMH, LanThi);
            Main_Form.colListClass.DeleteMany(Builders<LinkedList_Lop>.Filter.Empty);
            Main_Form.colListClass.InsertOne(Nhap_Lop.DS_Lop);

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (listView_DS_MH_LT.SelectedItems.Count > 0)
            {
                string malop = txt_MaLop.Text;
                string maMH = txt_MaMH.Text;
                string LanThi = txt_LanThi.Text;
                listView_DS_MH_LT.Items.RemoveAt(listView_DS_MH_LT.SelectedItems[0].Index);
                current_lop = Nhap_Lop.DS_Lop.Find_Lop(malop);
                current_lop.data.DSSV.Remove_MonHoc(maMH, LanThi);

                Main_Form.colListClass.DeleteMany(Builders<LinkedList_Lop>.Filter.Empty);
                Main_Form.colListClass.InsertOne(Nhap_Lop.DS_Lop);
            }
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            if (listView_DS_MH_LT.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView_DS_MH_LT.SelectedItems[0];
                string malop = txt_MaLop.Text;
                string maMH = txt_MaMH.Text;
                string LanThi = txt_LanThi.Text;
                lvi.SubItems[0].Text = malop;
                lvi.SubItems[1].Text = maMH;
                lvi.SubItems[2].Text = LanThi;
                Main_Form.colListClass.DeleteMany(Builders<LinkedList_Lop>.Filter.Empty);
                Main_Form.colListClass.InsertOne(Nhap_Lop.DS_Lop);


                //current_MH.Data = new MonHoc(MaMH, tenMH, int.Parse(stclt), int.Parse(stcth));
            }
        }

        private void listView_DS_MH_LT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_DS_MH_LT.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView_DS_MH_LT.SelectedItems[0];
                string maLop = lvi.SubItems[0].Text;
                string maMH = lvi.SubItems[1].Text;
                string LanThi = lvi.SubItems[2].Text;

                txt_MaLop.Text = maLop;
                txt_MaMH.Text = maMH;
                txt_LanThi.Text = LanThi;

               // current_MH = DS_MonHoc.Search(tenMH);
            }
        }
    }
}
