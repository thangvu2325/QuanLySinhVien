using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_WinForm
{
    public class SinhVien
    {
        public int MASV { get; set; }
        public string HO { get; set; }
        public string TEN { get; set; }
        public string PHAI { get; set; }
        public string SODT { get; set; }
        public LinkedList_Diem DSDiem { get; set; }
        public SinhVien(int masv, string ho, string ten, string phai, string sodt, LinkedList_Diem dsdiem)
        {
            MASV = masv;
            HO = ho;
            TEN = ten;
            PHAI = phai;
            SODT = sodt;
            DSDiem = dsdiem;
        }
    }
}
