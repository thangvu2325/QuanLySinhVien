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
    public partial class Nhap_MonHoc : Form
    {
        public Nhap_MonHoc()
        {
            InitializeComponent();
        }
        public static BST DS_MonHoc = Main_Form.colListMonHoc.Find(new BsonDocument()).ToList()[0];
        TreeNode current_MH;
        private void btn_Add_Monhoc_Click(object sender, EventArgs e)
        {
            string MaMH = txt_MaMonHoc.Text;
            string tenMH = txt_TenMonHoc.Text;
            string stclt = txt_STCLT.Text;
            string stcth = txt_STCTH.Text;
            DS_MonHoc.Insert(new MonHoc(MaMH, tenMH, int.Parse(stclt), int.Parse(stcth)));
            ListViewItem lvi = new ListViewItem(MaMH);
            lvi.SubItems.Add(tenMH);
            lvi.SubItems.Add(stclt);
            lvi.SubItems.Add(stcth);
            listView_DSMH.Items.Add(lvi);
            Main_Form.colListMonHoc.DeleteMany(Builders<BST>.Filter.Empty);
            Main_Form.colListMonHoc.InsertOne(DS_MonHoc);

            reset_text();
        }

        private void btn_inds_Click_(object sender, EventArgs e)
        {
            
        }

        private void btn_Xoa_MH_Click(object sender, EventArgs e)
        {
            if (listView_DSMH.SelectedItems.Count > 0)
            {
                listView_DSMH.Items.RemoveAt(listView_DSMH.SelectedItems[0].Index);
                
                DS_MonHoc.Delete(DS_MonHoc.Search(txt_TenMonHoc.Text).Data);
                Main_Form.colListMonHoc.DeleteMany(Builders<BST>.Filter.Empty);
                Main_Form.colListMonHoc.InsertOne(DS_MonHoc);
            }
        }

        private void btn_fix_MH_Click(object sender, EventArgs e)
        {
            if (listView_DSMH.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView_DSMH.SelectedItems[0];
                string MaMH = txt_MaMonHoc.Text;
                string tenMH = txt_TenMonHoc.Text;
                string stclt = txt_STCLT.Text;
                string stcth = txt_STCTH.Text;
                lvi.SubItems[0].Text = MaMH;
                lvi.SubItems[1].Text = tenMH;
                lvi.SubItems[2].Text = stclt;
                lvi.SubItems[3].Text = stcth;

                current_MH.Data = new MonHoc(MaMH, tenMH, int.Parse(stclt), int.Parse(stcth));
                Main_Form.colListMonHoc.DeleteMany(Builders<BST>.Filter.Empty);
                Main_Form.colListMonHoc.InsertOne(DS_MonHoc);
            }
        }

        private void listView_DSMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_DSMH.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView_DSMH.SelectedItems[0];
                string maMH = lvi.SubItems[0].Text;
                string tenMH = lvi.SubItems[1].Text;
                string stclt = lvi.SubItems[2].Text;
                string stcth = lvi.SubItems[3].Text;

                txt_MaMonHoc.Text = maMH;
                txt_TenMonHoc.Text = tenMH;
                txt_STCLT.Text = stclt;
                txt_STCTH.Text = stcth;
                current_MH = DS_MonHoc.Search(tenMH);
            }
        }

        private void btn_inds_Click(object sender, EventArgs e)
        {
            listView_DSMH.Items.Clear();
            DS_MonHoc.Inorder(listView_DSMH);
        }
        void reset_text()
        {
            txt_MaMonHoc.ResetText();
            txt_TenMonHoc.ResetText();
            txt_STCLT.ResetText();
            txt_STCTH.ResetText();
            txt_MaMonHoc.Focus();
        }
    }
}
