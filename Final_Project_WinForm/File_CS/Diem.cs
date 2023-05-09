using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_WinForm
{
    public class Diem
    {
        public string MAMH  { get; set; }
        public int LAN { get; set; }
        public double DIEM { get; set; }

        public Diem(string mamh, int lan, double diem)
        {
            MAMH = mamh;
            LAN = lan;
            DIEM = diem;
        }
    }
}
