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
    
    public partial class Nhap_Lop : Form
    {
        public Nhap_Lop()
        {
            InitializeComponent();
        }

        public static LinkedList_Lop DS_Lop = Main_Form.colListClass.Find(new BsonDocument()).ToList()[0];
        //public object DS_Lop { get; private set; }
        SingleNode<Lop> currentLop;
        private void btn_Add_Lop_Click(object sender, EventArgs e)
        {

            String malop = txt_Ma_Lop.Text;
            String tenlop = txt_Ten_Lop.Text;
            int namhoc = int.Parse(txt_Nam_hoc.Text);
            DS_Lop.AddLast(new Lop(malop, tenlop, namhoc,new LinkedList_SinhVien()));

            ListViewItem lvi = new ListViewItem(malop);
            lvi.SubItems.Add(tenlop);
            lvi.SubItems.Add(namhoc.ToString());
            listView_DS_Lop.Items.Add(lvi);
            Main_Form.colListClass.DeleteMany(Builders<LinkedList_Lop>.Filter.Empty);
            Main_Form.colListClass.InsertOne(DS_Lop);
        }

        private void btn_in_ds_Click(object sender, EventArgs e)
        {
            listView_DS_Lop.Items.Clear();
            DS_Lop.Traverse(listView_DS_Lop,int.Parse(txt_NienKhoa.Text));
        }

        private void listView_DS_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_DS_Lop.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView_DS_Lop.SelectedItems[0];
                string malop = lvi.SubItems[0].Text;
                string tenlop = lvi.SubItems[1].Text;
                string namhoc = lvi.SubItems[2].Text;
                txt_Ma_Lop.Text = malop;
                txt_Ten_Lop.Text = tenlop;
                txt_Nam_hoc.Text = namhoc;

                currentLop = DS_Lop.Search(malop);

            }
        }

        private void btn_Fix_Lop_Click(object sender, EventArgs e)
        {
            if (listView_DS_Lop.SelectedItems.Count > 0)
            { 
                ListViewItem lvi = listView_DS_Lop.SelectedItems[0];
                string malop = txt_Ma_Lop.Text;
                string tenlop = txt_Ten_Lop.Text;
                string namhoc = txt_Nam_hoc.Text;
                lvi.SubItems[0].Text = malop;
                lvi.SubItems[1].Text = tenlop;
                lvi.SubItems[2].Text = namhoc;
                DS_Lop.Update(new Lop(malop, tenlop, int.Parse(namhoc), new LinkedList_SinhVien()), currentLop);
                Main_Form.colListClass.DeleteMany(Builders<LinkedList_Lop>.Filter.Empty);
                Main_Form.colListClass.InsertOne(DS_Lop);
            }
        }

        private void btn_Xoa_Lop_Click(object sender, EventArgs e)
        {
            if (listView_DS_Lop.SelectedItems.Count > 0)
            {
                listView_DS_Lop.Items.RemoveAt(listView_DS_Lop.SelectedItems[0].Index);
                DS_Lop.Remove(currentLop);
                Main_Form.colListClass.DeleteMany(Builders<LinkedList_Lop>.Filter.Empty);
                Main_Form.colListClass.InsertOne(DS_Lop);
            }
        }

        private void btn_ds_non_Click(object sender, EventArgs e)
        {
            listView_DS_Lop.Items.Clear();
            DS_Lop.Traverse(listView_DS_Lop);

        }
    }
}

