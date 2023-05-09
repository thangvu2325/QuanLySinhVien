<<<<<<< HEAD:Final_Project_WinForm/Nhap_Diem.cs
﻿using System;
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
    public partial class Nhap_Diem : Form
    {
        public Nhap_Diem()
        {
            InitializeComponent();
        }
        string MSSV_upDiem;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            listView_ds_Diem.Items.Clear();
            string malop = txt_MaLop.Text;
            string maMH = txt_maMH.Text;
            string lanThi = txt_LanThi.Text;

            Nhap_Lop.DS_Lop.getSinhvien(listView_ds_Diem,malop, maMH, int.Parse(lanThi)); 

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (listView_ds_Diem.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView_ds_Diem.SelectedItems[0];
                lvi.SubItems[4].Text = txt_diem.Text;

                string malop = txt_MaLop.Text;
                string maMH = txt_maMH.Text;
                string lanThi = txt_LanThi.Text;
                Nhap_Lop.DS_Lop.getSinhvien(listView_ds_Diem, malop, maMH, int.Parse(lanThi), MSSV_upDiem, int.Parse(txt_diem.Text));
                Main_Form.colListClass.DeleteMany(Builders<LinkedList_Lop>.Filter.Empty);
                Main_Form.colListClass.InsertOne(Nhap_Lop.DS_Lop);

            }
        }

        private void listView_ds_Diem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView_ds_Diem.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView_ds_Diem.SelectedItems[0];
                lab_mssv.Text = lvi.SubItems[1].Text;
                MSSV_upDiem = lvi.SubItems[1].Text;
            }
        }
    }
}
=======
﻿using System;
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
    public partial class Nhap_Diem : Form
    {
        public Nhap_Diem()
        {
            InitializeComponent();
        }
        string MSSV_upDiem;
        private void btn_Show_Click(object sender, EventArgs e)
        {
            listView_ds_Diem.Items.Clear();
            string malop = txt_MaLop.Text;
            string maMH = txt_maMH.Text;
            string lanThi = txt_LanThi.Text;

            Nhap_Lop.DS_Lop.getSinhvien(listView_ds_Diem,malop, maMH, int.Parse(lanThi)); 
            
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (listView_ds_Diem.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView_ds_Diem.SelectedItems[0];
                lvi.SubItems[4].Text = txt_diem.Text;

                string malop = txt_MaLop.Text;
                string maMH = txt_maMH.Text;
                string lanThi = txt_LanThi.Text;
                Nhap_Lop.DS_Lop.getSinhvien(listView_ds_Diem, malop, maMH, int.Parse(lanThi), MSSV_upDiem, int.Parse(txt_diem.Text));
                Main_Form.colListClass.DeleteMany(Builders<LinkedList_Lop>.Filter.Empty);
                Main_Form.colListClass.InsertOne(Nhap_Lop.DS_Lop);
            }
            txt_diem.ResetText();
        }

        private void listView_ds_Diem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView_ds_Diem.SelectedItems.Count > 0)
            {
                ListViewItem lvi = listView_ds_Diem.SelectedItems[0];
                lab_mssv.Text = lvi.SubItems[1].Text;
                MSSV_upDiem = lvi.SubItems[1].Text;
              
            }
        }
    }
}
>>>>>>> 4a3ac13832f8ccc7ef38f6c3d7da3b2474f7c4da:Final_Project_WinForm/Form_CS/Nhap_Diem.cs
