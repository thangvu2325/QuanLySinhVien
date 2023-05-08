using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_WinForm
{
    public class Lop
    {
        public string MALOP { get; set; }
        public string TENLOP { get; set; }
        public int NAMNHAPHOC { get; set; }
        public LinkedList_SinhVien DSSV { get; set; }

        public Lop(string malop, string tenlop, int namnhaphoc, LinkedList_SinhVien dssv)
        {
            MALOP = malop;
            TENLOP = tenlop;
            NAMNHAPHOC = namnhaphoc;
            DSSV = dssv;
        }
    }
}
