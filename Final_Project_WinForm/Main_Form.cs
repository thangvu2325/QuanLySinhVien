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

    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            Setup();
        }


        private void btn_Nhap_Lop_Click(object sender, EventArgs e)
        {
            Nhap_Lop nhapLop = new Nhap_Lop();
            nhapLop.Show();
        }
        public static IMongoCollection<LinkedList_Lop> colListClass;
        public static IMongoCollection<BST> colListMonHoc;
        private const string MongoConnectionString = "mongodb://localhost:27017";
        private static void Setup()
        {

            var mongoClient = new MongoClient(MongoConnectionString);
            var db = mongoClient.GetDatabase("baitapcuoiky");
            db.CreateCollectionAsync("Danhsachlop");
            db.CreateCollectionAsync("Danhsachmonhoc");
            colListClass = db.GetCollection<LinkedList_Lop>("Danhsachlop");
            colListMonHoc = db.GetCollection<BST>("Danhsachmonhoc");

        }

        private void btn_Nhap_SV_Click(object sender, EventArgs e)
        {
            Nhap_SV nhapSV = new Nhap_SV();
            nhapSV.Show();
        }

        private void btn_Nhap_MonHoc_Click(object sender, EventArgs e)
        {
            Nhap_MonHoc nhapMonHoc = new Nhap_MonHoc();
            nhapMonHoc.Show();
        }

        private void btn_Nhap_Diem_Click(object sender, EventArgs e)
        {
            Nhap_Diem nhapDiem = new Nhap_Diem();
            nhapDiem.Show();
        }

        private void btn_Show_Diem_lanthi_Click(object sender, EventArgs e)
        {
            Show_Diem_LanThi diemLanthi = new Show_Diem_LanThi();
            diemLanthi.Show();
        }

        private void btn_Show_Diem_TB_Click(object sender, EventArgs e)
        {
            Show_Diem_TB diemTB = new Show_Diem_TB();
            diemTB.Show();
        }

        private void btn_add_MH_LT_Click(object sender, EventArgs e)
        {
            Nhap_MonHoc_SV nhap_MH_LT = new Nhap_MonHoc_SV();
            nhap_MH_LT.Show();
        }

        private void btn_Tong_Ket_Click(object sender, EventArgs e)
        {
            Show_Diem_TongKet tongket = new Show_Diem_TongKet();
            tongket.Show();
        }
    }
}
